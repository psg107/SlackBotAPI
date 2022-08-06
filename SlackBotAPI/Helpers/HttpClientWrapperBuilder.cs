namespace SlackBotAPI.Helpers
{
    /// <summary>
    /// 
    /// </summary>
    public class HttpClientWrapperBuilder
    {
        private readonly HttpClient httpClient;

        public HttpClientWrapperBuilder()
        {
            this.httpClient = new HttpClient();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="baseAddress"></param>
        /// <returns></returns>
        public HttpClientWrapperBuilder SetBaseAddress(string baseAddress)
        {
            httpClient.BaseAddress = new Uri(baseAddress);

            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="baseAddress"></param>
        /// <returns></returns>
        public HttpClientWrapperBuilder SetAuthorization(string scheme, string parameter)
        {
            httpClient.DefaultRequestHeaders.Authorization 
                = new System.Net.Http.Headers.AuthenticationHeaderValue(scheme, parameter);

            return this;
        }

        public HttpClientWrapper Build()
        {
            var clientWrapper = new HttpClientWrapper(this.httpClient);

            return clientWrapper;
        }
    }
}
