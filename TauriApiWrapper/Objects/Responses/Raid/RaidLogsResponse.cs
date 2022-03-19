using Newtonsoft.Json;

namespace TauriApiWrapper.Objects.Responses.Raid
{
    public sealed class RaidLogsResponse
    {
        [JsonProperty("logs")]
        public RaidLog[] Logs { get; set; }
    }
}