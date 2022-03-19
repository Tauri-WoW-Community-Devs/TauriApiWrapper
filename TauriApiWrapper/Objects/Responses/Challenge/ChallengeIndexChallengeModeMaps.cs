using Newtonsoft.Json;
using System;
using TauriApiWrapper.Converters;

namespace TauriApiWrapper.Objects.Responses.Challenge
{
    public sealed class ChallengeIndexChallengeModeMaps
    {
        [JsonProperty("challengeid")]
        public int ChallengeID { get; set; }

        [JsonProperty("challengemapid")]
        public int ChallengeMapID { get; set; }

        [JsonProperty("challengemapname")]
        public string ChallengeMapName { get; set; }

        [JsonProperty("goldmedaltime"), JsonConverter(typeof(TimeSpanSecondsConverter))]
        public TimeSpan GoldMedalTime { get; set; }

        [JsonProperty("silvermedaltime"), JsonConverter(typeof(TimeSpanSecondsConverter))]
        public TimeSpan SilverMedalTime { get; set; }

        [JsonProperty("bronzemedaltime"), JsonConverter(typeof(TimeSpanSecondsConverter))]
        public TimeSpan BronzeMedalTime { get; set; }
    }
}