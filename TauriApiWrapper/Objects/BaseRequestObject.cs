using Newtonsoft.Json;
using TauriApiWrapper.Enums;
using TauriApiWrapper.Extensions;

namespace TauriApiWrapper.Objects
{
    internal abstract class BaseRequestObject : IApiParam
    {
        private readonly Realm _realm;

        public BaseRequestObject(Realm realm)
        {
            _realm = realm;
        }

        [JsonProperty("r")]
        public string RealmName => _realm.ToName();
    }
}