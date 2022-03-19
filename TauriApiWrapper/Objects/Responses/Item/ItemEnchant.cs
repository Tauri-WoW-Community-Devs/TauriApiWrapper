using Newtonsoft.Json;

namespace TauriApiWrapper.Objects.Responses.Item
{
    public sealed class ItemEnchant
    {
        [JsonProperty("enchantid", NullValueHandling = NullValueHandling.Ignore)]
        public int? EnchantID { get; set; }

        [JsonProperty("entry", NullValueHandling = NullValueHandling.Ignore)]
        public int? Entry { get; set; }

        [JsonProperty("icon", NullValueHandling = NullValueHandling.Ignore)]
        public string Icon { get; set; }
    }
}