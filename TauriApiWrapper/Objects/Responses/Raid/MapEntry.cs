using Newtonsoft.Json;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Responses.Raid
{
    public class MapEntry
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("expansion")]
        public Expansion Expansion { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}