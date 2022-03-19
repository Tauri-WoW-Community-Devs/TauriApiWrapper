using Newtonsoft.Json;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Responses.Arena
{
    public sealed class ArenaTeamReportOpposingTeamsMatchData
    {
        [JsonProperty("EnemyTeamID")]
        public int EnemyTeamID { get; set; }

        [JsonProperty("EnemyTeamName")]
        public string EnemyTeamName { get; set; }

        [JsonProperty("EnemyRating")]
        public int EnemyRating { get; set; }

        [JsonProperty("EnemyRatingChange")]
        public int EnemyRatingChange { get; set; }

        [JsonProperty("TeamRating")]
        public int TeamRating { get; set; }

        [JsonProperty("TeamRatingChange")]
        public int TeamRatingChange { get; set; }

        [JsonProperty("MatchLength")]
        public int MatchLength { get; set; }

        [JsonProperty("realm")]
        public Realm Realm { get; set; }

        [JsonProperty("matchID")]
        public int MatchID { get; set; }

        [JsonProperty("start_time")]
        public int StartTime { get; set; }

        [JsonProperty("wins")]
        public int Wins { get; set; }

        [JsonProperty("matchs")]
        public int Matchs { get; set; }
    }
}