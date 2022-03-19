using Newtonsoft.Json;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Responses.Arena
{
    public sealed class ArenaLadderTeamList
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("rating")]
        public int Rating { get; set; }

        [JsonProperty("race")]
        public Race Race { get; set; }

        [JsonProperty("wins")]
        public int Wins { get; set; }

        [JsonProperty("games")]
        public int Games { get; set; }
    }
}
