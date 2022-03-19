using Newtonsoft.Json;

namespace TauriApiWrapper.Objects.Responses.Item
{
    public sealed class ItemStat
    {
        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("StatDescription")]
        public string StatDescription { get; set; }
    }
}