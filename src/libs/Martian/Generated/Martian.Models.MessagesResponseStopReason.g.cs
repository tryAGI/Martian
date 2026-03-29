
#nullable enable

namespace Martian
{
    /// <summary>
    /// The reason the model stopped generating.
    /// </summary>
    public enum MessagesResponseStopReason
    {
        /// <summary>
        /// 
        /// </summary>
        EndTurn,
        /// <summary>
        /// 
        /// </summary>
        MaxTokens,
        /// <summary>
        /// 
        /// </summary>
        StopSequence,
        /// <summary>
        /// 
        /// </summary>
        ToolUse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessagesResponseStopReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessagesResponseStopReason value)
        {
            return value switch
            {
                MessagesResponseStopReason.EndTurn => "end_turn",
                MessagesResponseStopReason.MaxTokens => "max_tokens",
                MessagesResponseStopReason.StopSequence => "stop_sequence",
                MessagesResponseStopReason.ToolUse => "tool_use",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessagesResponseStopReason? ToEnum(string value)
        {
            return value switch
            {
                "end_turn" => MessagesResponseStopReason.EndTurn,
                "max_tokens" => MessagesResponseStopReason.MaxTokens,
                "stop_sequence" => MessagesResponseStopReason.StopSequence,
                "tool_use" => MessagesResponseStopReason.ToolUse,
                _ => null,
            };
        }
    }
}