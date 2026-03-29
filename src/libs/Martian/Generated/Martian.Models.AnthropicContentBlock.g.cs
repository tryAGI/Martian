
#nullable enable

namespace Martian
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnthropicContentBlock
    {
        /// <summary>
        /// The type of the content block.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Martian.JsonConverters.AnthropicContentBlockTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Martian.AnthropicContentBlockType Type { get; set; }

        /// <summary>
        /// The text content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// The image source.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public global::Martian.AnthropicContentBlockSource? Source { get; set; }

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
        /// The tool use ID for tool results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_use_id")]
        public string? ToolUseId { get; set; }

        /// <summary>
        /// The tool result content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicContentBlock" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the content block.
        /// </param>
        /// <param name="text">
        /// The text content.
        /// </param>
        /// <param name="source">
        /// The image source.
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
        /// <param name="toolUseId">
        /// The tool use ID for tool results.
        /// </param>
        /// <param name="content">
        /// The tool result content.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicContentBlock(
            global::Martian.AnthropicContentBlockType type,
            string? text,
            global::Martian.AnthropicContentBlockSource? source,
            string? id,
            string? name,
            object? input,
            string? toolUseId,
            string? content)
        {
            this.Type = type;
            this.Text = text;
            this.Source = source;
            this.Id = id;
            this.Name = name;
            this.Input = input;
            this.ToolUseId = toolUseId;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicContentBlock" /> class.
        /// </summary>
        public AnthropicContentBlock()
        {
        }
    }
}