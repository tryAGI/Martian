
#nullable enable

namespace Martian
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnthropicResponseContentBlock
    {
        /// <summary>
        /// The type of content block.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Martian.JsonConverters.AnthropicResponseContentBlockTypeJsonConverter))]
        public global::Martian.AnthropicResponseContentBlockType? Type { get; set; }

        /// <summary>
        /// The text content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// The tool use ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The tool name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The tool input.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public object? Input { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicResponseContentBlock" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of content block.
        /// </param>
        /// <param name="text">
        /// The text content.
        /// </param>
        /// <param name="id">
        /// The tool use ID.
        /// </param>
        /// <param name="name">
        /// The tool name.
        /// </param>
        /// <param name="input">
        /// The tool input.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicResponseContentBlock(
            global::Martian.AnthropicResponseContentBlockType? type,
            string? text,
            string? id,
            string? name,
            object? input)
        {
            this.Type = type;
            this.Text = text;
            this.Id = id;
            this.Name = name;
            this.Input = input;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicResponseContentBlock" /> class.
        /// </summary>
        public AnthropicResponseContentBlock()
        {
        }
    }
}