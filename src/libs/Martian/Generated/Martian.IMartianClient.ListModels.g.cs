#nullable enable

namespace Martian
{
    public partial interface IMartianClient
    {
        /// <summary>
        /// List available models<br/>
        /// Returns a list of all models currently supported by the Martian Gateway,<br/>
        /// including pricing information (cost per token in USD), reliability tiers,<br/>
        /// maximum completion tokens, and provider details.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Martian.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Martian.ListModelsResponse> ListModelsAsync(
            global::Martian.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}