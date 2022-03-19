using Newtonsoft.Json;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Responses
{
    public abstract class BaseApiResponse
    {
        [JsonProperty("isCata")]
        public bool IsCata { get; set; }

        [JsonProperty("expansion")]
        public Expansion Expansion { get; set; }

        [JsonProperty("dataUrlPrefix")]
        public string DataUrlPrefix { get; set; }
    }
}