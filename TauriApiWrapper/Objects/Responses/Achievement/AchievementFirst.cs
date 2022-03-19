using Newtonsoft.Json;
using System.Collections.Generic;
using TauriApiWrapper.Converters;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Responses.Achievement
{
    /// <summary>
    /// The Achievement API allows you to fetch data about achievement firsts on each realm, and achievement of a character.
    /// </summary>
    public class AchievementFirst : BaseApiResponse
    {
        [JsonProperty("achievementFirsts")]
        public Dictionary<string, AchievementData[]> AchievementFirstArray { get; set; }

        [JsonProperty("realmName"), JsonConverter(typeof(RealmNameConverter))]
        public Realm Realm { get; set; }
    }
}