using Newtonsoft.Json;

namespace TauriApiWrapper.Objects.Responses.Raid
{
    public sealed class MapInfo : MapEntry
    {
        [JsonProperty("available_difficulties")]
        public AvailableDifficulty[] AvailableDifficulties { get; set; }

        [JsonProperty("encounters")]
        public Encounter[] Encounters { get; set; }
    }
}