using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TauriApiWrapper.Objects;

namespace TauriApiWrapper
{
    public class TauriClient
    {
        private static HttpClient _client = new HttpClient();

        public static bool IsApiDown { get; private set; }
        public static Action<Exception> ExceptionHandler { get; private set; }


        public TauriClient(string apiKey, string apiSecret, bool useStormforgeApi, TimeSpan timeout = default, Action<Exception> exceptionHandler = null)
        {
            ApiKey = apiKey;
            IsStormforge = useStormforgeApi;
            ApiSecret = apiSecret;
            ExceptionHandler = exceptionHandler;
            if (timeout != default)
            {
                _client.Timeout = timeout;
            }

            ProductInfoHeaderValue productValue = new ProductInfoHeaderValue("StormforgeLogs.ApiWrapper", GetType().Assembly.GetName().Version.ToString());
            ProductInfoHeaderValue commentValue = new ProductInfoHeaderValue("(+https://github.com/Tauri-WoW-Community-Devs/StormforgeLogs.ApiWrapper)");

            _client.DefaultRequestHeaders.UserAgent.Add(productValue);
            _client.DefaultRequestHeaders.UserAgent.Add(commentValue);
        }

        #region Fields


        private readonly string ApiKey;
        private readonly bool IsStormforge;
        internal readonly string ApiSecret;


        public static readonly string InvalidExpansion = "This expansion is invalid or not supported for this method.";

        #endregion Fields

        #region Private Properties

        private string Endpoint
        {
            get
            {
                if (IsStormforge)
                {
                    return $"{Uri.UriSchemeHttps}{Uri.SchemeDelimiter}characters-api.stormforge.gg/v1/?apikey={ApiKey}";
                }

                return $"{Uri.UriSchemeHttp}{Uri.SchemeDelimiter}chapi.tauri.hu/apiIndex.php?apikey={ApiKey}";
            }
        }

        #endregion Private Properties

        #region Methods

        internal ApiResponse<T> Communicate<T>(ApiParams data) where T : class
        {
            ApiResponse<T> apiObject = new ApiResponse<T>();
            string response = CallAPI(data, CancellationToken.None);

            if (!string.IsNullOrEmpty(response))
            {
                return apiObject.ToApiResponse(response);
            }

            return apiObject;
        }

        internal async Task<ApiResponse<T>> CommunicateAsync<T>(ApiParams data, CancellationToken cancellationToken) where T : class
        {
            ApiResponse<T> apiObject = new ApiResponse<T>();
            string response = await CallAPIAsync(data, cancellationToken).ConfigureAwait(false);

            if (!string.IsNullOrEmpty(response))
            {
                return apiObject.ToApiResponse(response);
            }

            return apiObject;
        }

        #endregion Methods

        #region Privates

        private string CallAPI(ApiParams data, CancellationToken cancellationToken)
        {
            return CallAPIAsync(data, cancellationToken).GetAwaiter().GetResult();
        }

        private async Task<string> CallAPIAsync(ApiParams data, CancellationToken cancellationToken)
        {

            try
            {
                using HttpResponseMessage response = await _client.PostAsync(Endpoint, SetRequestData(data), cancellationToken).ConfigureAwait(false);

                if ((int)response.StatusCode >= 500 || (int)response.StatusCode > 400)
                {
                    response.EnsureSuccessStatusCode();
                }

                IsApiDown = false;
                return await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            }
            catch (TaskCanceledException) { }
            catch (Exception ex)
            {
                IsApiDown = true;
                ex.Data.Add("request", data.ToString());
                ExceptionHandler?.Invoke(ex);
            }

            return default;
        }

        private StringContent SetRequestData(ApiParams data)
        {
            return new StringContent(data.ToJson(), Encoding.UTF8, "application/json");
        }

        #endregion Privates
    }
}
