using Newtonsoft.Json;

namespace TauriApiWrapper.Objects.Responses.Achievement
{
    public sealed class CharacterAchievementsCache
    {
        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("desc")]
        public string Desc { get; set; }

        [JsonProperty("pts")]
        public int Pts { get; set; }

        [JsonProperty("reward")]
        public string Reward { get; set; }
    }
}