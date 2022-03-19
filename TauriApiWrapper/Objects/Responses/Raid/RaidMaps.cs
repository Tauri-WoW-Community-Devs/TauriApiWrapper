using Newtonsoft.Json;

namespace TauriApiWrapper.Objects.Responses.Raid
{
    public class RaidMaps
    {
        [JsonProperty("map_exp_0")]
        public MapInfo[] ClassicRaids { get; set; }

        [JsonProperty("map_exp_1")]
        public MapInfo[] BurningCrusadeRaids { get; set; }

        [JsonProperty("map_exp_2")]
        public MapInfo[] WrathOfTheLichKingRaids { get; set; }

        [JsonProperty("map_exp_3")]
        public MapInfo[] CataclysmRaids { get; set; }

        [JsonProperty("map_exp_4")]
        public MapInfo[] MistsOfPandariaRaids { get; set; }
    }
}