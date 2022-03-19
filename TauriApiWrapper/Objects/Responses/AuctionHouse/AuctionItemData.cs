using Newtonsoft.Json;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Responses.AuctionHouse
{
    public sealed class AuctionItemData
    {
        [JsonProperty("itemName")]
        public string ItemName { get; set; }

        [JsonProperty("itemIcon")]
        public string ItemIcon { get; set; }

        [JsonProperty("itemLevel")]
        public int ItemLevel { get; set; }

        [JsonProperty("minLevel")]
        public int MinLevel { get; set; }

        [JsonProperty("rarity")]
        public ItemRarity Rarity { get; set; }
    }
}