using Newtonsoft.Json;
using System.Collections.Generic;
using TauriApiWrapper.Converters;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Responses.Guild
{
    public sealed class GuildBankLog : BaseApiResponse
    {
        [JsonProperty("guildMembersCount")]
        public int MembersCount { get; set; }

        [JsonProperty("guildName")]
        public string GuildName { get; set; }

        [JsonProperty("realm"), JsonConverter(typeof(RealmNameConverter))]
        public Realm Realm { get; set; }

        [JsonProperty("guildMotd")]
        public string GuildMotd { get; set; }

        [JsonProperty("guildInfoText")]
        public string GuildInfoText { get; set; }

        [JsonProperty("guildBankTabs")]
        public Dictionary<string, GuildBankTab> GuildBankTabs { get; set; }

        [JsonProperty("GuildBankMoney")]
        public GuildBankMoney GuildBankMoney { get; set; }

        [JsonProperty("GuildBankItemList")]
        public Dictionary<int, GuildBankItem> GuildBankItemList { get; set; }
    }
}