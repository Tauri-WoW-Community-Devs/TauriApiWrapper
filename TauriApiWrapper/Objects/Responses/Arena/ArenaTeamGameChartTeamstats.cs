using Newtonsoft.Json;


namespace TauriApiWrapper.Objects.Responses.Arena
{
    public sealed class ArenaTeamGameChartTeamstats
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
        public double PercentWeek { get; set; }   // int in Tauri documentation

        [JsonProperty("percent_season")]
        public double PercentSeason { get; set; } // int in Tauri documentation
    }
}
