using Newtonsoft.Json;

namespace TauriApiWrapper.Objects.Responses.Raid
{
    public sealed class RaidEncounterRankingResponse
    {
        [JsonProperty("logs")]
        public RaidLogRanking[] Logs { get; set; }
    }
}