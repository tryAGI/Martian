#nullable enable

namespace Martian.JsonConverters
{
    /// <inheritdoc />
    public sealed class AnthropicContentBlockSourceTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Martian.AnthropicContentBlockSourceType?>
    {
        /// <inheritdoc />
        public override global::Martian.AnthropicContentBlockSourceType? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Martian.AnthropicContentBlockSourceTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Martian.AnthropicContentBlockSourceType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Martian.AnthropicContentBlockSourceType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Martian.AnthropicContentBlockSourceType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Martian.AnthropicContentBlockSourceTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
