#nullable enable

namespace Martian.JsonConverters
{
    /// <inheritdoc />
    public sealed class ChatCompletionRequestToolChoiceEnumNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Martian.ChatCompletionRequestToolChoiceEnum?>
    {
        /// <inheritdoc />
        public override global::Martian.ChatCompletionRequestToolChoiceEnum? Read(
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
                        return global::Martian.ChatCompletionRequestToolChoiceEnumExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Martian.ChatCompletionRequestToolChoiceEnum)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Martian.ChatCompletionRequestToolChoiceEnum?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Martian.ChatCompletionRequestToolChoiceEnum? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Martian.ChatCompletionRequestToolChoiceEnumExtensions.ToValueString(value.Value));
            }
        }
    }
}
