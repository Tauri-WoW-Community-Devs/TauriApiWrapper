using Newtonsoft.Json;
using TauriApiWrapper.Converters;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Responses.Arena
{
    public sealed class ArenaTeamReportOpposingTeams : BaseApiResponse
    {
        [JsonProperty("realm"), JsonConverter(typeof(RealmNameConverter))]
        public Realm Realm { get; set; }

        [JsonProperty("team")]
        public ArenaTeam Team { get; set; }

        [JsonProperty("teamstats")]
        public ArenaTeamGameChartTeamstats TeamStats { get; set; }

        [JsonProperty("Season_start_time")]
        public int SeasonStartTime { get; set; }

        [JsonProperty("matchData")]
        public ArenaTeamReportOpposingTeamsMatchData MatchData { get; set; }
    }
}