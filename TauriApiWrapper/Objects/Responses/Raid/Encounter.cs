using Newtonsoft.Json;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Responses.Raid
{
    public sealed class Encounter
    {
        [JsonProperty("encounter_id")]
        public int EncounterID { get; set; }

        [JsonProperty("encounter_map")]
        public int EncounterMap { get; set; }

        [JsonProperty("encounter_difficulty")]
        public RaidDifficulty EncounterDifficulty { get; set; }

        [JsonProperty("encounter_name")]
        public string EncounterName { get; set; }

        [JsonProperty("encounter_order")]
        public int EncounterOrder { get; set; }

        [JsonProperty("encounter_index")]
        public int EncounterIndex { get; set; }
    }
}