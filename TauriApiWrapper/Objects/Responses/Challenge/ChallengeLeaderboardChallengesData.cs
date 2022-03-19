using Newtonsoft.Json;
using System;
using TauriApiWrapper.Converters;
using TauriApiWrapper.Enums;
using TauriApiWrapper.Objects.Responses.Guild;

namespace TauriApiWrapper.Objects.Responses.Challenge
{
    public sealed class ChallengeLeaderboardChallengesData
    {
        [JsonProperty("completiontime"), JsonConverter(typeof(TimeSpanMillisecondsConverter))]
        public TimeSpan CompletionTime { get; set; }

        [JsonProperty("completedtime"), JsonConverter(typeof(UnixDateConverter))]
        public DateTime CompletedTime { get; set; }

        [JsonProperty("medal")]
        public Medal Medal { get; set; }

        [JsonProperty("playerrank")]
        public int PlayerRank { get; set; }

        [JsonProperty("guildrank")]
        public int GuildRank { get; set; }

        [JsonProperty("players")]
        public ChallengePlayer[] Players { get; set; }

        [JsonProperty("guildinfo")]
        public GuildData GuildTnfo { get; set; }
    }
}