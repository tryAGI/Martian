#nullable enable

using System.CommandLine;

namespace Martian.CLI.Commands;

internal static partial class CreateMessageCommandApiCommand
{
    private static Option<string> Model { get; } = new(
        name: @"--model")
    {
        Description = @"The model to use, in provider/model-name format.
Example: anthropic/claude-sonnet-4-20250514
",
        Required = true,
    };

    private static Option<global::System.Collections.Generic.IList<global::Martian.AnthropicMessage>> Messages { get; } = new(
        name: @"--messages")
    {
        Description = @"Input messages for the conversation.",
        Required = true,
    };

    private static Option<int> MaxTokens { get; } = new(
        name: @"--max-tokens")
    {
        Description = @"The maximum number of tokens to generate.",
        Required = true,
    };

    private static Option<string?> System { get; } = new(
        name: @"--system")
    {
        Description = @"System prompt for the conversation.",
    };

    private static Option<float?> Temperature { get; } = new(
        name: @"--temperature")
    {
        Description = @"Sampling temperature between 0 and 1.",
    };

    private static Option<float?> TopP { get; } = new(
        name: @"--top-p")
    {
        Description = @"Nucleus sampling parameter.",
    };

    private static Option<int?> TopK { get; } = new(
        name: @"--top-k")
    {
        Description = @"Top-K sampling parameter.",
    };

    private static Option<bool?> Stream { get; } = CliRuntime.CreateNullableBoolOption(
        name: @"--stream",
        description: @"Whether to stream the response.");

    private static Option<global::System.Collections.Generic.IList<global::Martian.AnthropicTool>?> Tools { get; } = new(
        name: @"--tools")
    {
        Description = @"Tools available for the model to use.",
    };

    private static Option<global::Martian.MessagesRequestToolChoice?> ToolChoice { get; } = new(
        name: @"--tool-choice")
    {
        Description = @"How the model should use the provided tools.",
    };

    private static Option<global::System.Collections.Generic.IList<string>?> StopSequences { get; } = new(
        name: @"--stop-sequences")
    {
        Description = @"Custom text sequences that will cause the model to stop generating.",
    };
      private static Option<string?> Input { get; } = new("--input")
      {
          Description = "Load request JSON from a file path, '-' for stdin, or an inline JSON object/array string.",
      };

      private static Option<string?> RequestJson { get; } = new("--request-json")
      {
          Description = "Request body as JSON.",
          Hidden = true,
      };

      private static Option<string?> RequestFile { get; } = new("--request-file")
      {
          Description = "Path to a JSON request file, or '-' for stdin.",
          Hidden = true,
      };

                    private static string FormatResponse(ParseResult parseResult, global::Martian.MessagesResponse value, global::System.Text.Json.Serialization.JsonSerializerContext context, bool truncateLongStrings)
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

                    static partial void CustomizeResponseText(ParseResult parseResult, global::Martian.MessagesResponse value, ref string? text);
                    static partial void CustomizeResponseFormatHints(Dictionary<string, CliFormatHint> hints);


    public static Command Create()
    {
        var command = new Command(@"create-message", @"Create a message (Anthropic-compatible)
Creates a message using the Anthropic Messages API format via the Martian Gateway.
Supports most Anthropic Messages API parameters. Use provider/model-name format
for the model field (e.g., anthropic/claude-sonnet-4-20250514).
");
                        command.Options.Add(Model);
                        command.Options.Add(Messages);
                        command.Options.Add(MaxTokens);
                        command.Options.Add(System);
                        command.Options.Add(Temperature);
                        command.Options.Add(TopP);
                        command.Options.Add(TopK);
                        command.Options.Add(Stream);
                        command.Options.Add(Tools);
                        command.Options.Add(ToolChoice);
                        command.Options.Add(StopSequences);
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
                  result.AddError("Specify at most one of --input, --request-json, or --request-file.");
              }
          });

        command.SetAction(async (ParseResult parseResult, CancellationToken cancellationToken) =>
            await CliRuntime.RunAsync(async () =>
            {
                        var __requestBase = await CliRuntime.ReadRequestOrDefaultAsync<global::Martian.MessagesRequest>(
                            parseResult,
                            Input,
                            RequestJson,
                            RequestFile,
                            global::Martian.SourceGenerationContext.Default,
                            cancellationToken).ConfigureAwait(false);
                        var model = parseResult.GetRequiredValue(Model);
                        var messages = parseResult.GetRequiredValue(Messages);
                        var maxTokens = parseResult.GetRequiredValue(MaxTokens);
                        var system = parseResult.GetValue(System) ?? __requestBase?.System;
                        var temperature = parseResult.GetValue(Temperature) ?? __requestBase?.Temperature;
                        var topP = parseResult.GetValue(TopP) ?? __requestBase?.TopP;
                        var topK = parseResult.GetValue(TopK) ?? __requestBase?.TopK;
                        var stream = parseResult.GetValue(Stream) ?? __requestBase?.Stream;
                        var tools = parseResult.GetValue(Tools) ?? __requestBase?.Tools;
                        var toolChoice = parseResult.GetValue(ToolChoice) ?? __requestBase?.ToolChoice;
                        var stopSequences = parseResult.GetValue(StopSequences) ?? __requestBase?.StopSequences;
                using var client = await CliRuntime.CreateClientAsync(parseResult, cancellationToken).ConfigureAwait(false);


                                var response = await client.CreateMessageAsync(
                                    model: model,
                                    messages: messages,
                                    maxTokens: maxTokens,
                                    system: system,
                                    temperature: temperature,
                                    topP: topP,
                                    topK: topK,
                                    stream: stream,
                                    tools: tools,
                                    toolChoice: toolChoice,
                                    stopSequences: stopSequences,
                                    cancellationToken: cancellationToken).ConfigureAwait(false);


                                if (!await CliRuntime.TryWriteOutputDirectoryAsync(
                                        parseResult,
                                        response,
                                        global::Martian.SourceGenerationContext.Default,
                                        @"Content",
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