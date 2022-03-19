using Newtonsoft.Json;

namespace TauriApiWrapper.Objects
{
    public class ApiParams
    {
        [JsonProperty(PropertyName = "secret", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Secret { get; private set; }

        [JsonProperty(PropertyName = "params", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IApiParam Params { get; private set; }

        [JsonProperty(PropertyName = "url", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Url { get; }

        #region Ctor

        public ApiParams()
        {
        }

        public ApiParams(string url, string secret, IApiParam apiParams)
        {
            Url = url;
            Secret = secret;
            Params = apiParams;
        }

        #endregion Ctor

        #region Public Methods

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            });
        }

        #endregion Public Methods
    }
}