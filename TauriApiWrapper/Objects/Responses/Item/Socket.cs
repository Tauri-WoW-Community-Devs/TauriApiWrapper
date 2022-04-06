using Newtonsoft.Json;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Responses.Item
{
    public sealed class Socket
    {
        [JsonProperty("Color")]
        public GemColor Color { get; set; }

        [JsonProperty("Content")]
        public int Content { get; set; }
    }
}