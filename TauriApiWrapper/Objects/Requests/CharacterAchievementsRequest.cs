using Newtonsoft.Json;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Requests
{
    internal sealed class CharacterAchievementsRequest : AchievementBaseRequest
    {
        public CharacterAchievementsRequest(string name, Realm realm) : base(realm)
        {
            CharacterName = name;
        }

        [JsonProperty("cn")]
        public string CharacterName { get; set; }
    }
}