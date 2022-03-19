using Newtonsoft.Json;
using TauriApiWrapper.Converters;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Responses.Guild
{
    public abstract class BaseGuildInfo : BaseApiResponse
    {
        [JsonProperty("guildName")]
        public string GuildName { get; set; }

        [JsonProperty("titleName")]
        public string TitleName { get; set; }

        [JsonProperty("realm"), JsonConverter(typeof(RealmNameConverter))]
        public Realm Realm { get; set; }

        [JsonProperty("guildEmblemStyle")]
        public string GuildEmblemStyle { get; set; }

        [JsonProperty("gFaction")]
        public Faction GuildFaction { get; set; }

        [JsonProperty("guildEmblemObject")]
        public string GuildEmblemObject { get; set; }

        [JsonProperty("GrantAccess")]
        public bool GrantAccess { get; set; }

        [JsonProperty("faction")]
        public Faction Faction { get; set; }

        [JsonProperty("guildMembersCount")]
        public int MembersCount { get; set; }
    }
}