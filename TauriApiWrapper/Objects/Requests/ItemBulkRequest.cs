using Newtonsoft.Json;
using System.Collections.Generic;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Requests
{
    internal sealed class ItemBulkRequest : BaseRequestObject
    {
        public ItemBulkRequest(IEnumerable<int> itemIDs, Realm realm = Realm.Evermoon) : base(realm)
        {
            ItemIDs = itemIDs;
        }

        [JsonProperty("e")]
        public IEnumerable<int> ItemIDs { get; }
    }
}