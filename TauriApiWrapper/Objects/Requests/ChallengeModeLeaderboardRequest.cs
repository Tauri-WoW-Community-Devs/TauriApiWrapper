using Newtonsoft.Json;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Requests
{
    internal class ChallengeModeLeaderboardRequest : ChallengeModeBaseRequest
    {
        public ChallengeModeLeaderboardRequest(int mapID, Realm realm) : base(realm)
        {
            MapID = mapID;
        }

        [JsonProperty("map")]
        public int MapID { get; set; }
    }
}
