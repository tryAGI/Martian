using Microsoft.Extensions.AI;

namespace Martian;

/// <summary>
/// Extensions for using MartianClient as MEAI tools with any IChatClient.
/// </summary>
public static class MartianToolExtensions
{
    /// <summary>
    /// Creates an <see cref="AIFunction"/> that lists all available models
    /// on the Martian Gateway with their pricing and reliability information.
    /// </summary>
    /// <param name="client">The Martian client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsListModelsTool(this MartianClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var response = await client.ListModelsAsync(
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatListModelsResponse(response);
            },
            name: "MartianListModels",
            description: "Lists all available AI models on the Martian Gateway with pricing (input/output cost per token in USD), reliability tier, and max completion tokens.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that sends a chat completion request
    /// via the Martian Gateway with intelligent routing.
    /// </summary>
    /// <param name="client">The Martian client to use.</param>
    /// <param name="model">The default model to use in provider/model-name format (e.g., openai/gpt-4.1-nano).</param>
    /// <param name="maxCost">Optional maximum cost for the request in USD.</param>
    /// <param name="willingnessToPay">Optional willingness to pay for better output (dollars per 10% improvement).</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsChatCompletionTool(
        this MartianClient client,
        string model = "openai/gpt-4.1-nano",
        float? maxCost = null,
        float? willingnessToPay = null)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string prompt, CancellationToken cancellationToken) =>
            {
                var response = await client.CreateChatCompletionAsync(
                    model: model,
                    messages: [new ChatCompletionMessage
                    {
                        Role = ChatCompletionMessageRole.User,
                        Content = prompt,
                    }],
                    maxCost: maxCost,
                    willingnessToPay: willingnessToPay,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatChatCompletionResponse(response);
            },
            name: "MartianChatCompletion",
            description: "Sends a chat completion request via the Martian Gateway, which intelligently routes to the best LLM based on cost, quality, and latency. Returns the model's response text.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that sends a cost-optimized chat completion
    /// request via the Martian Gateway router, routing across multiple models.
    /// </summary>
    /// <param name="client">The Martian client to use.</param>
    /// <param name="models">The models the router can choose from.</param>
    /// <param name="maxCost">Maximum cost for the request in USD.</param>
    /// <param name="maxCostPerMillionTokens">Maximum cost per million tokens in USD.</param>
    /// <param name="willingnessToPay">Value of better output in dollars per 10% improvement.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsRoutedChatTool(
        this MartianClient client,
        IList<string>? models = null,
        float? maxCost = null,
        float? maxCostPerMillionTokens = null,
        float? willingnessToPay = null)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string prompt, string? model, CancellationToken cancellationToken) =>
            {
                var response = await client.CreateChatCompletionAsync(
                    model: model ?? "router",
                    messages: [new ChatCompletionMessage
                    {
                        Role = ChatCompletionMessageRole.User,
                        Content = prompt,
                    }],
                    models: models,
                    maxCost: maxCost,
                    maxCostPerMillionTokens: maxCostPerMillionTokens,
                    willingnessToPay: willingnessToPay,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatChatCompletionResponse(response);
            },
            name: "MartianRoutedChat",
            description: "Sends a chat completion request via the Martian LLM router, which automatically selects the best model from a pool based on cost, quality, and latency constraints. Supports cost limits and willingness-to-pay for cost-performance optimization.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that sends a message via the Anthropic-compatible
    /// endpoint on the Martian Gateway.
    /// </summary>
    /// <param name="client">The Martian client to use.</param>
    /// <param name="model">The model to use in provider/model-name format (e.g., anthropic/claude-sonnet-4-20250514).</param>
    /// <param name="maxTokens">Maximum number of tokens to generate (default: 1024).</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsAnthropicMessageTool(
        this MartianClient client,
        string model = "anthropic/claude-sonnet-4-20250514",
        int maxTokens = 1024)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (string prompt, string? systemPrompt, CancellationToken cancellationToken) =>
            {
                var response = await client.CreateMessageAsync(
                    model: model,
                    messages: [new AnthropicMessage
                    {
                        Role = AnthropicMessageRole.User,
                        Content = prompt,
                    }],
                    maxTokens: maxTokens,
                    system: systemPrompt,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatMessagesResponse(response);
            },
            name: "MartianAnthropicMessage",
            description: "Sends a message via the Martian Gateway using the Anthropic Messages API format. Useful for accessing Anthropic models (e.g., Claude) through the gateway with an optional system prompt.");
    }

    private static string FormatListModelsResponse(ListModelsResponse response)
    {
        var parts = new List<string>();

        if (response.Data is { Count: > 0 })
        {
            parts.Add($"Available models ({response.Data.Count}):");
            foreach (var model in response.Data)
            {
                var entry = $"- {model.Id}";
                if (!string.IsNullOrWhiteSpace(model.OwnedBy))
                {
                    entry += $" (by {model.OwnedBy})";
                }
                if (!string.IsNullOrWhiteSpace(model.InputCostPerToken))
                {
                    entry += $" | input: ${model.InputCostPerToken}/token";
                }
                if (!string.IsNullOrWhiteSpace(model.OutputCostPerToken))
                {
                    entry += $" | output: ${model.OutputCostPerToken}/token";
                }
                if (model.Reliability != null)
                {
                    entry += $" | reliability: {model.Reliability}";
                }
                if (model.MaxCompletionTokens != null)
                {
                    entry += $" | max tokens: {model.MaxCompletionTokens}";
                }

                parts.Add(entry);
            }
        }
        else
        {
            parts.Add("No models available.");
        }

        return string.Join("\n", parts);
    }

    private static string FormatChatCompletionResponse(ChatCompletionResponse response)
    {
        var parts = new List<string>();

        if (!string.IsNullOrWhiteSpace(response.Model))
        {
            parts.Add($"Model: {response.Model}");
        }

        if (response.Choices is { Count: > 0 })
        {
            foreach (var choice in response.Choices)
            {
                if (choice.Message?.Content is { } content)
                {
                    parts.Add(content.IsValue1 ? content.Value1 ?? string.Empty : "[structured content]");
                }
                if (choice.FinishReason != null)
                {
                    parts.Add($"Finish reason: {choice.FinishReason}");
                }
            }
        }

        if (response.Usage != null)
        {
            parts.Add($"Usage: {response.Usage.PromptTokens} prompt + {response.Usage.CompletionTokens} completion = {response.Usage.TotalTokens} total tokens");
        }

        return string.Join("\n", parts);
    }

    private static string FormatMessagesResponse(MessagesResponse response)
    {
        var parts = new List<string>();

        if (!string.IsNullOrWhiteSpace(response.Model))
        {
            parts.Add($"Model: {response.Model}");
        }

        if (response.Content is { Count: > 0 })
        {
            foreach (var block in response.Content)
            {
                if (block.Type == AnthropicResponseContentBlockType.Text &&
                    !string.IsNullOrWhiteSpace(block.Text))
                {
                    parts.Add(block.Text);
                }
                else if (block.Type == AnthropicResponseContentBlockType.ToolUse)
                {
                    parts.Add($"[Tool call: {block.Name}]");
                }
            }
        }

        if (response.StopReason != null)
        {
            parts.Add($"Stop reason: {response.StopReason}");
        }

        if (response.Usage != null)
        {
            parts.Add($"Usage: {response.Usage.InputTokens} input + {response.Usage.OutputTokens} output tokens");
        }

        return string.Join("\n", parts);
    }
}
