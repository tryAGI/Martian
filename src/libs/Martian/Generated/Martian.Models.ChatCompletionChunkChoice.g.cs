
#nullable enable

namespace Martian
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionChunkChoice
    {
        /// <summary>
        /// The index of the choice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        public int? Index { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        public global::Martian.ChatCompletionChunkDelta? Delta { get; set; }

        /// <summary>
        /// The reason the model stopped generating.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finish_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Martian.JsonConverters.ChatCompletionChunkChoiceFinishReasonJsonConverter))]
        public global::Martian.ChatCompletionChunkChoiceFinishReason? FinishReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionChunkChoice" /> class.
        /// </summary>
        /// <param name="index">
        /// The index of the choice.
        /// </param>
        /// <param name="delta"></param>
        /// <param name="finishReason">
        /// The reason the model stopped generating.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionChunkChoice(
            int? index,
            global::Martian.ChatCompletionChunkDelta? delta,
            global::Martian.ChatCompletionChunkChoiceFinishReason? finishReason)
        {
            this.Index = index;
            this.Delta = delta;
            this.FinishReason = finishReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionChunkChoice" /> class.
        /// </summary>
        public ChatCompletionChunkChoice()
        {
        }
    }
}