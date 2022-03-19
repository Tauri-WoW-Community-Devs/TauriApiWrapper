using Newtonsoft.Json;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Responses.AuctionHouse
{
    public sealed class SpeciesData
    {
        [JsonProperty("SpeciesID")]
        public long SpeciesID { get; set; }

        [JsonProperty("CreatureID")]
        public long CreatureID { get; set; }

        [JsonProperty("IconFileID")]
        public long IconFileID { get; set; }

        [JsonProperty("SummonSpellID")]
        public long SummonSpellID { get; set; }

        [JsonProperty("PetType")]
        public BattlePetType PetType { get; set; }
    }
}