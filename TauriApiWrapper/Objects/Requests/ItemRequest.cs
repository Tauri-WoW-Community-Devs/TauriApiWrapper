using Newtonsoft.Json;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Requests
{
    internal sealed class ItemRequest : BaseRequestObject
    {
        public ItemRequest(int itemID, Realm realm = Realm.Evermoon) : base(realm)
        {
            ItemID = itemID;
        }

        public ItemRequest(long guid, string pcs, Realm realm) : base(realm)
        {
            ItemGuid = guid;
            PcsParam = pcs;
        }

        [JsonProperty("e")]
        public int? ItemID { get; }

        [JsonProperty("i")]
        public long? ItemGuid { get; }

        [JsonProperty("pcs")]
        public string PcsParam { get; set; }
    }
}