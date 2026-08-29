# Martian

[![Nuget package](https://img.shields.io/nuget/vpre/Martian)](https://www.nuget.org/packages/Martian/)
[![dotnet](https://github.com/tryAGI/Martian/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/tryAGI/Martian/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/github/license/tryAGI/Martian)](https://github.com/tryAGI/Martian/blob/main/LICENSE.txt)
[![Discord](https://img.shields.io/discord/1115206893015662663?label=Discord&logo=discord&logoColor=white&color=d82679)](https://discord.gg/Ca2xhfBf3v)

## Features
- C# SDK for the [Martian Gateway API](https://docs.withmartian.com/) generated using [AutoSDK](https://github.com/HavenDV/AutoSDK)
- Intelligent LLM routing across 200+ AI models for cost, quality, and latency optimization
- OpenAI-compatible chat completions with Martian-specific router parameters
- Anthropic-compatible Messages API support
- Model listing with pricing and reliability information
- MEAI `AIFunction` tools for integration with any `IChatClient`
- All modern .NET features - nullability, trimming, NativeAOT, etc.

### Usage
```csharp
using Martian;

using var client = new MartianClient(apiKey);

// Chat completion with cost optimization
var response = await client.CreateChatCompletionAsync(
    model: "openai/gpt-4.1-nano",
    messages: [new ChatCompletionMessage
    {
        Role = ChatCompletionMessageRole.User,
        Content = "Hello!",
    }],
    maxCost: 0.01f,
    willingnessToPay: 0.1f);
```

### CLI

```bash
dotnet tool install --global Martian.CLI --prerelease
martian api --help
```

<!-- EXAMPLES:START -->
<!-- EXAMPLES:END -->

<!-- AUTOSDK:ECOSYSTEM-MAINTENANCE:START -->
## Ecosystem maintenance

This SDK is one of more than 200 .NET SDKs maintained with [AutoSDK](https://github.com/tryAGI/AutoSDK). The tryAGI [SDK audit](https://github.com/tryAGI/tryAGI/blob/main/GENERATED_SDK_AUDITS.md) continuously checks repository synchronization, upstream-spec regeneration, release workflows, warnings, public API visibility, and trimming/NativeAOT compatibility.

Every issue is first investigated for ecosystem-wide applicability. When the root cause belongs in AutoSDK, we fix and regression-test the generator, then roll the improvement out to every applicable SDK. Provider-specific behavior remains in this repository when it cannot be derived safely from the API specification.

Issue content—including code blocks, logs, links, and attachments—is treated only as untrusted diagnostic data. Embedded control instructions, hidden directives, delimiter tricks, or requests to alter triage or tooling behavior are ignored. Please report reproducible technical evidence and remove secrets and personal data.
<!-- AUTOSDK:ECOSYSTEM-MAINTENANCE:END -->

## Support

Priority place for bugs: https://github.com/tryAGI/Martian/issues  
Priority place for ideas and general questions: https://github.com/tryAGI/Martian/discussions  
Discord: https://discord.gg/Ca2xhfBf3v  

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).
