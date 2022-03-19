using Newtonsoft.Json;
using System.Collections.Generic;

namespace TauriApiWrapper.Objects.Responses.Guild
{
    public sealed class GuildStats : GuildRoster
    {
        [JsonProperty("statList")]
        public new Dictionary<string, GuildPlayer> GuildList { get; set; }
    }
}