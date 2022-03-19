using Newtonsoft.Json;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Requests
{
    internal sealed class AchievementsLoaderRequest : AchievementBaseRequest
    {
        public AchievementsLoaderRequest(string name, int id, Realm realm) : base(realm)
        {
            CharacterName = name;
            CategoryID = id;
        }

        [JsonProperty("n")]
        public string CharacterName { get; set; }

        [JsonProperty("c")]
        public int CategoryID { get; set; }
    }
}