using Newtonsoft.Json;
using TauriApiWrapper.Converters;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Responses.Challenge
{
    public sealed class ChallengeLeaderboard : BaseApiResponse
    {
        [JsonProperty("realm"), JsonConverter(typeof(RealmNameConverter))]
        public Realm Realm { get; set; }

        [JsonProperty("mapdata")]
        public ChallengeIndexChallengeModeMaps MapData { get; set; }

        [JsonProperty("challengesdata")]
        public ChallengeLeaderboardChallengesData[] ChallengesData { get; set; }
    }
}