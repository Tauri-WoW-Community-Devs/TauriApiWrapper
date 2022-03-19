using Newtonsoft.Json;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Responses.Challenge
{
    public sealed class ChallengePlayer
    {
        [JsonProperty("specializationid")]
        public int SpecializationID { get; set; }

        [JsonProperty("specializationrole")]
        public SpecializationRole SpecializationRole { get; set; }

        [JsonProperty("specializationname")]
        public string SpecializationName { get; set; }

        [JsonProperty("specializationicon")]
        public string SpecializationIcon { get; set; }

        [JsonProperty("playerinfo")]
        public ChallengePlayerInfo PlayerInfo { get; set; }
    }
}