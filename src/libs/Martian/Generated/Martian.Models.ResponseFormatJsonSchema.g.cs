
#nullable enable

namespace Martian
{
    /// <summary>
    /// JSON Schema specification for structured output.
    /// </summary>
    public sealed partial class ResponseFormatJsonSchema
    {
        /// <summary>
        /// The name of the schema.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The JSON Schema object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        public object? Schema { get; set; }

        /// <summary>
        /// Whether to enable strict schema adherence.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strict")]
        public bool? Strict { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFormatJsonSchema" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the schema.
        /// </param>
        /// <param name="schema">
        /// The JSON Schema object.
        /// </param>
        /// <param name="strict">
        /// Whether to enable strict schema adherence.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseFormatJsonSchema(
            string? name,
            object? schema,
            bool? strict)
        {
            this.Name = name;
            this.Schema = schema;
            this.Strict = strict;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFormatJsonSchema" /> class.
        /// </summary>
        public ResponseFormatJsonSchema()
        {
        }
    }
}