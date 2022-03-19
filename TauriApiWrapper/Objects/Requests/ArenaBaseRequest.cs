using Newtonsoft.Json;
using TauriApiWrapper.Enums;
using TauriApiWrapper.Extensions;

namespace TauriApiWrapper.Objects.Requests
{
    internal class ArenaBaseRequest : IApiParam
    {
        private Realm _realm;

        public ArenaBaseRequest(Realm realm)
        {
            _realm = realm;
        }

        [JsonProperty("r")]
        public string RealmName => _realm.ToName();
    }
}