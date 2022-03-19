using Newtonsoft.Json;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Requests
{
    internal class ArenaGameRequest : ArenaBaseRequest
    {
        public ArenaGameRequest(int matchID, Realm realm) : base(realm)
        {
            MatchID = matchID;
        }

        [JsonProperty("gid")]
        public int MatchID { get; set; }
    }
}