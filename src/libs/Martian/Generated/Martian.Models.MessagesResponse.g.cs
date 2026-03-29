
#nullable enable

namespace Martian
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessagesResponse
    {
        /// <summary>
        /// A unique identifier for the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The object type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Martian.JsonConverters.MessagesResponseTypeJsonConverter))]
        public global::Martian.MessagesResponseType? Type { get; set; }

        /// <summary>
        /// The role of the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Martian.JsonConverters.MessagesResponseRoleJsonConverter))]
        public global::Martian.MessagesResponseRole? Role { get; set; }

        /// <summary>
        /// The content blocks in the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::System.Collections.Generic.IList<global::Martian.AnthropicResponseContentBlock>? Content { get; set; }

        /// <summary>
        /// The model used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The reason the model stopped generating.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Martian.JsonConverters.MessagesResponseStopReasonJsonConverter))]
        public global::Martian.MessagesResponseStopReason? StopReason { get; set; }

        /// <summary>
        /// The stop sequence that caused the model to stop.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop_sequence")]
        public string? StopSequence { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::Martian.AnthropicUsage? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// A unique identifier for the response.
        /// </param>
        /// <param name="type">
        /// The object type.
        /// </param>
        /// <param name="role">
        /// The role of the response.
        /// </param>
        /// <param name="content">
        /// The content blocks in the response.
        /// </param>
        /// <param name="model">
        /// The model used.
        /// </param>
        /// <param name="stopReason">
        /// The reason the model stopped generating.
        /// </param>
        /// <param name="stopSequence">
        /// The stop sequence that caused the model to stop.
        /// </param>
        /// <param name="usage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesResponse(
            string? id,
            global::Martian.MessagesResponseType? type,
            global::Martian.MessagesResponseRole? role,
            global::System.Collections.Generic.IList<global::Martian.AnthropicResponseContentBlock>? content,
            string? model,
            global::Martian.MessagesResponseStopReason? stopReason,
            string? stopSequence,
            global::Martian.AnthropicUsage? usage)
        {
            this.Id = id;
            this.Type = type;
            this.Role = role;
            this.Content = content;
            this.Model = model;
            this.StopReason = stopReason;
            this.StopSequence = stopSequence;
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesResponse" /> class.
        /// </summary>
        public MessagesResponse()
        {
        }
    }
}