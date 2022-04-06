using Newtonsoft.Json;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Responses.Arena
{
    public sealed class CharacterPvpStats
    {
        [JsonProperty("Guid")]
        public int Guid { get; set; }

        [JsonProperty("character-minimal-data")]
        public CharacterMinimalData CharacterMinimalData { get; set; }

        [JsonProperty("Slot")]
        public ArenaRatingSlot Slot { get; set; }

        [JsonProperty("played_week")]
        public int PlayedWeek { get; set; }

        [JsonProperty("wons_week")]
        public int WonsWeek { get; set; }

        [JsonProperty("played_season")]
        public int PlayedSeason { get; set; }

        [JsonProperty("wons_season")]
        public int WonsSeason { get; set; }

        [JsonProperty("rating_best_weekly")]
        public int RatingBestWeekly { get; set; }

        [JsonProperty("rating_best_season")]
        public int RatingBestSeason { get; set; }

        [JsonProperty("personal_rating")]
        public int PersonalRating { get; set; }

        [JsonProperty("prev_personal_rating")]
        public int PrevPersonalRating { get; set; }

        [JsonProperty("lastspecid")]
        public int LastSpecID { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }

        [JsonProperty("lastspecname", NullValueHandling = NullValueHandling.Ignore)]
        public string LastSpecName { get; set; }

        [JsonProperty("lastspeciconname", NullValueHandling = NullValueHandling.Ignore)]
        public string LastSpecIconName { get; set; }
    }

    public sealed class CharacterMinimalData
    {
        [JsonProperty("charname")]
        public string CharName { get; set; }

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
    }
}
