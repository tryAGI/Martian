#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

# OpenAPI spec: locally maintained (no public spec available)
install_autosdk_cli

rm -rf Generated

# Martian has no public OpenAPI spec — openapi.yaml is manually maintained from docs.
# Auth: standard HTTP Bearer token via Authorization header.
autosdk generate openapi.yaml \
  --namespace Martian \
  --clientClassName MartianClient \
  --targetFramework net10.0 \
  --output Generated \
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
