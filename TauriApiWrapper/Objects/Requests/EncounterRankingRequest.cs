using Newtonsoft.Json;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Requests
{
    internal sealed class EncounterRankingRequest : RaidListRequest
    {
        public EncounterRankingRequest(int encounter, RaidDifficulty difficulty, Realm realm, long? fromID = null, int limit = 0) : base(realm, 0, fromID: fromID, limit: limit)
        {
            Encounter = encounter;
            Difficulty = (int)difficulty;
        }

        [JsonProperty("encounter")]
        public int Encounter { get; set; }

        [JsonProperty("difficulty")]
        public int Difficulty { get; set; }
    }
}