using Newtonsoft.Json;

namespace TauriApiWrapper.Objects.Responses.Guild
{
    public sealed class GuildInfo
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("faction", NullValueHandling = NullValueHandling.Ignore)]
        public int Faction { get; set; }

        [JsonProperty("leadername", NullValueHandling = NullValueHandling.Ignore)]
        public string LeaderName { get; set; }
    }
}