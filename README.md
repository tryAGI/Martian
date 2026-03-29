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

<!-- EXAMPLES:START -->
<!-- EXAMPLES:END -->

## Support

Priority place for bugs: https://github.com/tryAGI/Martian/issues  
Priority place for ideas and general questions: https://github.com/tryAGI/Martian/discussions  
Discord: https://discord.gg/Ca2xhfBf3v  

## Acknowledgments

![JetBrains logo](https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png)

This project is supported by JetBrains through the [Open Source Support Program](https://jb.gg/OpenSourceSupport).
