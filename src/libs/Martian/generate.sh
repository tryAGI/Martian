#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

# OpenAPI spec: locally maintained (no public spec available)
# --reject-unknown-enum-values is only safe on a build that narrows it to enums which cannot appear in
# a response; an older one accepts the flag and hardens every enum, so ordinary replies start throwing.
# `autosdk capabilities --require` asks the build itself, which replaces both a version floor (had to be
# looked up after each publish, and moved once already) and a grep over help-text prose. A CLI without
# the subcommand fails the call, so this is fail-closed.
require_autosdk_capability() {
  if ! autosdk capabilities --require "$1" >/dev/null 2>&1; then
    echo "error: this autosdk.cli does not support '$1'." >&2
    echo "       Run: dotnet tool update --global autosdk.cli --prerelease" >&2
    exit 1
  fi
}
install_autosdk_cli
require_autosdk_capability behavior:request-scoped-enum-rejection

rm -rf Generated

# Martian has no public OpenAPI spec — openapi.yaml is manually maintained from docs.
# Auth: standard HTTP Bearer token via Authorization header.
# `stream: true` on chat completions returns server-sent events, and the spec declares only
# `application/json` - so the generator has no reason to emit a streaming method and a caller who
# sets the flag gets a parse failure instead of a stream. The event schema is already in the spec
# (`ChatCompletionChunkResponse`); only the content type was missing.
yq -i '.paths."/v1/chat/completions".post.responses."200".content."text/event-stream".schema."$ref" = "#/components/schemas/ChatCompletionChunkResponse"' openapi.yaml

# yq exits 0 when its expression fails to parse, so verify the effect rather than the exit code.
if ! yq -e '.paths."/v1/chat/completions".post.responses."200".content | has("text/event-stream")' openapi.yaml >/dev/null; then
  echo "error: the streaming content-type patch did not apply to openapi.yaml." >&2
  exit 1
fi

autosdk generate openapi.yaml \
  --namespace Martian \
  --clientClassName MartianClient \
  --targetFramework net10.0 \
  --output Generated \
  --reject-unknown-enum-values \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer

rm -rf ../../cli/Martian.CLI

autosdk cli-project openapi.yaml \
  --output ../../cli/Martian.CLI \
  --sdk-project ../../libs/Martian/Martian.csproj \
  --targetFramework net10.0 \
  --namespace Martian \
  --clientClassName MartianClient \
  --package-id Martian.CLI \
  --tool-command-name martian \
  --user-secrets-id Martian.CLI \
  --api-key-env-var MARTIAN_API_KEY \
  --base-url-env-var MARTIAN_BASE_URL \
  --cli-credential-file \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer
