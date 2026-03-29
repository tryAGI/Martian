
#nullable enable

namespace Martian
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseFormat
    {
        /// <summary>
        /// The type of response format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Martian.JsonConverters.ResponseFormatTypeJsonConverter))]
        public global::Martian.ResponseFormatType? Type { get; set; }

        /// <summary>
        /// JSON Schema specification for structured output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("json_schema")]
        public global::Martian.ResponseFormatJsonSchema? JsonSchema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFormat" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of response format.
        /// </param>
        /// <param name="jsonSchema">
        /// JSON Schema specification for structured output.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseFormat(
            global::Martian.ResponseFormatType? type,
            global::Martian.ResponseFormatJsonSchema? jsonSchema)
        {
            this.Type = type;
            this.JsonSchema = jsonSchema;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFormat" /> class.
        /// </summary>
        public ResponseFormat()
        {
        }
    }
}