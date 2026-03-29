
#nullable enable

namespace Martian
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionChunkResponse
    {
        /// <summary>
        /// A unique identifier for the chunk.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The object type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Martian.JsonConverters.ChatCompletionChunkResponseObjectJsonConverter))]
        public global::Martian.ChatCompletionChunkResponseObject? Object { get; set; }

        /// <summary>
        /// The Unix timestamp of when the chunk was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Martian.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? Created { get; set; }

        /// <summary>
        /// The model used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// A list of chunk choices.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("choices")]
        public global::System.Collections.Generic.IList<global::Martian.ChatCompletionChunkChoice>? Choices { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::Martian.CompletionUsage? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionChunkResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// A unique identifier for the chunk.
        /// </param>
        /// <param name="object">
        /// The object type.
        /// </param>
        /// <param name="created">
        /// The Unix timestamp of when the chunk was created.
        /// </param>
        /// <param name="model">
        /// The model used.
        /// </param>
        /// <param name="choices">
        /// A list of chunk choices.
        /// </param>
        /// <param name="usage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionChunkResponse(
            string? id,
            global::Martian.ChatCompletionChunkResponseObject? @object,
            global::System.DateTimeOffset? created,
            string? model,
            global::System.Collections.Generic.IList<global::Martian.ChatCompletionChunkChoice>? choices,
            global::Martian.CompletionUsage? usage)
        {
            this.Id = id;
            this.Object = @object;
            this.Created = created;
            this.Model = model;
            this.Choices = choices;
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionChunkResponse" /> class.
        /// </summary>
        public ChatCompletionChunkResponse()
        {
        }
    }
}