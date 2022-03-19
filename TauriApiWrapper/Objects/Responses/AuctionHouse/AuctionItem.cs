using Newtonsoft.Json;
using TauriApiWrapper.Converters;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Responses.AuctionHouse
{
    public sealed class AuctionItem
    {
        [JsonProperty("auc")]
        public long Auc { get; set; }

        [JsonProperty("item")]
        public long Item { get; set; }

        [JsonProperty("itemData")]
        public AuctionItemData ItemData { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("ownerRealm"), JsonConverter(typeof(RealmNameConverter))]
        public Realm OwnerRealm { get; set; }

        [JsonProperty("bid")]
        public long Bid { get; set; }

        [JsonProperty("buyout")]
        public long Buyout { get; set; }

        [JsonProperty("timeLeft")]
        public string TimeLeft { get; set; }

        [JsonProperty("stackCount")]
        public long StackCount { get; set; }

        [JsonProperty("rand")]
        public long Rand { get; set; }

        [JsonProperty("seed")]
        public long Seed { get; set; }
    }
}