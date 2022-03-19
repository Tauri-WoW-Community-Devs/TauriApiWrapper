using Newtonsoft.Json;

namespace TauriApiWrapper.Objects.Responses.Character
{
    public sealed class PrimaryTradeSkill
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("max")]
        public int Max { get; set; }
    }
}