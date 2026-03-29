
#nullable enable

namespace Martian
{
    /// <summary>
    /// The image source.
    /// </summary>
    public sealed partial class AnthropicContentBlockSource
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Martian.JsonConverters.AnthropicContentBlockSourceTypeJsonConverter))]
        public global::Martian.AnthropicContentBlockSourceType? Type { get; set; }

        /// <summary>
        /// The media type of the image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_type")]
        public string? MediaType { get; set; }

        /// <summary>
        /// The base64-encoded image data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public string? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicContentBlockSource" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="mediaType">
        /// The media type of the image.
        /// </param>
        /// <param name="data">
        /// The base64-encoded image data.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicContentBlockSource(
            global::Martian.AnthropicContentBlockSourceType? type,
            string? mediaType,
            string? data)
        {
            this.Type = type;
            this.MediaType = mediaType;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicContentBlockSource" /> class.
        /// </summary>
        public AnthropicContentBlockSource()
        {
        }
    }
}