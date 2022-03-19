using Newtonsoft.Json;
using TauriApiWrapper.Enums;
using TauriApiWrapper.Extensions;

namespace TauriApiWrapper.Objects.Requests
{
    internal class ChallengeModeBaseRequest : IApiParam
    {
        private Realm _realm;

        public ChallengeModeBaseRequest(Realm realm)
        {
            _realm = realm;
        }

        [JsonProperty("r")]
        public string RealmName => _realm.ToName();
    }
}