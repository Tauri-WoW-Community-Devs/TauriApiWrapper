using Newtonsoft.Json;

namespace TauriApiWrapper.Objects.Responses.Raid
{
    public sealed class AvailableDifficulty
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}