using Newtonsoft.Json;

namespace TauriApiWrapper.Objects.Responses.AuctionHouse
{
    public sealed class BattlePet
    {
        [JsonProperty("battlepetdata")]
        public BattlePetData BattlePetData { get; set; }
    }
}