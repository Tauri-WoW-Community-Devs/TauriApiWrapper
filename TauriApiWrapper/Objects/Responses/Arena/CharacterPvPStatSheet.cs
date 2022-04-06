using Newtonsoft.Json;
using TauriApiWrapper.Objects.Responses.Character;

namespace TauriApiWrapper.Objects.Responses.Arena
{
    public class CharacterPvPStatSheet : CharacterSheet
    {
        [JsonProperty("tname")]
        public string Tname { get; set; }

        [JsonProperty("avgitemlevel")]
        public long Avgitemlevel { get; set; }

        [JsonProperty("playerstats")]
        public CharacterPvpStats[] CharacterPvpStats { get; set; }

        [JsonProperty("matches")]
        public ArenaGame[] Matches { get; set; }
    }
}
