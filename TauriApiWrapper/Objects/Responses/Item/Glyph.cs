using Newtonsoft.Json;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Responses.Item
{
    public sealed class Glyph
    {
        [JsonProperty("spec")]
        public long Spec { get; set; }

        [JsonProperty("slot")]
        public long Slot { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("desc")]
        public string Desc { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("typeflag")]
        public GlyphType Type { get; set; }
    }
}