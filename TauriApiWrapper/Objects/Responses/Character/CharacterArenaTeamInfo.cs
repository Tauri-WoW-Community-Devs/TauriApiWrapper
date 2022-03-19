using Newtonsoft.Json;

namespace TauriApiWrapper.Objects.Responses.Character
{
    public sealed class CharacterArenaTeamInfo
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }

        [JsonProperty("rating")]
        public int Rating { get; set; }

        [JsonProperty("personalrating")]
        public int Personalrating { get; set; }
    }
}