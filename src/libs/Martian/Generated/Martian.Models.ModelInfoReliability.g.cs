
#nullable enable

namespace Martian
{
    /// <summary>
    /// Reliability tier of the model.
    /// </summary>
    public enum ModelInfoReliability
    {
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelInfoReliabilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelInfoReliability value)
        {
            return value switch
            {
                ModelInfoReliability.High => "high",
                ModelInfoReliability.Low => "low",
                ModelInfoReliability.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelInfoReliability? ToEnum(string value)
        {
            return value switch
            {
                "high" => ModelInfoReliability.High,
                "low" => ModelInfoReliability.Low,
                "medium" => ModelInfoReliability.Medium,
                _ => null,
            };
        }
    }
}