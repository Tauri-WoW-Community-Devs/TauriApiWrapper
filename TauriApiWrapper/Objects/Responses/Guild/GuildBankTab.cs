using Newtonsoft.Json;

namespace TauriApiWrapper.Objects.Responses.Guild
{
    public sealed class GuildBankTab
    {
        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }
}