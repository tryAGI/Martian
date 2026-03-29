# CLAUDE.md -- Martian SDK

## Overview

Auto-generated C# SDK for [Martian](https://withmartian.com/) -- intelligent LLM router and gateway providing unified access to 200+ AI models with cost, quality, and latency optimization.
**No public OpenAPI spec exists** -- `openapi.yaml` was manually created from Martian Gateway documentation.

## Build & Test

```bash
dotnet build Martian.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Bearer token auth:

```csharp
var client = new MartianClient(apiKey); // MARTIAN_API_KEY env var
```

## Key Files

- `src/libs/Martian/openapi.yaml` -- **Manually maintained** OpenAPI spec (no public spec from Martian)
- `src/libs/Martian/generate.sh` -- Runs autosdk with `--security-scheme Http:Header:Bearer` (no download step)
- `src/libs/Martian/Generated/` -- **Never edit** -- auto-generated code
- `src/libs/Martian/Extensions/MartianClient.Tools.cs` -- MEAI AIFunction tools (AsListModelsTool, AsChatCompletionTool, AsRoutedChatTool, AsAnthropicMessageTool)
- `src/tests/IntegrationTests/Tests.cs` -- Test helper with bearer auth
- `src/tests/IntegrationTests/Examples/` -- Example tests (also generate docs)

## Spec Notes

- **No public OpenAPI spec exists** -- `openapi.yaml` was manually created from docs.withmartian.com
- 3 endpoints: chat completions (OpenAI-compatible), messages (Anthropic-compatible), list models
- Auth: standard HTTP Bearer token via `--security-scheme Http:Header:Bearer`
- Unique router parameters: `models`, `max_cost`, `max_cost_per_million_tokens`, `willingness_to_pay`

## Endpoints

| Endpoint | Method | Description |
|----------|--------|-------------|
| `/v1/chat/completions` | POST | Chat completions (OpenAI-compatible + Martian router parameters) |
| `/v1/messages` | POST | Messages (Anthropic-compatible) |
| `/v1/models` | GET | List available models with pricing and reliability info |

## MEAI Tools

| Tool | Description |
|------|-------------|
| `AsListModelsTool()` | Lists all available models with pricing and reliability |
| `AsChatCompletionTool()` | Chat completion with optional cost constraints |
| `AsRoutedChatTool()` | Cost-optimized routing across multiple models |
| `AsAnthropicMessageTool()` | Anthropic-compatible messages via the gateway |

## Note on CustomProvider

Martian is OpenAI-compatible (`api.withmartian.com/v1`), so it could also work as a `CustomProviders.Martian()` in `tryAGI.OpenAI` for basic chat completions. However, this standalone SDK is preferred because Martian has:
1. Unique router parameters (`models`, `max_cost`, `willingness_to_pay`, `max_cost_per_million_tokens`)
2. An Anthropic-compatible Messages endpoint (`/v1/messages`)
3. A models endpoint with pricing/reliability metadata
