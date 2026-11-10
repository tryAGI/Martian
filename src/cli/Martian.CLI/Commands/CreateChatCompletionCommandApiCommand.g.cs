#nullable enable
#pragma warning disable CS0618

using System.CommandLine;

namespace Martian.CLI.Commands;

internal static partial class CreateChatCompletionCommandApiCommand
{
    private static Option<global::System.Collections.Generic.IList<global::Martian.ChatCompletionMessage>> Messages { get; } = new(
        name: @"--messages")
    {
        Description = @"A list of messages comprising the conversation so far.",
        Required = true,
    };

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

    private static Option<global::Martian.OneOf<string, global::System.Collections.Generic.IList<string>>?> Stop { get; } = new(
        name: @"--stop")
    {
        Description = @"Up to 4 sequences where the API will stop generating.",
    };

    private static Option<object?> Extra { get; } = new(
        name: @"--extra")
    {
        Description = @"Arbitrary metadata to attach to the request for tracking.",
    };
    private static readonly ChatCompletionRequestOptionSet ChatCompletionRequestOptionSetOptions = ChatCompletionRequestOptionSet.Create();

    private static readonly ResponseFormatOptionSet ResponseFormatOptions = ResponseFormatOptionSet.Create(@"response-format");
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


    static partial void CustomizeCommand(ref Command command);

    public static Command Create(string? commandName = null)
    {
        var command = new Command(commandName ?? @"create-chat-completion", @"Create a chat completion
Creates a chat completion using the specified model via the Martian Gateway.
Supports OpenAI-compatible parameters plus Martian-specific routing parameters
such as models, max_cost, max_cost_per_million_tokens, and willingness_to_pay.
The gateway intelligently routes to the best model based on cost, quality, and latency.
");
                        command.Options.Add(Messages);
                        command.Options.Add(Tools);
                        command.Options.Add(ToolChoice);
                        command.Options.Add(Stop);
                        command.Options.Add(Extra);                        command.Options.Add(ChatCompletionRequestOptionSetOptions.Model);
                        command.Options.Add(ChatCompletionRequestOptionSetOptions.Temperature);
                        command.Options.Add(ChatCompletionRequestOptionSetOptions.MaxCompletionTokens);
                        command.Options.Add(ChatCompletionRequestOptionSetOptions.MaxTokens);
                        command.Options.Add(ChatCompletionRequestOptionSetOptions.FrequencyPenalty);
                        command.Options.Add(ChatCompletionRequestOptionSetOptions.PresencePenalty);
                        command.Options.Add(ChatCompletionRequestOptionSetOptions.TopP);
                        command.Options.Add(ChatCompletionRequestOptionSetOptions.Seed);
                        command.Options.Add(ChatCompletionRequestOptionSetOptions.Logprobs);
                        command.Options.Add(ChatCompletionRequestOptionSetOptions.TopLogprobs);
                        command.Options.Add(ChatCompletionRequestOptionSetOptions.User);
                        command.Options.Add(ChatCompletionRequestOptionSetOptions.Models);
                        command.Options.Add(ChatCompletionRequestOptionSetOptions.MaxCost);
                        command.Options.Add(ChatCompletionRequestOptionSetOptions.MaxCostPerMillionTokens);
                        command.Options.Add(ChatCompletionRequestOptionSetOptions.WillingnessToPay);                        command.Options.Add(ResponseFormatOptions.Type);
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
                        var messages = parseResult.GetRequiredValue(Messages);
                        var tools = CliRuntime.WasSpecified(parseResult, Tools) ? parseResult.GetValue(Tools) : (__requestBase is { } __ToolsBaseValue ? __ToolsBaseValue.Tools : default);
                        var toolChoice = CliRuntime.WasSpecified(parseResult, ToolChoice) ? parseResult.GetValue(ToolChoice) : (__requestBase is { } __ToolChoiceBaseValue ? __ToolChoiceBaseValue.ToolChoice : default);
                        var stop = CliRuntime.WasSpecified(parseResult, Stop) ? parseResult.GetValue(Stop) : (__requestBase is { } __StopBaseValue ? __StopBaseValue.Stop : default);
                        var extra = CliRuntime.WasSpecified(parseResult, Extra) ? parseResult.GetValue(Extra) : (__requestBase is { } __ExtraBaseValue ? __ExtraBaseValue.Extra : default);                        var model = parseResult.GetRequiredValue(ChatCompletionRequestOptionSetOptions.Model);
                        var temperature = CliRuntime.WasSpecified(parseResult, ChatCompletionRequestOptionSetOptions.Temperature) ? parseResult.GetValue(ChatCompletionRequestOptionSetOptions.Temperature) : (__requestBase is { } __TemperatureBaseValue ? __TemperatureBaseValue.Temperature : default);
                        var maxCompletionTokens = CliRuntime.WasSpecified(parseResult, ChatCompletionRequestOptionSetOptions.MaxCompletionTokens) ? parseResult.GetValue(ChatCompletionRequestOptionSetOptions.MaxCompletionTokens) : (__requestBase is { } __MaxCompletionTokensBaseValue ? __MaxCompletionTokensBaseValue.MaxCompletionTokens : default);
                        var maxTokens = CliRuntime.WasSpecified(parseResult, ChatCompletionRequestOptionSetOptions.MaxTokens) ? parseResult.GetValue(ChatCompletionRequestOptionSetOptions.MaxTokens) : (__requestBase is { } __MaxTokensBaseValue ? __MaxTokensBaseValue.MaxTokens : default);
                        var frequencyPenalty = CliRuntime.WasSpecified(parseResult, ChatCompletionRequestOptionSetOptions.FrequencyPenalty) ? parseResult.GetValue(ChatCompletionRequestOptionSetOptions.FrequencyPenalty) : (__requestBase is { } __FrequencyPenaltyBaseValue ? __FrequencyPenaltyBaseValue.FrequencyPenalty : default);
                        var presencePenalty = CliRuntime.WasSpecified(parseResult, ChatCompletionRequestOptionSetOptions.PresencePenalty) ? parseResult.GetValue(ChatCompletionRequestOptionSetOptions.PresencePenalty) : (__requestBase is { } __PresencePenaltyBaseValue ? __PresencePenaltyBaseValue.PresencePenalty : default);
                        var topP = CliRuntime.WasSpecified(parseResult, ChatCompletionRequestOptionSetOptions.TopP) ? parseResult.GetValue(ChatCompletionRequestOptionSetOptions.TopP) : (__requestBase is { } __TopPBaseValue ? __TopPBaseValue.TopP : default);
                        var seed = CliRuntime.WasSpecified(parseResult, ChatCompletionRequestOptionSetOptions.Seed) ? parseResult.GetValue(ChatCompletionRequestOptionSetOptions.Seed) : (__requestBase is { } __SeedBaseValue ? __SeedBaseValue.Seed : default);
                        var logprobs = CliRuntime.WasSpecified(parseResult, ChatCompletionRequestOptionSetOptions.Logprobs) ? parseResult.GetValue(ChatCompletionRequestOptionSetOptions.Logprobs) : (__requestBase is { } __LogprobsBaseValue ? __LogprobsBaseValue.Logprobs : default);
                        var topLogprobs = CliRuntime.WasSpecified(parseResult, ChatCompletionRequestOptionSetOptions.TopLogprobs) ? parseResult.GetValue(ChatCompletionRequestOptionSetOptions.TopLogprobs) : (__requestBase is { } __TopLogprobsBaseValue ? __TopLogprobsBaseValue.TopLogprobs : default);
                        var user = CliRuntime.WasSpecified(parseResult, ChatCompletionRequestOptionSetOptions.User) ? parseResult.GetValue(ChatCompletionRequestOptionSetOptions.User) : (__requestBase is { } __UserBaseValue ? __UserBaseValue.User : default);
                        var models = CliRuntime.WasSpecified(parseResult, ChatCompletionRequestOptionSetOptions.Models) ? parseResult.GetValue(ChatCompletionRequestOptionSetOptions.Models) : (__requestBase is { } __ModelsBaseValue ? __ModelsBaseValue.Models : default);
                        var maxCost = CliRuntime.WasSpecified(parseResult, ChatCompletionRequestOptionSetOptions.MaxCost) ? parseResult.GetValue(ChatCompletionRequestOptionSetOptions.MaxCost) : (__requestBase is { } __MaxCostBaseValue ? __MaxCostBaseValue.MaxCost : default);
                        var maxCostPerMillionTokens = CliRuntime.WasSpecified(parseResult, ChatCompletionRequestOptionSetOptions.MaxCostPerMillionTokens) ? parseResult.GetValue(ChatCompletionRequestOptionSetOptions.MaxCostPerMillionTokens) : (__requestBase is { } __MaxCostPerMillionTokensBaseValue ? __MaxCostPerMillionTokensBaseValue.MaxCostPerMillionTokens : default);
                        var willingnessToPay = CliRuntime.WasSpecified(parseResult, ChatCompletionRequestOptionSetOptions.WillingnessToPay) ? parseResult.GetValue(ChatCompletionRequestOptionSetOptions.WillingnessToPay) : (__requestBase is { } __WillingnessToPayBaseValue ? __WillingnessToPayBaseValue.WillingnessToPay : default);

                        var __ResponseFormatBase = __requestBase is { } __ResponseFormatBaseValue ? __ResponseFormatBaseValue.ResponseFormat : default;                        var responseFormatType = CliRuntime.WasSpecified(parseResult, ResponseFormatOptions.Type) ? parseResult.GetValue(ResponseFormatOptions.Type) : (__ResponseFormatBase is { } __ResponseFormattypeBaseValue ? __ResponseFormattypeBaseValue.Type : default);
                        var __ResponseFormatSpecified = CliRuntime.WasSpecified(parseResult, ResponseFormatOptions.Type);
                        var responseFormat =
                            __ResponseFormatSpecified || __ResponseFormatBase is not null
                                ? new global::Martian.ResponseFormat
                                {
	                                Type = responseFormatType,

                                }
                                : __ResponseFormatBase;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.CreateChatCompletionAsync(
                                    messages: messages,
                                    tools: tools,
                                    toolChoice: toolChoice,
                                    stop: stop,
                                    extra: extra,
                                    model: model,
                                    temperature: temperature,
                                    maxCompletionTokens: maxCompletionTokens,
                                    maxTokens: maxTokens,
                                    frequencyPenalty: frequencyPenalty,
                                    presencePenalty: presencePenalty,
                                    topP: topP,
                                    seed: seed,
                                    logprobs: logprobs,
                                    topLogprobs: topLogprobs,
                                    user: user,
                                    models: models,
                                    maxCost: maxCost,
                                    maxCostPerMillionTokens: maxCostPerMillionTokens,
                                    willingnessToPay: willingnessToPay,
                                    responseFormat: responseFormat,
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
        CustomizeCommand(ref command);
        return command;
    }
}