using Newtonsoft.Json;

namespace TauriApiWrapper.Objects.Responses.AuctionHouse
{
    public sealed class AuctionHouseResponse : AuctionHouseInfoResponse
    {
        [JsonProperty("auctions")]
        public Auctions Auctions { get; set; }
    }
}