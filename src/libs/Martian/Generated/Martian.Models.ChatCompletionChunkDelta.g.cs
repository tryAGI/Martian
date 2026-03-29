
#nullable enable

namespace Martian
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionChunkDelta
    {
        /// <summary>
        /// The role of the delta author.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Martian.JsonConverters.ChatCompletionChunkDeltaRoleJsonConverter))]
        public global::Martian.ChatCompletionChunkDeltaRole? Role { get; set; }

        /// <summary>
        /// The content of the chunk delta.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Tool call chunks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_calls")]
        public global::System.Collections.Generic.IList<global::Martian.ToolCallChunk>? ToolCalls { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionChunkDelta" /> class.
        /// </summary>
        /// <param name="role">
        /// The role of the delta author.
        /// </param>
        /// <param name="content">
        /// The content of the chunk delta.
        /// </param>
        /// <param name="toolCalls">
        /// Tool call chunks.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionChunkDelta(
            global::Martian.ChatCompletionChunkDeltaRole? role,
            string? content,
            global::System.Collections.Generic.IList<global::Martian.ToolCallChunk>? toolCalls)
        {
            this.Role = role;
            this.Content = content;
            this.ToolCalls = toolCalls;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionChunkDelta" /> class.
        /// </summary>
        public ChatCompletionChunkDelta()
        {
        }
    }
}