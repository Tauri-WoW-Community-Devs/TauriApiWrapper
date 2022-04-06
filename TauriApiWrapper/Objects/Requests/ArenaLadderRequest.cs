using Newtonsoft.Json;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Requests
{
    internal class ArenaLadderRequest : ArenaBaseRequest
    {
        public ArenaLadderRequest(ArenaTeamFormat teamSize, Realm realm) : base(realm)
        {
            TeamSize = (int)teamSize;
        }

        [JsonProperty("ts")]
        public int TeamSize { get; set; }
    }
}