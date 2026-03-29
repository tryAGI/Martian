
#nullable enable

namespace Martian
{
    /// <summary>
    /// The image URL content.
    /// </summary>
    public sealed partial class ContentPartImageUrl
    {
        /// <summary>
        /// The URL of the image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// The detail level of the image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Martian.JsonConverters.ContentPartImageUrlDetailJsonConverter))]
        public global::Martian.ContentPartImageUrlDetail? Detail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentPartImageUrl" /> class.
        /// </summary>
        /// <param name="url">
        /// The URL of the image.
        /// </param>
        /// <param name="detail">
        /// The detail level of the image.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContentPartImageUrl(
            string? url,
            global::Martian.ContentPartImageUrlDetail? detail)
        {
            this.Url = url;
            this.Detail = detail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentPartImageUrl" /> class.
        /// </summary>
        public ContentPartImageUrl()
        {
        }
    }
}