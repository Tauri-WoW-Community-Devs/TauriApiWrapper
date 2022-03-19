using Newtonsoft.Json;

namespace TauriApiWrapper.Objects.Responses.Character
{
    public sealed class Player
    {
        [JsonProperty("specializationid", NullValueHandling = NullValueHandling.Ignore)]
        public int SpecializationID { get; set; }

        [JsonProperty("specializationrole", NullValueHandling = NullValueHandling.Ignore)]
        public int SpecializationRole { get; set; }

        [JsonProperty("specializationname", NullValueHandling = NullValueHandling.Ignore)]
        public string SpecializationName { get; set; }

        [JsonProperty("specializationicon", NullValueHandling = NullValueHandling.Ignore)]
        public string SpecializationIcon { get; set; }

        [JsonProperty("playerinfo", NullValueHandling = NullValueHandling.Ignore)]
        public CharacterData PlayerInfo { get; set; }
    }
}