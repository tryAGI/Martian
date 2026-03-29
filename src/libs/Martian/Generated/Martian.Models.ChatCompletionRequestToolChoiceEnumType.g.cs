
#nullable enable

namespace Martian
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCompletionRequestToolChoiceEnumType
    {
        /// <summary>
        /// 
        /// </summary>
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionRequestToolChoiceEnumTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionRequestToolChoiceEnumType value)
        {
            return value switch
            {
                ChatCompletionRequestToolChoiceEnumType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionRequestToolChoiceEnumType? ToEnum(string value)
        {
            return value switch
            {
                "function" => ChatCompletionRequestToolChoiceEnumType.Function,
                _ => null,
            };
        }
    }
}