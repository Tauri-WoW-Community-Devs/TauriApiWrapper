using Newtonsoft.Json;
using TauriApiWrapper.Objects.Responses.Character;
using TauriApiWrapper.Objects.Responses.Guild;

namespace TauriApiWrapper.Objects.Responses.Dungeon
{
    public sealed class ChallengeMode
    {
        [JsonProperty("completiontime", NullValueHandling = NullValueHandling.Ignore)]
        public int? CompletionTime { get; set; }

        [JsonProperty("completedtime", NullValueHandling = NullValueHandling.Ignore)]
        public int? CompletedTime { get; set; }

        [JsonProperty("medal", NullValueHandling = NullValueHandling.Ignore)]
        public int? Medal { get; set; }

        [JsonProperty("playerrank", NullValueHandling = NullValueHandling.Ignore)]
        public int? PlayerRank { get; set; }

        [JsonProperty("guildrank", NullValueHandling = NullValueHandling.Ignore)]
        public int? GuildRank { get; set; }

        [JsonProperty("players", NullValueHandling = NullValueHandling.Ignore)]
        public Player[] Players { get; set; }

        [JsonProperty("guildinfo", NullValueHandling = NullValueHandling.Ignore)]
        public GuildInfo GuildInfo { get; set; }
    }
}