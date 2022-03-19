using Newtonsoft.Json;
using TauriApiWrapper.Enums;
using TauriApiWrapper.Extensions;

namespace TauriApiWrapper.Objects.Requests
{
    internal class AuctionHouseBaseRequest : IApiParam
    {
        private Realm _realm;

        public AuctionHouseBaseRequest(Realm realm) => _realm = realm;

        [JsonProperty("r")]
        public string RealmName => _realm.ToName();
    }
}