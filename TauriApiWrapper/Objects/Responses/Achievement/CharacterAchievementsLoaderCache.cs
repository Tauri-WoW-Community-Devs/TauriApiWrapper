using Newtonsoft.Json;
using System.Collections.Generic;

namespace TauriApiWrapper.Objects.Responses.Achievement
{
    public sealed class CharacterAchievementsLoaderCache
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("pid")]
        public int Pid { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("desc")]
        public string Desc { get; set; }

        [JsonProperty("pts")]
        public int AchievementPoints { get; set; }

        [JsonProperty("reward")]
        public string Reward { get; set; }

        [JsonProperty("catid")]
        public int CatID { get; set; }

        [JsonProperty("criteria")]
        public Dictionary<string, CharacterAchievementsLoaderCriteria> Criteria { get; set; }
    }
}