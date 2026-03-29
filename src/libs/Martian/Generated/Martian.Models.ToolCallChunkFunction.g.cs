
#nullable enable

namespace Martian
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolCallChunkFunction
    {
        /// <summary>
        /// The name of the function.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Fragment of JSON-encoded arguments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public string? Arguments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallChunkFunction" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the function.
        /// </param>
        /// <param name="arguments">
        /// Fragment of JSON-encoded arguments.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolCallChunkFunction(
            string? name,
            string? arguments)
        {
            this.Name = name;
            this.Arguments = arguments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolCallChunkFunction" /> class.
        /// </summary>
        public ToolCallChunkFunction()
        {
        }
    }
}