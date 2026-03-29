
#nullable enable

namespace Martian
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessagesRequest
    {
        /// <summary>
        /// The model to use, in provider/model-name format.<br/>
        /// Example: anthropic/claude-sonnet-4-20250514
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Input messages for the conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Martian.AnthropicMessage> Messages { get; set; }

        /// <summary>
        /// The maximum number of tokens to generate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxTokens { get; set; }

        /// <summary>
        /// System prompt for the conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system")]
        public string? System { get; set; }

        /// <summary>
        /// Sampling temperature between 0 and 1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("temperature")]
        public float? Temperature { get; set; }

        /// <summary>
        /// Nucleus sampling parameter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_p")]
        public float? TopP { get; set; }

        /// <summary>
        /// Top-K sampling parameter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_k")]
        public int? TopK { get; set; }

        /// <summary>
        /// Whether to stream the response.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Tools available for the model to use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::Martian.AnthropicTool>? Tools { get; set; }

        /// <summary>
        /// How the model should use the provided tools.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_choice")]
        public global::Martian.MessagesRequestToolChoice? ToolChoice { get; set; }

        /// <summary>
        /// Custom text sequences that will cause the model to stop generating.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop_sequences")]
        public global::System.Collections.Generic.IList<string>? StopSequences { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequest" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesRequest(
            string model,
            global::System.Collections.Generic.IList<global::Martian.AnthropicMessage> messages,
            int maxTokens,
            string? system,
            float? temperature,
            float? topP,
            int? topK,
            bool? stream,
            global::System.Collections.Generic.IList<global::Martian.AnthropicTool>? tools,
            global::Martian.MessagesRequestToolChoice? toolChoice,
            global::System.Collections.Generic.IList<string>? stopSequences)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.MaxTokens = maxTokens;
            this.System = system;
            this.Temperature = temperature;
            this.TopP = topP;
            this.TopK = topK;
            this.Stream = stream;
            this.Tools = tools;
            this.ToolChoice = toolChoice;
            this.StopSequences = stopSequences;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequest" /> class.
        /// </summary>
        public MessagesRequest()
        {
        }
    }
}