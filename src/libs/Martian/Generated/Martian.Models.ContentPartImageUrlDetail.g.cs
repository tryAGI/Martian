
#nullable enable

namespace Martian
{
    /// <summary>
    /// The detail level of the image.
    /// </summary>
    public enum ContentPartImageUrlDetail
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Low,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContentPartImageUrlDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentPartImageUrlDetail value)
        {
            return value switch
            {
                ContentPartImageUrlDetail.Auto => "auto",
                ContentPartImageUrlDetail.High => "high",
                ContentPartImageUrlDetail.Low => "low",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentPartImageUrlDetail? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ContentPartImageUrlDetail.Auto,
                "high" => ContentPartImageUrlDetail.High,
                "low" => ContentPartImageUrlDetail.Low,
                _ => null,
            };
        }
    }
}