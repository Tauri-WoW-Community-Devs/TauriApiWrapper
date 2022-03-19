using Newtonsoft.Json;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Requests
{
    internal class ArenaTeamRequest : ArenaBaseRequest
    {
        public ArenaTeamRequest(int teamSize, string teamName, Realm realm) : base(realm)
        {
            TeamSize = teamSize;
            TeamName = teamName;
        }

        [JsonProperty("ts")]
        public int TeamSize { get; set; }

        [JsonProperty("t")]
        public string TeamName { get; set; }
    }
}