﻿using Newtonsoft.Json;
using System.Collections.Generic;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Responses.Arena
{
    public class ArenaLadder : BaseApiResponse
    {
        [JsonProperty("ts")]
        public int Ts { get; set; }

        [JsonProperty("resultfrom")]
        public int Resultfrom { get; set; }

        [JsonProperty("resultcountperpage")]
        public int ResultCountPerPage { get; set; }


        [JsonProperty("realm")]
        public Realm Realm { get; set; }

        [JsonProperty("laddertype")]
        public ArenaTeamFormat LadderType { get; set; }

        [JsonProperty("ladder")]
        public IEnumerable<Ladder> Ladder { get; set; }
    }

    public class Ladder
    {
        [JsonProperty("Guid")]
        public long Guid { get; set; }

        [JsonProperty("character-minimal-data")]
        public CharacterMinimalData CharacterMinimalData { get; set; }

        [JsonProperty("realmName")]
        public Realm RealmName { get; set; }

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
        public int LastSpecId { get; set; }
    }
}