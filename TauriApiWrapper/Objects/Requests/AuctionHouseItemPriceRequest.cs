using Newtonsoft.Json;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Requests
{
    internal sealed class AuctionHouseItemPriceRequest : AuctionHouseBaseRequest
    {
        [JsonProperty("item")]
        public int ItemID { get; set; }

        public AuctionHouseItemPriceRequest(int itemID, Realm realm) : base(realm)
        {
            ItemID = itemID;
        }
    }
}