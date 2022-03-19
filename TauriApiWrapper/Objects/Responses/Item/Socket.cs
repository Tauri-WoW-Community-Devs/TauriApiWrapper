using Newtonsoft.Json;

namespace TauriApiWrapper.Objects.Responses.Item
{
    public sealed class Socket
    {
        [JsonProperty("Color")]
        public int Color { get; set; }

        [JsonProperty("Content")]
        public int Content { get; set; }
    }
}