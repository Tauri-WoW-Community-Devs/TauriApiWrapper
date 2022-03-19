using Newtonsoft.Json;

namespace TauriApiWrapper.Objects.Responses.Character
{
    public sealed class AdditionalBarInfo
    {
        [JsonProperty("class")]
        public string Class { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("value")]
        public int Value { get; set; }
    }
}