#nullable enable

using System.CommandLine;

namespace Martian.CLI.Commands;

internal sealed record ChatCompletionRequestOptionSet(
    Option<string> Model,
                     Option<float?> Temperature,
                     Option<int?> MaxCompletionTokens,
                     Option<int?> MaxTokens,
                     Option<bool?> Stream,
                     Option<float?> FrequencyPenalty,
                     Option<float?> PresencePenalty,
                     Option<float?> TopP,
                     Option<int?> Seed,
                     Option<bool?> Logprobs,
                     Option<int?> TopLogprobs,
                     Option<string?> User,
                     Option<global::System.Collections.Generic.IList<string>?> Models,
                     Option<float?> MaxCost,
                     Option<float?> MaxCostPerMillionTokens,
                     Option<float?> WillingnessToPay)
{
    public static ChatCompletionRequestOptionSet Create(string? prefix = null)
    {
        var normalizedPrefix = string.IsNullOrWhiteSpace(prefix)
            ? string.Empty
            : prefix.Trim().Trim('-') + "-";
        return new ChatCompletionRequestOptionSet(
                        Model: new Option<string>($"--{normalizedPrefix}model")
                {
                    Description = @"The model to use, in provider/model-name format.
Example: openai/gpt-4.1-nano, anthropic/claude-sonnet-4-20250514
",
                    Required = true,
                },
                Temperature: new Option<float?>($"--{normalizedPrefix}temperature")
                {
                    Description = @"Sampling temperature between 0 and 2.",
                },
                MaxCompletionTokens: new Option<int?>($"--{normalizedPrefix}max-completion-tokens")
                {
                    Description = @"Maximum number of tokens to generate in the chat completion.",
                },
                MaxTokens: new Option<int?>($"--{normalizedPrefix}max-tokens")
                {
                    Description = @"Maximum number of tokens to generate (deprecated, use max_completion_tokens).",
                },
                Stream: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}stream", description: @"If true, partial message deltas will be sent as SSE events."),
                FrequencyPenalty: new Option<float?>($"--{normalizedPrefix}frequency-penalty")
                {
                    Description = @"Penalize new tokens based on their frequency in text so far. Between -2.0 and 2.0.",
                },
                PresencePenalty: new Option<float?>($"--{normalizedPrefix}presence-penalty")
                {
                    Description = @"Penalize new tokens based on whether they appear in text so far. Between -2.0 and 2.0.",
                },
                TopP: new Option<float?>($"--{normalizedPrefix}top-p")
                {
                    Description = @"Nucleus sampling parameter. Between 0 and 1.",
                },
                Seed: new Option<int?>($"--{normalizedPrefix}seed")
                {
                    Description = @"Seed for deterministic sampling.",
                },
                Logprobs: CliRuntime.CreateNullableBoolOption(name: $"--{normalizedPrefix}logprobs", description: @"Whether to return log probabilities of the output tokens."),
                TopLogprobs: new Option<int?>($"--{normalizedPrefix}top-logprobs")
                {
                    Description = @"Number of most likely tokens to return at each position.",
                },
                User: new Option<string?>($"--{normalizedPrefix}user")
                {
                    Description = @"A unique identifier representing the end-user.",
                },
                Models: new Option<global::System.Collections.Generic.IList<string>?>($"--{normalizedPrefix}models")
                {
                    Description = @"List of models the router can choose from. When specified, the router
will only route between these models. Uses provider/model-name format.
",
                },
                MaxCost: new Option<float?>($"--{normalizedPrefix}max-cost")
                {
                    Description = @"Maximum cost of the total request in USD. Allows you to specify
an upper bound on what you are willing to pay for the request.
",
                },
                MaxCostPerMillionTokens: new Option<float?>($"--{normalizedPrefix}max-cost-per-million-tokens")
                {
                    Description = @"Maximum cost per 1 million tokens in USD. Allows you to specify
a minimum efficiency for your models.
",
                },
                WillingnessToPay: new Option<float?>($"--{normalizedPrefix}willingness-to-pay")
                {
                    Description = @"Value of getting better output, measured in dollars. A value of 0.1
indicates that each 10% improvement in performance is worth 10 cents.
If not set, defaults to infinity (optimize only for performance).
",
                }
        );
    }
}