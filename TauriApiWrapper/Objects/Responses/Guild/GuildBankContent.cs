using Newtonsoft.Json;
using System.Collections.Generic;

namespace TauriApiWrapper.Objects.Responses.Guild
{
    public class GuildBankContent : BaseGuildInfo
    {
        [JsonProperty("guildMotd")]
        public string GuildMtod { get; set; }

        [JsonProperty("guildInfoText")]
        public string GuildInfoText { get; set; }

        [JsonProperty("guildBankTabs")]
        public Dictionary<int, GuildBankTab> GuildBankTabs { get; set; }

        [JsonProperty("GuildBankItemList")]
        public Dictionary<int, GuildBankItem> GuildBankItemList { get; set; }
    }
}