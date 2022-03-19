using Newtonsoft.Json;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Requests
{
    internal class RaidListRequest : BaseRequestObject
    {
        public RaidListRequest(Realm realm, int? mapID = null, long? fromID = null, int limit = 0) : base(realm)
        {
            From = fromID;
            Limit = limit;
            MapID = mapID;
        }

        [JsonProperty("from")]
        public long? From { get; set; }

        [JsonProperty("map")]
        public int? MapID { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }
    }
}