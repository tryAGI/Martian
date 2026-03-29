
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Martian
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Martian.JsonConverters.ChatCompletionMessageRoleJsonConverter),

            typeof(global::Martian.JsonConverters.ChatCompletionMessageRoleNullableJsonConverter),

            typeof(global::Martian.JsonConverters.ContentPartTypeJsonConverter),

            typeof(global::Martian.JsonConverters.ContentPartTypeNullableJsonConverter),

            typeof(global::Martian.JsonConverters.ContentPartImageUrlDetailJsonConverter),

            typeof(global::Martian.JsonConverters.ContentPartImageUrlDetailNullableJsonConverter),

            typeof(global::Martian.JsonConverters.ToolCallTypeJsonConverter),

            typeof(global::Martian.JsonConverters.ToolCallTypeNullableJsonConverter),

            typeof(global::Martian.JsonConverters.ToolTypeJsonConverter),

            typeof(global::Martian.JsonConverters.ToolTypeNullableJsonConverter),

            typeof(global::Martian.JsonConverters.ResponseFormatTypeJsonConverter),

            typeof(global::Martian.JsonConverters.ResponseFormatTypeNullableJsonConverter),

            typeof(global::Martian.JsonConverters.ChatCompletionRequestToolChoiceEnumJsonConverter),

            typeof(global::Martian.JsonConverters.ChatCompletionRequestToolChoiceEnumNullableJsonConverter),

            typeof(global::Martian.JsonConverters.ChatCompletionRequestToolChoiceEnumTypeJsonConverter),

            typeof(global::Martian.JsonConverters.ChatCompletionRequestToolChoiceEnumTypeNullableJsonConverter),

            typeof(global::Martian.JsonConverters.ChatCompletionChoiceFinishReasonJsonConverter),

            typeof(global::Martian.JsonConverters.ChatCompletionChoiceFinishReasonNullableJsonConverter),

            typeof(global::Martian.JsonConverters.ChatCompletionResponseObjectJsonConverter),

            typeof(global::Martian.JsonConverters.ChatCompletionResponseObjectNullableJsonConverter),

            typeof(global::Martian.JsonConverters.ChatCompletionChunkDeltaRoleJsonConverter),

            typeof(global::Martian.JsonConverters.ChatCompletionChunkDeltaRoleNullableJsonConverter),

            typeof(global::Martian.JsonConverters.ToolCallChunkTypeJsonConverter),

            typeof(global::Martian.JsonConverters.ToolCallChunkTypeNullableJsonConverter),

            typeof(global::Martian.JsonConverters.ChatCompletionChunkChoiceFinishReasonJsonConverter),

            typeof(global::Martian.JsonConverters.ChatCompletionChunkChoiceFinishReasonNullableJsonConverter),

            typeof(global::Martian.JsonConverters.ChatCompletionChunkResponseObjectJsonConverter),

            typeof(global::Martian.JsonConverters.ChatCompletionChunkResponseObjectNullableJsonConverter),

            typeof(global::Martian.JsonConverters.AnthropicMessageRoleJsonConverter),

            typeof(global::Martian.JsonConverters.AnthropicMessageRoleNullableJsonConverter),

            typeof(global::Martian.JsonConverters.AnthropicContentBlockTypeJsonConverter),

            typeof(global::Martian.JsonConverters.AnthropicContentBlockTypeNullableJsonConverter),

            typeof(global::Martian.JsonConverters.AnthropicContentBlockSourceTypeJsonConverter),

            typeof(global::Martian.JsonConverters.AnthropicContentBlockSourceTypeNullableJsonConverter),

            typeof(global::Martian.JsonConverters.MessagesRequestToolChoiceTypeJsonConverter),

            typeof(global::Martian.JsonConverters.MessagesRequestToolChoiceTypeNullableJsonConverter),

            typeof(global::Martian.JsonConverters.AnthropicResponseContentBlockTypeJsonConverter),

            typeof(global::Martian.JsonConverters.AnthropicResponseContentBlockTypeNullableJsonConverter),

            typeof(global::Martian.JsonConverters.MessagesResponseTypeJsonConverter),

            typeof(global::Martian.JsonConverters.MessagesResponseTypeNullableJsonConverter),

            typeof(global::Martian.JsonConverters.MessagesResponseRoleJsonConverter),

            typeof(global::Martian.JsonConverters.MessagesResponseRoleNullableJsonConverter),

            typeof(global::Martian.JsonConverters.MessagesResponseStopReasonJsonConverter),

            typeof(global::Martian.JsonConverters.MessagesResponseStopReasonNullableJsonConverter),

            typeof(global::Martian.JsonConverters.ModelInfoObjectJsonConverter),

            typeof(global::Martian.JsonConverters.ModelInfoObjectNullableJsonConverter),

            typeof(global::Martian.JsonConverters.ModelInfoReliabilityJsonConverter),

            typeof(global::Martian.JsonConverters.ModelInfoReliabilityNullableJsonConverter),

            typeof(global::Martian.JsonConverters.ListModelsResponseObjectJsonConverter),

            typeof(global::Martian.JsonConverters.ListModelsResponseObjectNullableJsonConverter),

            typeof(global::Martian.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Martian.ContentPart>>),

            typeof(global::Martian.JsonConverters.OneOfJsonConverter<global::Martian.ChatCompletionRequestToolChoiceEnum?, global::Martian.ChatCompletionRequestToolChoiceEnum2>),

            typeof(global::Martian.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Martian.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Martian.AnthropicContentBlock>>),

            typeof(global::Martian.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Martian.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Martian.ChatCompletionMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Martian.ChatCompletionMessageRole), TypeInfoPropertyName = "ChatCompletionMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Martian.OneOf<string, global::System.Collections.Generic.IList<global::Martian.ContentPart>>), TypeInfoPropertyName = "OneOfStringIListContentPart2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Martian.ContentPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Martian.ContentPart))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Martian.ToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Martian.ToolCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Martian.ContentPartType), TypeInfoPropertyName = "ContentPartType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Martian.ContentPartImageUrl))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Martian.ContentPartImageUrlDetail), TypeInfoPropertyName = "ContentPartImageUrlDetail2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Martian.ToolCallType), TypeInfoPropertyName = "ToolCallType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Martian.ToolCallFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Martian.Tool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Martian.ToolType), TypeInfoPropertyName = "ToolType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Martian.ToolFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Martian.ResponseFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Martian.ResponseFormatType), TypeInfoPropertyName = "ResponseFormatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Martian.ResponseFormatJsonSchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Martian.ChatCompletionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Martian.ChatCompletionMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Martian.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Martian.OneOf<global::Martian.ChatCompletionRequestToolChoiceEnum?, global::Martian.ChatCompletionRequestToolChoiceEnum2>), TypeInfoPropertyName = "OneOfChatCompletionRequestToolChoiceEnumChatCompletionRequestToolChoiceEnum22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Martian.ChatCompletionRequestToolChoiceEnum), TypeInfoPropertyName = "ChatCompletionRequestToolChoiceEnum3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Martian.ChatCompletionRequestToolChoiceEnum2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Martian.ChatCompletionRequestToolChoiceEnumType), TypeInfoPropertyName = "ChatCompletionRequestToolChoiceEnumType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Martian.ChatCompletionRequestToolChoiceEnumFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Martian.OneOf<string, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "OneOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Martian.ChatCompletionChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Martian.ChatCompletionChoiceFinishReason), TypeInfoPropertyName = "ChatCompletionChoiceFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Martian.CompletionUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Martian.ChatCompletionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Martian.ChatCompletionResponseObject), TypeInfoPropertyName = "ChatCompletionResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Martian.ChatCompletionChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Martian.ChatCompletionChunkDelta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Martian.ChatCompletionChunkDeltaRole), TypeInfoPropertyName = "ChatCompletionChunkDeltaRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Martian.ToolCallChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Martian.ToolCallChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Martian.ToolCallChunkType), TypeInfoPropertyName = "ToolCallChunkType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Martian.ToolCallChunkFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Martian.ChatCompletionChunkChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Martian.ChatCompletionChunkChoiceFinishReason), TypeInfoPropertyName = "ChatCompletionChunkChoiceFinishReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Martian.ChatCompletionChunkResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Martian.ChatCompletionChunkResponseObject), TypeInfoPropertyName = "ChatCompletionChunkResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Martian.ChatCompletionChunkChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Martian.AnthropicMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Martian.AnthropicMessageRole), TypeInfoPropertyName = "AnthropicMessageRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Martian.OneOf<string, global::System.Collections.Generic.IList<global::Martian.AnthropicContentBlock>>), TypeInfoPropertyName = "OneOfStringIListAnthropicContentBlock2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Martian.AnthropicContentBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Martian.AnthropicContentBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Martian.AnthropicContentBlockType), TypeInfoPropertyName = "AnthropicContentBlockType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Martian.AnthropicContentBlockSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Martian.AnthropicContentBlockSourceType), TypeInfoPropertyName = "AnthropicContentBlockSourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Martian.AnthropicTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Martian.MessagesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Martian.AnthropicMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Martian.AnthropicTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Martian.MessagesRequestToolChoice))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Martian.MessagesRequestToolChoiceType), TypeInfoPropertyName = "MessagesRequestToolChoiceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Martian.AnthropicResponseContentBlock))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Martian.AnthropicResponseContentBlockType), TypeInfoPropertyName = "AnthropicResponseContentBlockType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Martian.AnthropicUsage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Martian.MessagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Martian.MessagesResponseType), TypeInfoPropertyName = "MessagesResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Martian.MessagesResponseRole), TypeInfoPropertyName = "MessagesResponseRole2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Martian.AnthropicResponseContentBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Martian.MessagesResponseStopReason), TypeInfoPropertyName = "MessagesResponseStopReason2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Martian.ModelInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Martian.ModelInfoObject), TypeInfoPropertyName = "ModelInfoObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Martian.ModelInfoReliability), TypeInfoPropertyName = "ModelInfoReliability2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Martian.ListModelsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Martian.ListModelsResponseObject), TypeInfoPropertyName = "ListModelsResponseObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Martian.ModelInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Martian.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Martian.ErrorResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Martian.OneOf<string, global::System.Collections.Generic.List<global::Martian.ContentPart>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Martian.ContentPart>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Martian.ToolCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Martian.ChatCompletionMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Martian.Tool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Martian.OneOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Martian.ChatCompletionChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Martian.ToolCallChunk>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Martian.ChatCompletionChunkChoice>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Martian.OneOf<string, global::System.Collections.Generic.List<global::Martian.AnthropicContentBlock>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Martian.AnthropicContentBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Martian.AnthropicMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Martian.AnthropicTool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Martian.AnthropicResponseContentBlock>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Martian.ModelInfo>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}