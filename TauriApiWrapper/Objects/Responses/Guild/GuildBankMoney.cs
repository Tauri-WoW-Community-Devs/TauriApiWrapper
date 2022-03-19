using Newtonsoft.Json;

namespace TauriApiWrapper.Objects.Responses.Guild
{
    public sealed class GuildBankMoney
    {
        [JsonProperty("gold")]
        public int Gold { get; set; }

        [JsonProperty("silver")]
        public int Silver { get; set; }

        [JsonProperty("copper")]
        public int Copper { get; set; }
    }
}