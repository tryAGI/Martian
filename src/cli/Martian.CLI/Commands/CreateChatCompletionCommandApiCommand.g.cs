#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Martian.CLI.Commands;

internal static partial class CreateChatCompletionCommandApiCommand
{
    private static Option<string> Model { get; } = new(
        name: @"--model")
    {
        Description = @"The model to use, in provider/model-name format.
Example: openai/gpt-4.1-nano, anthropic/claude-sonnet-4-20250514
",
        Required = true,
    };

    private static Option<global::System.Collections.Generic.IList<global::Martian.ChatCompletionMessage>> Messages { get; } = new(
        name: @"--messages")
    {
        Description = @"A list of messages comprising the conversation so far.",
        Required = true,
    };

    private static Option<float?> Temperature { get; } = new(
        name: @"--temperature")
    {
        Description = @"Sampling temperature between 0 and 2.",
    };

    private static Option<int?> MaxCompletionTokens { get; } = new(
        name: @"--max-completion-tokens")
    {
        Description = @"Maximum number of tokens to generate in the chat completion.",
    };

    private static Option<int?> MaxTokens { get; } = new(
        name: @"--max-tokens")
    {
        Description = @"Maximum number of tokens to generate (deprecated, use max_completion_tokens).",
    };

    private static Option<bool?> Stream { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--stream",
        description: @"If true, partial message deltas will be sent as SSE events.");

    private static Option<global::System.Collections.Generic.IList<global::Martian.Tool>?> Tools { get; } = new(
        name: @"--tools")
    {
        Description = @"A list of tools the model may call.",
    };

    private static Option<global::Martian.OneOf<global::Martian.ChatCompletionRequestToolChoiceEnum?, global::Martian.ChatCompletionRequestToolChoiceEnum2>?> ToolChoice { get; } = new(
        name: @"--tool-choice")
    {
        Description = @"Controls which (if any) tool is called by the model.",
    };

    private static Option<global::Martian.ResponseFormat?> ResponseFormat { get; } = new(
        name: @"--response-format")
    {
        Description = @"",
    };

    private static Option<float?> FrequencyPenalty { get; } = new(
        name: @"--frequency-penalty")
    {
        Description = @"Penalize new tokens based on their frequency in text so far. Between -2.0 and 2.0.",
    };

    private static Option<float?> PresencePenalty { get; } = new(
        name: @"--presence-penalty")
    {
        Description = @"Penalize new tokens based on whether they appear in text so far. Between -2.0 and 2.0.",
    };

    private static Option<float?> TopP { get; } = new(
        name: @"--top-p")
    {
        Description = @"Nucleus sampling parameter. Between 0 and 1.",
    };

    private static Option<int?> Seed { get; } = new(
        name: @"--seed")
    {
        Description = @"Seed for deterministic sampling.",
    };

    private static Option<global::Martian.OneOf<string, global::System.Collections.Generic.IList<string>>?> Stop { get; } = new(
        name: @"--stop")
    {
        Description = @"Up to 4 sequences where the API will stop generating.",
    };

    private static Option<bool?> Logprobs { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--logprobs",
        description: @"Whether to return log probabilities of the output tokens.");

    private static Option<int?> TopLogprobs { get; } = new(
        name: @"--top-logprobs")
    {
        Description = @"Number of most likely tokens to return at each position.",
    };

    private static Option<string?> User { get; } = new(
        name: @"--user")
    {
        Description = @"A unique identifier representing the end-user.",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> Models { get; } = new(
        name: @"--models")
    {
        Description = @"List of models the router can choose from. When specified, the router
will only route between these models. Uses provider/model-name format.
",
    };

    private static Option<float?> MaxCost { get; } = new(
        name: @"--max-cost")
    {
        Description = @"Maximum cost of the total request in USD. Allows you to specify
an upper bound on what you are willing to pay for the request.
",
    };

    private static Option<float?> MaxCostPerMillionTokens { get; } = new(
        name: @"--max-cost-per-million-tokens")
    {
        Description = @"Maximum cost per 1 million tokens in USD. Allows you to specify
a minimum efficiency for your models.
",
    };

    private static Option<float?> WillingnessToPay { get; } = new(
        name: @"--willingness-to-pay")
    {
        Description = @"Value of getting better output, measured in dollars. A value of 0.1
indicates that each 10% improvement in performance is worth 10 cents.
If not set, defaults to infinity (optimize only for performance).
",
    };

    private static Option<object?> Extra { get; } = new(
        name: @"--extra")
    {
        Description = @"Arbitrary metadata to attach to the request for tracking.",
    };
      private static Option<string?> Input { get; } = new(@"--input")
      {
          Description = "Load request JSON from a file path, '-' for stdin, or an inline JSON object/array string.",
      };

      private static Option<string?> RequestJson { get; } = new(@"--request-json")
      {
          Description = "Request body as JSON.",
          Hidden = true,
      };

      private static Option<string?> RequestFile { get; } = new(@"--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
          Hidden = true,
      };

                    private static string FormatResponse(ParseResult parseResult, global::Martian.ChatCompletionResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
                    {
                        string? text = null;
                        CustomizeResponseText(parseResult, value, ref text);
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            return text;
                        }

                        var hints = new Dictionary<string, CliFormatHint>(StringComparer.OrdinalIgnoreCase)
                        {
                        };
                        CustomizeResponseFormatHints(hints);
                        return CliRuntime.FormatHumanReadable(value, context, truncateLongStrings, hints);
                    }

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Martian.ChatCompletionResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-chat-completion", @"Create a chat completion
Creates a chat completion using the specified model via the Martian Gateway.
Supports OpenAI-compatible parameters plus Martian-specific routing parameters
such as models, max_cost, max_cost_per_million_tokens, and willingness_to_pay.
The gateway intelligently routes to the best model based on cost, quality, and latency.
");
                        command.Options.Add(Model);
                        command.Options.Add(Messages);
                        command.Options.Add(Temperature);
                        command.Options.Add(MaxCompletionTokens);
                        command.Options.Add(MaxTokens);
                        command.Options.Add(Stream);
                        command.Options.Add(Tools);
                        command.Options.Add(ToolChoice);
                        command.Options.Add(ResponseFormat);
                        command.Options.Add(FrequencyPenalty);
                        command.Options.Add(PresencePenalty);
                        command.Options.Add(TopP);
                        command.Options.Add(Seed);
                        command.Options.Add(Stop);
                        command.Options.Add(Logprobs);
                        command.Options.Add(TopLogprobs);
                        command.Options.Add(User);
                        command.Options.Add(Models);
                        command.Options.Add(MaxCost);
                        command.Options.Add(MaxCostPerMillionTokens);
                        command.Options.Add(WillingnessToPay);
                        command.Options.Add(Extra);
          command.Options.Add(Input);
          command.Options.Add(RequestJson);
          command.Options.Add(RequestFile);
          command.Validators.Add(result =>
          {
              var hasInput = result.GetResult(Input) is not null;
              var hasRequestJson = result.GetResult(RequestJson) is not null;
              var hasRequestFile = result.GetResult(RequestFile) is not null;
              var specifiedCount = (hasInput ? 1 : 0) + (hasRequestJson ? 1 : 0) + (hasRequestFile ? 1 : 0);
              if (specifiedCount > 1)
              {
                  result.AddError(@"Specify at most one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Martian.ChatCompletionRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Martian.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var model = parseResult.GetRequiredValue(Model);
                        var messages = parseResult.GetRequiredValue(Messages);
                        var temperature = CliRuntime.WasSpecified(parseResult, Temperature) ? parseResult.GetValue(Temperature) : __requestBase is not null ? __requestBase.Temperature : default;
                        var maxCompletionTokens = CliRuntime.WasSpecified(parseResult, MaxCompletionTokens) ? parseResult.GetValue(MaxCompletionTokens) : __requestBase is not null ? __requestBase.MaxCompletionTokens : default;
                        var maxTokens = CliRuntime.WasSpecified(parseResult, MaxTokens) ? parseResult.GetValue(MaxTokens) : __requestBase is not null ? __requestBase.MaxTokens : default;
                        var stream = CliRuntime.WasSpecified(parseResult, Stream) ? parseResult.GetValue(Stream) : __requestBase is not null ? __requestBase.Stream : default;
                        var tools = CliRuntime.WasSpecified(parseResult, Tools) ? parseResult.GetValue(Tools) : __requestBase is not null ? __requestBase.Tools : default;
                        var toolChoice = CliRuntime.WasSpecified(parseResult, ToolChoice) ? parseResult.GetValue(ToolChoice) : __requestBase is not null ? __requestBase.ToolChoice : default;
                        var responseFormat = CliRuntime.WasSpecified(parseResult, ResponseFormat) ? parseResult.GetValue(ResponseFormat) : __requestBase is not null ? __requestBase.ResponseFormat : default;
                        var frequencyPenalty = CliRuntime.WasSpecified(parseResult, FrequencyPenalty) ? parseResult.GetValue(FrequencyPenalty) : __requestBase is not null ? __requestBase.FrequencyPenalty : default;
                        var presencePenalty = CliRuntime.WasSpecified(parseResult, PresencePenalty) ? parseResult.GetValue(PresencePenalty) : __requestBase is not null ? __requestBase.PresencePenalty : default;
                        var topP = CliRuntime.WasSpecified(parseResult, TopP) ? parseResult.GetValue(TopP) : __requestBase is not null ? __requestBase.TopP : default;
                        var seed = CliRuntime.WasSpecified(parseResult, Seed) ? parseResult.GetValue(Seed) : __requestBase is not null ? __requestBase.Seed : default;
                        var stop = CliRuntime.WasSpecified(parseResult, Stop) ? parseResult.GetValue(Stop) : __requestBase is not null ? __requestBase.Stop : default;
                        var logprobs = CliRuntime.WasSpecified(parseResult, Logprobs) ? parseResult.GetValue(Logprobs) : __requestBase is not null ? __requestBase.Logprobs : default;
                        var topLogprobs = CliRuntime.WasSpecified(parseResult, TopLogprobs) ? parseResult.GetValue(TopLogprobs) : __requestBase is not null ? __requestBase.TopLogprobs : default;
                        var user = CliRuntime.WasSpecified(parseResult, User) ? parseResult.GetValue(User) : __requestBase is not null ? __requestBase.User : default;
                        var models = CliRuntime.WasSpecified(parseResult, Models) ? parseResult.GetValue(Models) : __requestBase is not null ? __requestBase.Models : default;
                        var maxCost = CliRuntime.WasSpecified(parseResult, MaxCost) ? parseResult.GetValue(MaxCost) : __requestBase is not null ? __requestBase.MaxCost : default;
                        var maxCostPerMillionTokens = CliRuntime.WasSpecified(parseResult, MaxCostPerMillionTokens) ? parseResult.GetValue(MaxCostPerMillionTokens) : __requestBase is not null ? __requestBase.MaxCostPerMillionTokens : default;
                        var willingnessToPay = CliRuntime.WasSpecified(parseResult, WillingnessToPay) ? parseResult.GetValue(WillingnessToPay) : __requestBase is not null ? __requestBase.WillingnessToPay : default;
                        var extra = CliRuntime.WasSpecified(parseResult, Extra) ? parseResult.GetValue(Extra) : __requestBase is not null ? __requestBase.Extra : default;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.CreateChatCompletionAsync(
                                    model: model,
                                    messages: messages,
                                    temperature: temperature,
                                    maxCompletionTokens: maxCompletionTokens,
                                    maxTokens: maxTokens,
                                    stream: stream,
                                    tools: tools,
                                    toolChoice: toolChoice,
                                    responseFormat: responseFormat,
                                    frequencyPenalty: frequencyPenalty,
                                    presencePenalty: presencePenalty,
                                    topP: topP,
                                    seed: seed,
                                    stop: stop,
                                    logprobs: logprobs,
                                    topLogprobs: topLogprobs,
                                    user: user,
                                    models: models,
                                    maxCost: maxCost,
                                    maxCostPerMillionTokens: maxCostPerMillionTokens,
                                    willingnessToPay: willingnessToPay,
                                    extra: extra,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::Martian.SourceGenerationContext.Default,
                                        @"Choices",
                                        cancellationToken).ConfigureAwait(false))
                                {
                                await CliRuntime.WriteResponseAsync(
                                    parseResult,
                                    response,
                                    global::Martian.SourceGenerationContext.Default,
                                    FormatResponse,
                                    cancellationToken).ConfigureAwait(false);
                                }
            }, cancellationToken).ConfigureAwait(false));
        return command;
    }
}