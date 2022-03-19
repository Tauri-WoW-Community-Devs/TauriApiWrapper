using Newtonsoft.Json;
using System.Collections.Generic;
using TauriApiWrapper.Converters;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Responses.Achievement
{
    public class CharacterAchievementsLoader : BaseApiResponse
    {
        [JsonProperty("realm"), JsonConverter(typeof(RealmNameConverter))]
        public Realm Realm { get; set; }

        [JsonProperty("AchievementsCache")]
        public Dictionary<string, CharacterAchievementsLoaderCache> AchievementsCache { get; set; }

        [JsonProperty("Achievements")]
        public Dictionary<string, CharacterAchievementsLoaderAchievement> Achievements { get; set; }
    }
}