using Newtonsoft.Json;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Requests
{
    internal class ArenaLadderRequest : ArenaBaseRequest
    {
        public ArenaLadderRequest(int teamSize, Realm realm) : base(realm)
        {
            TeamSize = teamSize;
        }

        [JsonProperty("ts")]
        public int TeamSize { get; set; }
    }
}