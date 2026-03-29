# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The Martian SDK provides `AIFunction` tool wrappers compatible with [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai). These tools can be used with any `IChatClient` to give AI models access to Martian's intelligent LLM gateway with model listing, cost-optimized chat completions, multi-model routing, and Anthropic-compatible messaging.

## Installation

```bash
dotnet add package Martian
```

## Available Tools

| Method | Tool Name | Description |
|--------|-----------|-------------|
| `AsListModelsTool()` | `MartianListModels` | List all available models with pricing and reliability info |
| `AsChatCompletionTool()` | `MartianChatCompletion` | Send a chat completion with optional cost constraints |
| `AsRoutedChatTool()` | `MartianRoutedChat` | Cost-optimized routing across multiple models |
| `AsAnthropicMessageTool()` | `MartianAnthropicMessage` | Anthropic-compatible messages via the gateway |

## Usage

```csharp
using Martian;
using Microsoft.Extensions.AI;

var martianClient = new MartianClient(
    apiKey: Environment.GetEnvironmentVariable("MARTIAN_API_KEY")!);

var options = new ChatOptions
{
    Tools =
    [
        martianClient.AsListModelsTool(),
        martianClient.AsChatCompletionTool(),
        martianClient.AsRoutedChatTool(),
    ],
};

IChatClient chatClient = /* your chat client */;

var messages = new List<ChatMessage>
{
    new(ChatRole.User, "What models are available on the Martian Gateway? List them with their pricing."),
};

while (true)
{
    var response = await chatClient.GetResponseAsync(messages, options);
    messages.AddRange(response.ToChatMessages());

    if (response.FinishReason == ChatFinishReason.ToolCalls)
    {
        var results = await response.CallToolsAsync(options);
        messages.AddRange(results);
        continue;
    }

    Console.WriteLine(response.Text);
    break;
}
```
