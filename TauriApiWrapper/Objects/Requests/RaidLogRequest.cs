using Newtonsoft.Json;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Requests
{
    internal sealed class RaidLogRequest : BaseRequestObject
    {
        public RaidLogRequest(int logID, Realm realm) : base(realm)
        {
            LogID = logID;
        }

        [JsonProperty("id")]
        public int LogID { get; set; }
    }
}