
#nullable enable

namespace Martian
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionRequestToolChoiceEnum2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Martian.JsonConverters.ChatCompletionRequestToolChoiceEnumTypeJsonConverter))]
        public global::Martian.ChatCompletionRequestToolChoiceEnumType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function")]
        public global::Martian.ChatCompletionRequestToolChoiceEnumFunction? Function { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestToolChoiceEnum2" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="function"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionRequestToolChoiceEnum2(
            global::Martian.ChatCompletionRequestToolChoiceEnumType? type,
            global::Martian.ChatCompletionRequestToolChoiceEnumFunction? function)
        {
            this.Type = type;
            this.Function = function;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestToolChoiceEnum2" /> class.
        /// </summary>
        public ChatCompletionRequestToolChoiceEnum2()
        {
        }
    }
}