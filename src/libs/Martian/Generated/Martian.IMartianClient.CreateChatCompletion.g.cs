#nullable enable

namespace Martian
{
    public partial interface IMartianClient
    {
        /// <summary>
        /// Create a chat completion<br/>
        /// Creates a chat completion using the specified model via the Martian Gateway.<br/>
        /// Supports OpenAI-compatible parameters plus Martian-specific routing parameters<br/>
        /// such as models, max_cost, max_cost_per_million_tokens, and willingness_to_pay.<br/>
        /// The gateway intelligently routes to the best model based on cost, quality, and latency.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Martian.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Martian.ChatCompletionResponse> CreateChatCompletionAsync(

            global::Martian.ChatCompletionRequest request,
            global::Martian.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a chat completion<br/>
        /// Creates a chat completion using the specified model via the Martian Gateway.<br/>
        /// Supports OpenAI-compatible parameters plus Martian-specific routing parameters<br/>
        /// such as models, max_cost, max_cost_per_million_tokens, and willingness_to_pay.<br/>
        /// The gateway intelligently routes to the best model based on cost, quality, and latency.
        /// </summary>
        /// <param name="model">
        /// The model to use, in provider/model-name format.<br/>
        /// Example: openai/gpt-4.1-nano, anthropic/claude-sonnet-4-20250514
        /// </param>
        /// <param name="messages">
        /// A list of messages comprising the conversation so far.
        /// </param>
        /// <param name="temperature">
        /// Sampling temperature between 0 and 2.
        /// </param>
        /// <param name="maxCompletionTokens">
        /// Maximum number of tokens to generate in the chat completion.
        /// </param>
        /// <param name="maxTokens">
        /// Maximum number of tokens to generate (deprecated, use max_completion_tokens).
        /// </param>
        /// <param name="stream">
        /// If true, partial message deltas will be sent as SSE events.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="tools">
        /// A list of tools the model may call.
        /// </param>
        /// <param name="toolChoice">
        /// Controls which (if any) tool is called by the model.
        /// </param>
        /// <param name="responseFormat"></param>
        /// <param name="frequencyPenalty">
        /// Penalize new tokens based on their frequency in text so far. Between -2.0 and 2.0.
        /// </param>
        /// <param name="presencePenalty">
        /// Penalize new tokens based on whether they appear in text so far. Between -2.0 and 2.0.
        /// </param>
        /// <param name="topP">
        /// Nucleus sampling parameter. Between 0 and 1.
        /// </param>
        /// <param name="seed">
        /// Seed for deterministic sampling.
        /// </param>
        /// <param name="stop">
        /// Up to 4 sequences where the API will stop generating.
        /// </param>
        /// <param name="logprobs">
        /// Whether to return log probabilities of the output tokens.
        /// </param>
        /// <param name="topLogprobs">
        /// Number of most likely tokens to return at each position.
        /// </param>
        /// <param name="user">
        /// A unique identifier representing the end-user.
        /// </param>
        /// <param name="models">
        /// List of models the router can choose from. When specified, the router<br/>
        /// will only route between these models. Uses provider/model-name format.
        /// </param>
        /// <param name="maxCost">
        /// Maximum cost of the total request in USD. Allows you to specify<br/>
        /// an upper bound on what you are willing to pay for the request.
        /// </param>
        /// <param name="maxCostPerMillionTokens">
        /// Maximum cost per 1 million tokens in USD. Allows you to specify<br/>
        /// a minimum efficiency for your models.
        /// </param>
        /// <param name="willingnessToPay">
        /// Value of getting better output, measured in dollars. A value of 0.1<br/>
        /// indicates that each 10% improvement in performance is worth 10 cents.<br/>
        /// If not set, defaults to infinity (optimize only for performance).
        /// </param>
        /// <param name="extra">
        /// Arbitrary metadata to attach to the request for tracking.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Martian.ChatCompletionResponse> CreateChatCompletionAsync(
            string model,
            global::System.Collections.Generic.IList<global::Martian.ChatCompletionMessage> messages,
            float? temperature = default,
            int? maxCompletionTokens = default,
            int? maxTokens = default,
            bool? stream = default,
            global::System.Collections.Generic.IList<global::Martian.Tool>? tools = default,
            global::Martian.OneOf<global::Martian.ChatCompletionRequestToolChoiceEnum?, global::Martian.ChatCompletionRequestToolChoiceEnum2>? toolChoice = default,
            global::Martian.ResponseFormat? responseFormat = default,
            float? frequencyPenalty = default,
            float? presencePenalty = default,
            float? topP = default,
            int? seed = default,
            global::Martian.OneOf<string, global::System.Collections.Generic.IList<string>>? stop = default,
            bool? logprobs = default,
            int? topLogprobs = default,
            string? user = default,
            global::System.Collections.Generic.IList<string>? models = default,
            float? maxCost = default,
            float? maxCostPerMillionTokens = default,
            float? willingnessToPay = default,
            object? extra = default,
            global::Martian.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}