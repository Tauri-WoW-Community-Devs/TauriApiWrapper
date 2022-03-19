using Newtonsoft.Json;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Responses.Character
{
    public sealed class CharacterReputationStandings
    {
        [JsonProperty("rank")]
        public ReputationRank Rank { get; set; }

        [JsonProperty("rank_name")]
        public string RankName { get; set; }

        [JsonProperty("rep")]
        public long CurrentReputation { get; set; }

        [JsonProperty("max")]
        public long MaxReputation { get; set; }

        [JsonProperty("percent")]
        public double Percent { get; set; }
    }
}