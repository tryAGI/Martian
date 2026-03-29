
#nullable enable

namespace Martian
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AnthropicUsage
    {
        /// <summary>
        /// Number of input tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        public int? InputTokens { get; set; }

        /// <summary>
        /// Number of output tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        public int? OutputTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicUsage" /> class.
        /// </summary>
        /// <param name="inputTokens">
        /// Number of input tokens.
        /// </param>
        /// <param name="outputTokens">
        /// Number of output tokens.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnthropicUsage(
            int? inputTokens,
            int? outputTokens)
        {
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnthropicUsage" /> class.
        /// </summary>
        public AnthropicUsage()
        {
        }
    }
}