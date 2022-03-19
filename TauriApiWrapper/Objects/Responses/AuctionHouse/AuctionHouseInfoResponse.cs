using Newtonsoft.Json;
using System;
using TauriApiWrapper.Converters;

namespace TauriApiWrapper.Objects.Responses.AuctionHouse
{
    public class AuctionHouseInfoResponse : BaseApiResponse
    {
        [JsonProperty("lastModified"), JsonConverter(typeof(UnixDateConverter))]
        public DateTime LastModified { get; set; }
    }
}