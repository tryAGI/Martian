
#nullable enable

namespace Martian
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessagesRequestToolChoiceType
    {
        /// <summary>
        /// 
        /// </summary>
        Any,
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Tool,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesRequestToolChoiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesRequestToolChoiceType value)
        {
            return value switch
            {
                MessagesRequestToolChoiceType.Any => "any",
                MessagesRequestToolChoiceType.Auto => "auto",
                MessagesRequestToolChoiceType.Tool => "tool",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesRequestToolChoiceType? ToEnum(string value)
        {
            return value switch
            {
                "any" => MessagesRequestToolChoiceType.Any,
                "auto" => MessagesRequestToolChoiceType.Auto,
                "tool" => MessagesRequestToolChoiceType.Tool,
                _ => null,
            };
        }
    }
}