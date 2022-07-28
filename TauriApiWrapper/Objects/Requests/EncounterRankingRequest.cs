using Newtonsoft.Json;
using System;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Requests
{
    internal sealed class EncounterRankingRequest : RaidListRequest
    {
        public EncounterRankingRequest(int encounter, Enum difficulty, Realm realm, long? fromID = null, int limit = 0) : base(realm, 0, fromID: fromID, limit: limit)
        {
            Encounter = encounter;
            Difficulty = Convert.ToInt32(difficulty);
        }

        [JsonProperty("encounter")]
        public int Encounter { get; set; }

        [JsonProperty("difficulty")]
        public int Difficulty { get; set; }
    }
}