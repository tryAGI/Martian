
#nullable enable

namespace Martian
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolFunction
    {
        /// <summary>
        /// The name of the function.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A description of the function.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The parameters the function accepts as a JSON Schema object.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public object? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolFunction" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the function.
        /// </param>
        /// <param name="description">
        /// A description of the function.
        /// </param>
        /// <param name="parameters">
        /// The parameters the function accepts as a JSON Schema object.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolFunction(
            string name,
            string? description,
            object? parameters)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Parameters = parameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolFunction" /> class.
        /// </summary>
        public ToolFunction()
        {
        }
    }
}