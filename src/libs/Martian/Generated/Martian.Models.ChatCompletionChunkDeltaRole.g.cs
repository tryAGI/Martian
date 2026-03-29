
#nullable enable

namespace Martian
{
    /// <summary>
    /// The role of the delta author.
    /// </summary>
    public enum ChatCompletionChunkDeltaRole
    {
        /// <summary>
        /// 
        /// </summary>
        Assistant,
        /// <summary>
        /// 
        /// </summary>
        System,
        /// <summary>
        /// 
        /// </summary>
        Tool,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionChunkDeltaRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionChunkDeltaRole value)
        {
            return value switch
            {
                ChatCompletionChunkDeltaRole.Assistant => "assistant",
                ChatCompletionChunkDeltaRole.System => "system",
                ChatCompletionChunkDeltaRole.Tool => "tool",
                ChatCompletionChunkDeltaRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionChunkDeltaRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => ChatCompletionChunkDeltaRole.Assistant,
                "system" => ChatCompletionChunkDeltaRole.System,
                "tool" => ChatCompletionChunkDeltaRole.Tool,
                "user" => ChatCompletionChunkDeltaRole.User,
                _ => null,
            };
        }
    }
}