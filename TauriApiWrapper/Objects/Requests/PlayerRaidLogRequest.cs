using Newtonsoft.Json;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Requests
{
    internal sealed class PlayerRaidLogRequest : RaidListRequest
    {
        public PlayerRaidLogRequest(string name, Realm realm, long? fromID = null, int limit = 0) : base(realm, 0, fromID: fromID, limit: limit)
        {
            Name = name;
        }

        [JsonProperty("cn")]
        public string Name { get; set; }
    }
}