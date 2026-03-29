
#nullable enable

namespace Martian
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnthropicMessage
    {
        /// <summary>
        /// The role of the message author.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Martian.JsonConverters.AnthropicMessageRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Martian.AnthropicMessageRole Role { get; set; }

        /// <summary>
        /// The content of the message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Martian.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Martian.AnthropicContentBlock>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Martian.OneOf<string, global::System.Collections.Generic.IList<global::Martian.AnthropicContentBlock>> Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicMessage" /> class.
        /// </summary>
        /// <param name="role">
        /// The role of the message author.
        /// </param>
        /// <param name="content">
        /// The content of the message.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicMessage(
            global::Martian.AnthropicMessageRole role,
            global::Martian.OneOf<string, global::System.Collections.Generic.IList<global::Martian.AnthropicContentBlock>> content)
        {
            this.Role = role;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicMessage" /> class.
        /// </summary>
        public AnthropicMessage()
        {
        }
    }
}