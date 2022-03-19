using Newtonsoft.Json;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Requests
{
    internal sealed class GuildRaidLogRequest : RaidListRequest
    {
        public GuildRaidLogRequest(string name, Realm realm, long? fromID = null, int limit = 0) : base(realm, 0, fromID: fromID, limit: limit)
        {
            GuildName = name;
        }

        [JsonProperty("gn")]
        public string GuildName { get; set; }
    }
}