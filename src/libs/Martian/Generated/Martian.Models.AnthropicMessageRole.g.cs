
#nullable enable

namespace Martian
{
    /// <summary>
    /// The role of the message author.
    /// </summary>
    public enum AnthropicMessageRole
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicMessageRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicMessageRole value)
        {
            return value switch
            {
                AnthropicMessageRole.Assistant => "assistant",
                AnthropicMessageRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicMessageRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => AnthropicMessageRole.Assistant,
                "user" => AnthropicMessageRole.User,
                _ => null,
            };
        }
    }
}