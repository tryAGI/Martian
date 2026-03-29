
#nullable enable

namespace Martian
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListModelsResponse
    {
        /// <summary>
        /// The object type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Martian.JsonConverters.ListModelsResponseObjectJsonConverter))]
        public global::Martian.ListModelsResponseObject? Object { get; set; }

        /// <summary>
        /// A list of available models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::Martian.ModelInfo>? Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListModelsResponse" /> class.
        /// </summary>
        /// <param name="object">
        /// The object type.
        /// </param>
        /// <param name="data">
        /// A list of available models.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListModelsResponse(
            global::Martian.ListModelsResponseObject? @object,
            global::System.Collections.Generic.IList<global::Martian.ModelInfo>? data)
        {
            this.Object = @object;
            this.Data = data;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListModelsResponse" /> class.
        /// </summary>
        public ListModelsResponse()
        {
        }
    }
}