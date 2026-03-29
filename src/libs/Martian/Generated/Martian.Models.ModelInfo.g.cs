
#nullable enable

namespace Martian
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelInfo
    {
        /// <summary>
        /// The model identifier in provider/model-name format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The object type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Martian.JsonConverters.ModelInfoObjectJsonConverter))]
        public global::Martian.ModelInfoObject? Object { get; set; }

        /// <summary>
        /// Unix timestamp of when the model was added.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Martian.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? Created { get; set; }

        /// <summary>
        /// The provider that owns the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owned_by")]
        public string? OwnedBy { get; set; }

        /// <summary>
        /// Cost per input token in USD (as a string).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_cost_per_token")]
        public string? InputCostPerToken { get; set; }

        /// <summary>
        /// Cost per output token in USD (as a string).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_cost_per_token")]
        public string? OutputCostPerToken { get; set; }

        /// <summary>
        /// Maximum number of completion tokens supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_completion_tokens")]
        public int? MaxCompletionTokens { get; set; }

        /// <summary>
        /// Reliability tier of the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reliability")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Martian.JsonConverters.ModelInfoReliabilityJsonConverter))]
        public global::Martian.ModelInfoReliability? Reliability { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelInfo" /> class.
        /// </summary>
        /// <param name="id">
        /// The model identifier in provider/model-name format.
        /// </param>
        /// <param name="object">
        /// The object type.
        /// </param>
        /// <param name="created">
        /// Unix timestamp of when the model was added.
        /// </param>
        /// <param name="ownedBy">
        /// The provider that owns the model.
        /// </param>
        /// <param name="inputCostPerToken">
        /// Cost per input token in USD (as a string).
        /// </param>
        /// <param name="outputCostPerToken">
        /// Cost per output token in USD (as a string).
        /// </param>
        /// <param name="maxCompletionTokens">
        /// Maximum number of completion tokens supported.
        /// </param>
        /// <param name="reliability">
        /// Reliability tier of the model.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelInfo(
            string? id,
            global::Martian.ModelInfoObject? @object,
            global::System.DateTimeOffset? created,
            string? ownedBy,
            string? inputCostPerToken,
            string? outputCostPerToken,
            int? maxCompletionTokens,
            global::Martian.ModelInfoReliability? reliability)
        {
            this.Id = id;
            this.Object = @object;
            this.Created = created;
            this.OwnedBy = ownedBy;
            this.InputCostPerToken = inputCostPerToken;
            this.OutputCostPerToken = outputCostPerToken;
            this.MaxCompletionTokens = maxCompletionTokens;
            this.Reliability = reliability;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelInfo" /> class.
        /// </summary>
        public ModelInfo()
        {
        }
    }
}