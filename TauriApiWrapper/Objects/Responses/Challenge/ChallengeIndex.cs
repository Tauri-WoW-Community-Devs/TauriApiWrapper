using Newtonsoft.Json;
using System.Collections.Generic;
using TauriApiWrapper.Converters;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Responses.Challenge
{
    public class ChallengeIndex : BaseApiResponse
    {
        [JsonProperty("realm"), JsonConverter(typeof(RealmNameConverter))]
        public Realm Realm { get; set; }

        [JsonProperty("challengemodemaps")]
        public Dictionary<string, ChallengeIndexChallengeModeMaps> ChallengeModeMaps { get; set; }
    }
}