using Newtonsoft.Json;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Requests
{
    internal class ArenaTeamRequest : ArenaBaseRequest
    {
        public ArenaTeamRequest(Realm realm, ArenaTeamFormat teamSize, string teamName) : base(realm)
        {
            TeamSize = (int)teamSize;
            TeamName = teamName;
        }

        [JsonProperty("ts")]
        public int TeamSize { get; set; }

        [JsonProperty("t")]
        public string TeamName { get; set; }
    }
}