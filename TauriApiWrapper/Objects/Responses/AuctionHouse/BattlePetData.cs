using Newtonsoft.Json;
using TauriApiWrapper.Converters;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Responses.AuctionHouse
{
    public sealed class BattlePetData
    {
        [JsonProperty("speciesdata")]
        public SpeciesData Speciesdata { get; set; }

        [JsonProperty("pettype_name"), JsonConverter(typeof(BattlePetTypeConverter))]
        public BattlePetType BattlePetType { get; set; }

        [JsonProperty("breed")]
        public long Breed { get; set; }

        [JsonProperty("quality")]
        public long Quality { get; set; }

        [JsonProperty("quality_color")]
        public string QualityColor { get; set; }

        [JsonProperty("level")]
        public long Level { get; set; }

        [JsonProperty("creatureid")]
        public long CreatureID { get; set; }

        [JsonProperty("petname")]
        public string PetName { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("maxhealth")]
        public long MaxHealth { get; set; }

        [JsonProperty("power")]
        public long Power { get; set; }

        [JsonProperty("speed")]
        public long Speed { get; set; }
    }
}