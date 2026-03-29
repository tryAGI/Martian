
#nullable enable

namespace Martian
{
    /// <summary>
    /// The type of content block.
    /// </summary>
    public enum AnthropicResponseContentBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        ToolUse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicResponseContentBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicResponseContentBlockType value)
        {
            return value switch
            {
                AnthropicResponseContentBlockType.Text => "text",
                AnthropicResponseContentBlockType.ToolUse => "tool_use",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicResponseContentBlockType? ToEnum(string value)
        {
            return value switch
            {
                "text" => AnthropicResponseContentBlockType.Text,
                "tool_use" => AnthropicResponseContentBlockType.ToolUse,
                _ => null,
            };
        }
    }
}