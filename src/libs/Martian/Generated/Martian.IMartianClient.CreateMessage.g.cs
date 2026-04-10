#nullable enable

namespace Martian
{
    public partial interface IMartianClient
    {
        /// <summary>
        /// Create a message (Anthropic-compatible)<br/>
        /// Creates a message using the Anthropic Messages API format via the Martian Gateway.<br/>
        /// Supports most Anthropic Messages API parameters. Use provider/model-name format<br/>
        /// for the model field (e.g., anthropic/claude-sonnet-4-20250514).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Martian.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Martian.MessagesResponse> CreateMessageAsync(

            global::Martian.MessagesRequest request,
            global::Martian.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a message (Anthropic-compatible)<br/>
        /// Creates a message using the Anthropic Messages API format via the Martian Gateway.<br/>
        /// Supports most Anthropic Messages API parameters. Use provider/model-name format<br/>
        /// for the model field (e.g., anthropic/claude-sonnet-4-20250514).
        /// </summary>
        /// <param name="model">
        /// The model to use, in provider/model-name format.<br/>
        /// Example: anthropic/claude-sonnet-4-20250514
        /// </param>
        /// <param name="messages">
        /// Input messages for the conversation.
        /// </param>
        /// <param name="maxTokens">
        /// The maximum number of tokens to generate.
        /// </param>
        /// <param name="system">
        /// System prompt for the conversation.
        /// </param>
        /// <param name="temperature">
        /// Sampling temperature between 0 and 1.
        /// </param>
        /// <param name="topP">
        /// Nucleus sampling parameter.
        /// </param>
        /// <param name="topK">
        /// Top-K sampling parameter.
        /// </param>
        /// <param name="stream">
        /// Whether to stream the response.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="tools">
        /// Tools available for the model to use.
        /// </param>
        /// <param name="toolChoice">
        /// How the model should use the provided tools.
        /// </param>
        /// <param name="stopSequences">
        /// Custom text sequences that will cause the model to stop generating.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Martian.MessagesResponse> CreateMessageAsync(
            string model,
            global::System.Collections.Generic.IList<global::Martian.AnthropicMessage> messages,
            int maxTokens,
            string? system = default,
            float? temperature = default,
            float? topP = default,
            int? topK = default,
            bool? stream = default,
            global::System.Collections.Generic.IList<global::Martian.AnthropicTool>? tools = default,
            global::Martian.MessagesRequestToolChoice? toolChoice = default,
            global::System.Collections.Generic.IList<string>? stopSequences = default,
            global::Martian.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}