
#nullable enable

namespace Martian
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCompletionRequestToolChoiceEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Required,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionRequestToolChoiceEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionRequestToolChoiceEnum value)
        {
            return value switch
            {
                ChatCompletionRequestToolChoiceEnum.Auto => "auto",
                ChatCompletionRequestToolChoiceEnum.None => "none",
                ChatCompletionRequestToolChoiceEnum.Required => "required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionRequestToolChoiceEnum? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ChatCompletionRequestToolChoiceEnum.Auto,
                "none" => ChatCompletionRequestToolChoiceEnum.None,
                "required" => ChatCompletionRequestToolChoiceEnum.Required,
                _ => null,
            };
        }
    }
}