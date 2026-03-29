
#nullable enable

namespace Martian
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionRequest
    {
        /// <summary>
        /// The model to use, in provider/model-name format.<br/>
        /// Example: openai/gpt-4.1-nano, anthropic/claude-sonnet-4-20250514
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// A list of messages comprising the conversation so far.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Martian.ChatCompletionMessage> Messages { get; set; }

        /// <summary>
        /// Sampling temperature between 0 and 2.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public float? Temperature { get; set; }

        /// <summary>
        /// Maximum number of tokens to generate in the chat completion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_completion_tokens")]
        public int? MaxCompletionTokens { get; set; }

        /// <summary>
        /// Maximum number of tokens to generate (deprecated, use max_completion_tokens).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// If true, partial message deltas will be sent as SSE events.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// A list of tools the model may call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::Martian.Tool>? Tools { get; set; }

        /// <summary>
        /// Controls which (if any) tool is called by the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Martian.JsonConverters.OneOfJsonConverter<global::Martian.ChatCompletionRequestToolChoiceEnum?, global::Martian.ChatCompletionRequestToolChoiceEnum2>))]
        public global::Martian.OneOf<global::Martian.ChatCompletionRequestToolChoiceEnum?, global::Martian.ChatCompletionRequestToolChoiceEnum2>? ToolChoice { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_format")]
        public global::Martian.ResponseFormat? ResponseFormat { get; set; }

        /// <summary>
        /// Penalize new tokens based on their frequency in text so far. Between -2.0 and 2.0.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frequency_penalty")]
        public float? FrequencyPenalty { get; set; }

        /// <summary>
        /// Penalize new tokens based on whether they appear in text so far. Between -2.0 and 2.0.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presence_penalty")]
        public float? PresencePenalty { get; set; }

        /// <summary>
        /// Nucleus sampling parameter. Between 0 and 1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public float? TopP { get; set; }

        /// <summary>
        /// Seed for deterministic sampling.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Up to 4 sequences where the API will stop generating.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Martian.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>))]
        public global::Martian.OneOf<string, global::System.Collections.Generic.IList<string>>? Stop { get; set; }

        /// <summary>
        /// Whether to return log probabilities of the output tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logprobs")]
        public bool? Logprobs { get; set; }

        /// <summary>
        /// Number of most likely tokens to return at each position.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_logprobs")]
        public int? TopLogprobs { get; set; }

        /// <summary>
        /// A unique identifier representing the end-user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public string? User { get; set; }

        /// <summary>
        /// List of models the router can choose from. When specified, the router<br/>
        /// will only route between these models. Uses provider/model-name format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::System.Collections.Generic.IList<string>? Models { get; set; }

        /// <summary>
        /// Maximum cost of the total request in USD. Allows you to specify<br/>
        /// an upper bound on what you are willing to pay for the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_cost")]
        public float? MaxCost { get; set; }

        /// <summary>
        /// Maximum cost per 1 million tokens in USD. Allows you to specify<br/>
        /// a minimum efficiency for your models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_cost_per_million_tokens")]
        public float? MaxCostPerMillionTokens { get; set; }

        /// <summary>
        /// Value of getting better output, measured in dollars. A value of 0.1<br/>
        /// indicates that each 10% improvement in performance is worth 10 cents.<br/>
        /// If not set, defaults to infinity (optimize only for performance).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("willingness_to_pay")]
        public float? WillingnessToPay { get; set; }

        /// <summary>
        /// Arbitrary metadata to attach to the request for tracking.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extra")]
        public object? Extra { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequest" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionRequest(
            string model,
            global::System.Collections.Generic.IList<global::Martian.ChatCompletionMessage> messages,
            float? temperature,
            int? maxCompletionTokens,
            int? maxTokens,
            bool? stream,
            global::System.Collections.Generic.IList<global::Martian.Tool>? tools,
            global::Martian.OneOf<global::Martian.ChatCompletionRequestToolChoiceEnum?, global::Martian.ChatCompletionRequestToolChoiceEnum2>? toolChoice,
            global::Martian.ResponseFormat? responseFormat,
            float? frequencyPenalty,
            float? presencePenalty,
            float? topP,
            int? seed,
            global::Martian.OneOf<string, global::System.Collections.Generic.IList<string>>? stop,
            bool? logprobs,
            int? topLogprobs,
            string? user,
            global::System.Collections.Generic.IList<string>? models,
            float? maxCost,
            float? maxCostPerMillionTokens,
            float? willingnessToPay,
            object? extra)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.Temperature = temperature;
            this.MaxCompletionTokens = maxCompletionTokens;
            this.MaxTokens = maxTokens;
            this.Stream = stream;
            this.Tools = tools;
            this.ToolChoice = toolChoice;
            this.ResponseFormat = responseFormat;
            this.FrequencyPenalty = frequencyPenalty;
            this.PresencePenalty = presencePenalty;
            this.TopP = topP;
            this.Seed = seed;
            this.Stop = stop;
            this.Logprobs = logprobs;
            this.TopLogprobs = topLogprobs;
            this.User = user;
            this.Models = models;
            this.MaxCost = maxCost;
            this.MaxCostPerMillionTokens = maxCostPerMillionTokens;
            this.WillingnessToPay = willingnessToPay;
            this.Extra = extra;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequest" /> class.
        /// </summary>
        public ChatCompletionRequest()
        {
        }
    }
}