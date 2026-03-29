#nullable enable

namespace Martian.JsonConverters
{
    /// <inheritdoc />
    public sealed class ContentPartImageUrlDetailNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Martian.ContentPartImageUrlDetail?>
    {
        /// <inheritdoc />
        public override global::Martian.ContentPartImageUrlDetail? Read(
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
                        return global::Martian.ContentPartImageUrlDetailExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Martian.ContentPartImageUrlDetail)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Martian.ContentPartImageUrlDetail?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Martian.ContentPartImageUrlDetail? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Martian.ContentPartImageUrlDetailExtensions.ToValueString(value.Value));
            }
        }
    }
}
