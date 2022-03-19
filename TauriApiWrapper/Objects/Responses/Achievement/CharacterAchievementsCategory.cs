using Newtonsoft.Json;
using System.Collections.Generic;

namespace TauriApiWrapper.Objects.Responses.Achievement
{
    public sealed class CharacterAchievementsCategory
    {
        [JsonProperty("info")]
        public CharacterAchievementsInfo Info { get; set; }

        [JsonProperty("subcat", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, CharacterAchievementsInfo> Subcat { get; set; }
    }
}