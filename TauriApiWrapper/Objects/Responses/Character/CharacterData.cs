using Newtonsoft.Json;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Responses.Character
{
    public class CharacterData : BaseApiResponse
    {
        [JsonProperty("charname")]
        public string Name { get; set; }

        [JsonProperty("race")]
        public Race Race { get; set; }

        [JsonProperty("class")]
        public Class Class { get; set; }

        [JsonProperty("gender")]
        public Gender Gender { get; set; }

        [JsonProperty("guildname")]
        public string GuildName { get; set; }

        [JsonProperty("level")]
        public int Level { get; set; }

        [JsonProperty("faction")]
        public Faction Faction { get; set; }

        [JsonProperty("isCharacter")]
        public bool IsCharacter { get; set; }
    }
}