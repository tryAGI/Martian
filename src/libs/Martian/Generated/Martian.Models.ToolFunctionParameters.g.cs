
#nullable enable

namespace Martian
{
    /// <summary>
    /// The parameters the function accepts as a JSON Schema object.
    /// </summary>
    public sealed partial class ToolFunctionParameters
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}