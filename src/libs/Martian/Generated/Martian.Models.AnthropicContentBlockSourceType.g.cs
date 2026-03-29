
#nullable enable

namespace Martian
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicContentBlockSourceType
    {
        /// <summary>
        /// 
        /// </summary>
        Base64,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicContentBlockSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicContentBlockSourceType value)
        {
            return value switch
            {
                AnthropicContentBlockSourceType.Base64 => "base64",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicContentBlockSourceType? ToEnum(string value)
        {
            return value switch
            {
                "base64" => AnthropicContentBlockSourceType.Base64,
                _ => null,
            };
        }
    }
}