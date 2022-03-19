using Newtonsoft.Json;
using TauriApiWrapper.Enums;
using TauriApiWrapper.Objects.Responses.Item;

namespace TauriApiWrapper.Objects.Responses.Character
{
    public sealed class CharacterItem
    {
        [JsonProperty("entry")]
        public int Entry { get; set; }

        [JsonProperty("guid")]
        public int Guid { get; set; }

        [JsonProperty("originalicon")]
        public string OriginalIcon { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("rarity")]
        public ItemRarity Rarity { get; set; }

        [JsonProperty("stackcount")]
        public int StackCount { get; set; }

        [JsonProperty("ilevel")]
        public int Ilevel { get; set; }

        [JsonProperty("originalname")]
        public string OriginalName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("transmogid")]
        public int TransmogID { get; set; }

        [JsonProperty("transmogitemname")]
        public string TransmogItemName { get; set; }

        [JsonProperty("transmogitemicon")]
        public string TransmogItemIcon { get; set; }

        [JsonProperty("gems")]
        public Gem[] Gems { get; set; }

        [JsonProperty("ench")]
        public ItemEnchant ItemEnchant { get; set; }

        [JsonProperty("queryParams", NullValueHandling = NullValueHandling.Ignore)]
        public string QueryParams { get; set; }
    }
}