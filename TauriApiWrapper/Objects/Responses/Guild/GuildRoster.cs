using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace TauriApiWrapper.Objects.Responses.Guild
{
    public class GuildRoster : BaseGuildInfo
    {
        [JsonProperty("guildList")]
        public Dictionary<string, GuildPlayer> GuildList { get; set; }

        [JsonProperty("gRanks")]
        public Dictionary<string, GuildRank> GuildRanks { get; set; }

        public GuildPlayer GetGuildMaster()
        {
            return GuildList.Values.Where(x => x.GuildRank == 0).SingleOrDefault();
        }

    }
}