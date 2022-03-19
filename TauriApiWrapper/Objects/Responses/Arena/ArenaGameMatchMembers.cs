using Newtonsoft.Json;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Responses.Arena
{
    public sealed class ArenaGameMatchMembers
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("guid")]
        public int Guid { get; set; }

        [JsonProperty("winner")]
        public int Winner { get; set; }

        [JsonProperty("killing_blows")]
        public int KillingBlows { get; set; }

        [JsonProperty("deaths")]
        public int Deaths { get; set; }

        [JsonProperty("damage_done")]
        public int DamageDone { get; set; }

        [JsonProperty("healing_done")]
        public int HealingDone { get; set; }

        [JsonProperty("damage_taken")]
        public int DamageTaken { get; set; }

        [JsonProperty("healing_taken")]
        public int HealingTaken { get; set; }

        [JsonProperty("realmName")]
        public Realm Realm { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("race")]
        public Race Race { get; set; }

        [JsonProperty("class")]
        public Class Class { get; set; }

        [JsonProperty("gender")]
        public Gender Gender { get; set; }

        [JsonProperty("teamname")]
        public string Teamname { get; set; }

        [JsonProperty("type")]
        public TeamType Type { get; set; }


    }
}
