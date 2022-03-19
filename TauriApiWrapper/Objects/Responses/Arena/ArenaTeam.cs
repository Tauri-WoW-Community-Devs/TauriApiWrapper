using Newtonsoft.Json;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Responses.Arena
{
    public class ArenaTeam
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public TeamType Type { get; set; }

        [JsonProperty("faction")]
        public Faction Faction { get; set; }
    }
}