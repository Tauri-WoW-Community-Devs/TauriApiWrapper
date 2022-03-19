using Newtonsoft.Json;
using System;
using TauriApiWrapper.Converters;
using TauriApiWrapper.Enums;
using TauriApiWrapper.Objects.Responses.Guild;

namespace TauriApiWrapper.Objects.Responses.Raid
{
    public sealed class RaidLogRanking : BaseApiResponse
    {
        [JsonProperty("rank")]
        public int Rank { get; set; }

        [JsonProperty("pos")]
        public int Pos { get; set; }

        [JsonProperty("log_id")]
        public int LogID { get; set; }

        [JsonProperty("map_id")]
        public int MapID { get; set; }

        [JsonProperty("mapentry")]
        public Encounter Encounter { get; set; }

        [JsonProperty("difficulty")]
        public RaidDifficulty Difficulty { get; set; }

        [JsonProperty("rid")]
        public int RealmID { get; set; }

        [JsonProperty("guildid")]
        public int GuildID { get; set; }

        [JsonProperty("guildrid")]
        public int GuildRealmID { get; set; }

        [JsonProperty("guilddata")]
        public GuildData GuildData { get; set; }

        [JsonProperty("killtime"), JsonConverter(typeof(UnixDateConverter))]
        public DateTime KillDate { get; set; }

        [JsonProperty("wipes")]
        public int Wipes { get; set; }

        [JsonProperty("deahts_total")]
        public int DeathsTotal { get; set; }

        [JsonProperty("fight_time"), JsonConverter(typeof(TimeSpanMillisecondsConverter))]
        public TimeSpan FightTime { get; set; }

        [JsonProperty("deaths_fight")]
        public int Deaths { get; set; }

        [JsonProperty("resurrects_fight")]
        public int Resurrects { get; set; }

        [JsonProperty("encounter_id")]
        public int EncounterID { get; set; }

        [JsonProperty("encounter_data")]
        public Encounter EncounterData { get; set; }

        [JsonProperty("member_count")]
        public int MemberCount { get; set; }

        [JsonProperty("item_count")]
        public int ItemCount { get; set; }
    }
}