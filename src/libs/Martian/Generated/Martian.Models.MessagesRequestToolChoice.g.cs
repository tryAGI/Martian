
#nullable enable

namespace Martian
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessagesRequestToolChoice
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Martian.JsonConverters.MessagesRequestToolChoiceTypeJsonConverter))]
        public global::Martian.MessagesRequestToolChoiceType? Type { get; set; }

        /// <summary>
        /// The name of the tool (required when type is tool).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestToolChoice" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="name">
        /// The name of the tool (required when type is tool).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesRequestToolChoice(
            global::Martian.MessagesRequestToolChoiceType? type,
            string? name)
        {
            this.Type = type;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestToolChoice" /> class.
        /// </summary>
        public MessagesRequestToolChoice()
        {
        }
    }
}