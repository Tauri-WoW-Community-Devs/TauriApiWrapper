using Newtonsoft.Json;

namespace TauriApiWrapper.Objects.Responses.Achievement
{
    public sealed class CharacterAchievementsInfo
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("pid")]
        public int Pid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }
    }
}