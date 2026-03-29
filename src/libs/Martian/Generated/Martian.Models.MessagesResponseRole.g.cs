
#nullable enable

namespace Martian
{
    /// <summary>
    /// The role of the response.
    /// </summary>
    public enum MessagesResponseRole
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesResponseRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesResponseRole value)
        {
            return value switch
            {
                MessagesResponseRole.Assistant => "assistant",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesResponseRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => MessagesResponseRole.Assistant,
                _ => null,
            };
        }
    }
}