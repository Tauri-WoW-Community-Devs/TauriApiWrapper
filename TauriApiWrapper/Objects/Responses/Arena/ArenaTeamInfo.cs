using Newtonsoft.Json;
using TauriApiWrapper.Converters;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Responses.Arena
{
    public class ArenaTeamInfo : BaseApiResponse
    {
        [JsonProperty("item")]
        public int ItemID { get; set; }

        [JsonProperty("realm"), JsonConverter(typeof(RealmNameConverter))]
        public Realm Realm { get; set; }

        [JsonProperty("team")]
        public ArenaTeam Team { get; set; }

        [JsonProperty("teamstats")]
        public ArenaTeamInfoTeamstats TeamStats { get; set; }

        [JsonProperty("teamMembers")]
        public ArenaTeamInfoTeamMembers TeamMembers { get; set; }
    }
}