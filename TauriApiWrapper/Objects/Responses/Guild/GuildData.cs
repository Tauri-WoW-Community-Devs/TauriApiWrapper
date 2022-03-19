using Newtonsoft.Json;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Responses.Guild
{
    public sealed class GuildData
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("faction", NullValueHandling = NullValueHandling.Ignore)]
        public Faction? Faction { get; set; }

        [JsonProperty("leadername", NullValueHandling = NullValueHandling.Ignore)]
        public string LeaderName { get; set; }
    }
}