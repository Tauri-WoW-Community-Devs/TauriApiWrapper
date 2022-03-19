using Newtonsoft.Json;

namespace TauriApiWrapper.Objects.Responses.Achievement
{
    public sealed class CharacterAchievementsLoaderCriteria
    {
        [JsonProperty("refAchievement")]
        public int RefAchievement { get; set; }

        [JsonProperty("reqType")]
        public int ReqType { get; set; }

        [JsonProperty("reqID")]
        public int ReqID { get; set; }

        [JsonProperty("reqCnt")]
        public int ReqCnt { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }
    }
}