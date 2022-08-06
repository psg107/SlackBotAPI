using System.Text.Json;

namespace SlackBotAPI.Helpers
{
    /// <summary>
    /// 
    /// </summary>
    public class HttpClientWrapper
    {
        private readonly HttpClient client;

        public HttpClientWrapper(HttpClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TResponse"></typeparam>
        /// <param name="method"></param>
        /// <param name="requestUrl"></param>
        /// <returns></returns>
        public async Task<TResponse> Request<TResponse>(HttpMethod method, string requestUrl)
        {
            var response = await client.SendAsync(new HttpRequestMessage(method, requestUrl));
            var content = await response.Content.ReadAsStringAsync();

            var result = JsonSerializer.Deserialize<TResponse>(content);

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TRequest"></typeparam>
        /// <typeparam name="TResponse"></typeparam>
        /// <param name="method"></param>
        /// <param name="requestUrl"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<TResponse> Request<TRequest, TResponse>(HttpMethod method, string requestUrl, TRequest request) where TRequest : class
        {
            requestUrl += $"?{request.ToQueryString()}";

            var response = await client.SendAsync(new HttpRequestMessage(method, requestUrl));
            var content = await response.Content.ReadAsStringAsync();

            var result = JsonSerializer.Deserialize<TResponse>(content);

            return result;
        }
    }
}
