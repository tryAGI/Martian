
#nullable enable

namespace Martian
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionResponse
    {
        /// <summary>
        /// A unique identifier for the chat completion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The object type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Martian.JsonConverters.ChatCompletionResponseObjectJsonConverter))]
        public global::Martian.ChatCompletionResponseObject? Object { get; set; }

        /// <summary>
        /// The Unix timestamp of when the completion was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Martian.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? Created { get; set; }

        /// <summary>
        /// The model used for the completion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// A list of chat completion choices.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("choices")]
        public global::System.Collections.Generic.IList<global::Martian.ChatCompletionChoice>? Choices { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::Martian.CompletionUsage? Usage { get; set; }

        /// <summary>
        /// A fingerprint of the backend configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_fingerprint")]
        public string? SystemFingerprint { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// A unique identifier for the chat completion.
        /// </param>
        /// <param name="object">
        /// The object type.
        /// </param>
        /// <param name="created">
        /// The Unix timestamp of when the completion was created.
        /// </param>
        /// <param name="model">
        /// The model used for the completion.
        /// </param>
        /// <param name="choices">
        /// A list of chat completion choices.
        /// </param>
        /// <param name="usage"></param>
        /// <param name="systemFingerprint">
        /// A fingerprint of the backend configuration.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionResponse(
            string? id,
            global::Martian.ChatCompletionResponseObject? @object,
            global::System.DateTimeOffset? created,
            string? model,
            global::System.Collections.Generic.IList<global::Martian.ChatCompletionChoice>? choices,
            global::Martian.CompletionUsage? usage,
            string? systemFingerprint)
        {
            this.Id = id;
            this.Object = @object;
            this.Created = created;
            this.Model = model;
            this.Choices = choices;
            this.Usage = usage;
            this.SystemFingerprint = systemFingerprint;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionResponse" /> class.
        /// </summary>
        public ChatCompletionResponse()
        {
        }
    }
}