using Newtonsoft.Json;

namespace TauriApiWrapper.Objects.Responses.Character
{
    public sealed class CharacterFeedList
    {
        [JsonProperty("characterFeed")]
        public CharacterFeed[] Events { get; set; }
    }
}
