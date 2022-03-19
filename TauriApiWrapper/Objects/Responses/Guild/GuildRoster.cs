using Newtonsoft.Json;
using System.Collections.Generic;

namespace TauriApiWrapper.Objects.Responses.Guild
{
    public class GuildRoster : BaseGuildInfo
    {
        [JsonProperty("guildList")]
        public Dictionary<string, GuildPlayer> GuildList { get; set; }

        [JsonProperty("gRanks")]
        public Dictionary<string, GuildRank> GuildRanks { get; set; }
    }
}