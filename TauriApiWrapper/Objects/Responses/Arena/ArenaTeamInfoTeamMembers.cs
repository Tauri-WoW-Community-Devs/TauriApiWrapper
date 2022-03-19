using Newtonsoft.Json;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Responses.Arena
{
    public class ArenaTeamInfoTeamMembers
    {
        [JsonProperty("realm")]
        public Realm Realm { get; set; }

        [JsonProperty("class")]
        public Class Class { get; set; }

        [JsonProperty("race")]
        public Race Race { get; set; }

        [JsonProperty("gender")]
        public Gender Gender { get; set; }

        [JsonProperty("level")]
        public int Level { get; set; }

        [JsonProperty("faction")]
        public Faction Faction { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("guild_name")]
        public string GuildName { get; set; }

        [JsonProperty("personal_rating")]
        public int PersonalRating { get; set; }

        [JsonProperty("played_season")]
        public int PlayedSeason { get; set; }

        [JsonProperty("played_week")]
        public int PlayedWeek { get; set; }

        [JsonProperty("wons_season")]
        public int WonsSeason { get; set; }

        [JsonProperty("wons_week")]
        public int WonsWeek { get; set; }
    }
}