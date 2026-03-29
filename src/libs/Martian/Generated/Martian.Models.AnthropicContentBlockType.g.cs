
#nullable enable

namespace Martian
{
    /// <summary>
    /// The type of the content block.
    /// </summary>
    public enum AnthropicContentBlockType
    {
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        ToolResult,
        /// <summary>
        /// 
        /// </summary>
        ToolUse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicContentBlockTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicContentBlockType value)
        {
            return value switch
            {
                AnthropicContentBlockType.Image => "image",
                AnthropicContentBlockType.Text => "text",
                AnthropicContentBlockType.ToolResult => "tool_result",
                AnthropicContentBlockType.ToolUse => "tool_use",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicContentBlockType? ToEnum(string value)
        {
            return value switch
            {
                "image" => AnthropicContentBlockType.Image,
                "text" => AnthropicContentBlockType.Text,
                "tool_result" => AnthropicContentBlockType.ToolResult,
                "tool_use" => AnthropicContentBlockType.ToolUse,
                _ => null,
            };
        }
    }
}