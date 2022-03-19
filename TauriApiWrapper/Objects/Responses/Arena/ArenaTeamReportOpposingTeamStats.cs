using Newtonsoft.Json;

namespace TauriApiWrapper.Objects.Responses.Arena
{
    public sealed class ArenaTeamReportOpposingTeamStats
    {
        [JsonProperty("rating")]
        public int Rating { get; set; }

        [JsonProperty("games_week")]
        public int GamesWeek { get; set; }

        [JsonProperty("wins_week")]
        public int WinsWeek { get; set; }

        [JsonProperty("games_season")]
        public int GamesSeason { get; set; }

        [JsonProperty("wins_season")]
        public int WinsSeason { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }

        [JsonProperty("percent_week")]
        public int PercentWeek { get; set; }

        [JsonProperty("percent_season")]
        public int PercentSeason { get; set; }
    }
}