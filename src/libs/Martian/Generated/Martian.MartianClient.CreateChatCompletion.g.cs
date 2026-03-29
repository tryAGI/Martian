
#nullable enable

namespace Martian
{
    public partial class MartianClient
    {
        partial void PrepareCreateChatCompletionArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Martian.ChatCompletionRequest request);
        partial void PrepareCreateChatCompletionRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Martian.ChatCompletionRequest request);
        partial void ProcessCreateChatCompletionResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateChatCompletionResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create a chat completion<br/>
        /// Creates a chat completion using the specified model via the Martian Gateway.<br/>
        /// Supports OpenAI-compatible parameters plus Martian-specific routing parameters<br/>
        /// such as models, max_cost, max_cost_per_million_tokens, and willingness_to_pay.<br/>
        /// The gateway intelligently routes to the best model based on cost, quality, and latency.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Martian.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Martian.ChatCompletionResponse> CreateChatCompletionAsync(

            global::Martian.ChatCompletionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateChatCompletionArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::Martian.PathBuilder(
                path: "/v1/chat/completions",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareCreateChatCompletionRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessCreateChatCompletionResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Bad request
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::Martian.ErrorResponse? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::Martian.ErrorResponse.FromJson(__content_400, JsonSerializerContext);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::Martian.ErrorResponse.FromJson(__content_400, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::Martian.ApiException<global::Martian.ErrorResponse>(
                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_400,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_400,
                    ResponseObject = __value_400,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Unauthorized
            if ((int)__response.StatusCode == 401)
            {
                string? __content_401 = null;
                global::System.Exception? __exception_401 = null;
                global::Martian.ErrorResponse? __value_401 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_401 = global::Martian.ErrorResponse.FromJson(__content_401, JsonSerializerContext);
                    }
                    else
                    {
                        __content_401 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_401 = global::Martian.ErrorResponse.FromJson(__content_401, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_401 = __ex;
                }

                throw new global::Martian.ApiException<global::Martian.ErrorResponse>(
                    message: __content_401 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_401,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_401,
                    ResponseObject = __value_401,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Rate limited
            if ((int)__response.StatusCode == 429)
            {
                string? __content_429 = null;
                global::System.Exception? __exception_429 = null;
                global::Martian.ErrorResponse? __value_429 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_429 = global::Martian.ErrorResponse.FromJson(__content_429, JsonSerializerContext);
                    }
                    else
                    {
                        __content_429 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_429 = global::Martian.ErrorResponse.FromJson(__content_429, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_429 = __ex;
                }

                throw new global::Martian.ApiException<global::Martian.ErrorResponse>(
                    message: __content_429 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_429,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_429,
                    ResponseObject = __value_429,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessCreateChatCompletionResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Martian.ChatCompletionResponse.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::Martian.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();

                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::Martian.ChatCompletionResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::Martian.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
        /// <summary>
        /// Create a chat completion<br/>
        /// Creates a chat completion using the specified model via the Martian Gateway.<br/>
        /// Supports OpenAI-compatible parameters plus Martian-specific routing parameters<br/>
        /// such as models, max_cost, max_cost_per_million_tokens, and willingness_to_pay.<br/>
        /// The gateway intelligently routes to the best model based on cost, quality, and latency.
        /// </summary>
        /// <param name="model">
        /// The model to use, in provider/model-name format.<br/>
        /// Example: openai/gpt-4.1-nano, anthropic/claude-sonnet-4-20250514
        /// </param>
        /// <param name="messages">
        /// A list of messages comprising the conversation so far.
        /// </param>
        /// <param name="temperature">
        /// Sampling temperature between 0 and 2.
        /// </param>
        /// <param name="maxCompletionTokens">
        /// Maximum number of tokens to generate in the chat completion.
        /// </param>
        /// <param name="maxTokens">
        /// Maximum number of tokens to generate (deprecated, use max_completion_tokens).
        /// </param>
        /// <param name="stream">
        /// If true, partial message deltas will be sent as SSE events.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="tools">
        /// A list of tools the model may call.
        /// </param>
        /// <param name="toolChoice">
        /// Controls which (if any) tool is called by the model.
        /// </param>
        /// <param name="responseFormat"></param>
        /// <param name="frequencyPenalty">
        /// Penalize new tokens based on their frequency in text so far. Between -2.0 and 2.0.
        /// </param>
        /// <param name="presencePenalty">
        /// Penalize new tokens based on whether they appear in text so far. Between -2.0 and 2.0.
        /// </param>
        /// <param name="topP">
        /// Nucleus sampling parameter. Between 0 and 1.
        /// </param>
        /// <param name="seed">
        /// Seed for deterministic sampling.
        /// </param>
        /// <param name="stop">
        /// Up to 4 sequences where the API will stop generating.
        /// </param>
        /// <param name="logprobs">
        /// Whether to return log probabilities of the output tokens.
        /// </param>
        /// <param name="topLogprobs">
        /// Number of most likely tokens to return at each position.
        /// </param>
        /// <param name="user">
        /// A unique identifier representing the end-user.
        /// </param>
        /// <param name="models">
        /// List of models the router can choose from. When specified, the router<br/>
        /// will only route between these models. Uses provider/model-name format.
        /// </param>
        /// <param name="maxCost">
        /// Maximum cost of the total request in USD. Allows you to specify<br/>
        /// an upper bound on what you are willing to pay for the request.
        /// </param>
        /// <param name="maxCostPerMillionTokens">
        /// Maximum cost per 1 million tokens in USD. Allows you to specify<br/>
        /// a minimum efficiency for your models.
        /// </param>
        /// <param name="willingnessToPay">
        /// Value of getting better output, measured in dollars. A value of 0.1<br/>
        /// indicates that each 10% improvement in performance is worth 10 cents.<br/>
        /// If not set, defaults to infinity (optimize only for performance).
        /// </param>
        /// <param name="extra">
        /// Arbitrary metadata to attach to the request for tracking.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Martian.ChatCompletionResponse> CreateChatCompletionAsync(
            string model,
            global::System.Collections.Generic.IList<global::Martian.ChatCompletionMessage> messages,
            float? temperature = default,
            int? maxCompletionTokens = default,
            int? maxTokens = default,
            bool? stream = default,
            global::System.Collections.Generic.IList<global::Martian.Tool>? tools = default,
            global::Martian.OneOf<global::Martian.ChatCompletionRequestToolChoiceEnum?, global::Martian.ChatCompletionRequestToolChoiceEnum2>? toolChoice = default,
            global::Martian.ResponseFormat? responseFormat = default,
            float? frequencyPenalty = default,
            float? presencePenalty = default,
            float? topP = default,
            int? seed = default,
            global::Martian.OneOf<string, global::System.Collections.Generic.IList<string>>? stop = default,
            bool? logprobs = default,
            int? topLogprobs = default,
            string? user = default,
            global::System.Collections.Generic.IList<string>? models = default,
            float? maxCost = default,
            float? maxCostPerMillionTokens = default,
            float? willingnessToPay = default,
            object? extra = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Martian.ChatCompletionRequest
            {
                Model = model,
                Messages = messages,
                Temperature = temperature,
                MaxCompletionTokens = maxCompletionTokens,
                MaxTokens = maxTokens,
                Stream = stream,
                Tools = tools,
                ToolChoice = toolChoice,
                ResponseFormat = responseFormat,
                FrequencyPenalty = frequencyPenalty,
                PresencePenalty = presencePenalty,
                TopP = topP,
                Seed = seed,
                Stop = stop,
                Logprobs = logprobs,
                TopLogprobs = topLogprobs,
                User = user,
                Models = models,
                MaxCost = maxCost,
                MaxCostPerMillionTokens = maxCostPerMillionTokens,
                WillingnessToPay = willingnessToPay,
                Extra = extra,
            };

            return await CreateChatCompletionAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}