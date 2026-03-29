#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: locally maintained (no public spec available)

dotnet tool install --global autosdk.cli --prerelease

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
