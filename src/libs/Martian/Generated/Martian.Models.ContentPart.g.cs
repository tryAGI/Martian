
#nullable enable

namespace Martian
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContentPart
    {
        /// <summary>
        /// The type of the content part.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Martian.JsonConverters.ContentPartTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Martian.ContentPartType Type { get; set; }

        /// <summary>
        /// The text content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// The image URL content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public global::Martian.ContentPartImageUrl? ImageUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentPart" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the content part.
        /// </param>
        /// <param name="text">
        /// The text content.
        /// </param>
        /// <param name="imageUrl">
        /// The image URL content.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContentPart(
            global::Martian.ContentPartType type,
            string? text,
            global::Martian.ContentPartImageUrl? imageUrl)
        {
            this.Type = type;
            this.Text = text;
            this.ImageUrl = imageUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentPart" /> class.
        /// </summary>
        public ContentPart()
        {
        }
    }
}