
#nullable enable

namespace Martian
{
    /// <summary>
    /// The object type.
    /// </summary>
    public enum MessagesResponseType
    {
        /// <summary>
        /// 
        /// </summary>
        Message,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesResponseType value)
        {
            return value switch
            {
                MessagesResponseType.Message => "message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesResponseType? ToEnum(string value)
        {
            return value switch
            {
                "message" => MessagesResponseType.Message,
                _ => null,
            };
        }
    }
}