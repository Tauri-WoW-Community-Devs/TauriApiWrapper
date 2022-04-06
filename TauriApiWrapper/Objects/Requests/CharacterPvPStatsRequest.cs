using Newtonsoft.Json;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Requests
{
    internal class CharacterPvPStatsRequest : ArenaBaseRequest
    {
        [JsonProperty("n")]
        public string Name { get; set; }

        public CharacterPvPStatsRequest(Realm realm) : base(realm)
        {
        }

        public CharacterPvPStatsRequest(Realm realm, string characterName) : this(realm)
        {
            Name = characterName;
        }


    }
}
