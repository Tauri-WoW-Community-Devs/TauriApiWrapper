using Newtonsoft.Json;
using System.Collections.Generic;
using TauriApiWrapper.Objects.Responses.Item;

namespace TauriApiWrapper.Objects.Responses.AuctionHouse
{
    public class BlackMarketResponse : BaseApiResponse
    {
        [JsonProperty("auctions")]
        public List<ItemResponse> Auctions { get; set; }
    }
}