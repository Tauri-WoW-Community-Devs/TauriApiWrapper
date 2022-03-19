using Newtonsoft.Json;

namespace TauriApiWrapper.Objects.Responses.Item
{
    public sealed class Gem
    {
        [JsonProperty("enchantid")]
        public int EnchantID { get; set; }

        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("gemcolor")]
        public int Gemcolor { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }
    }
}