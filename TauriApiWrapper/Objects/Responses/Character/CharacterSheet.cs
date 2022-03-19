using Newtonsoft.Json;
using System.Collections.Generic;
using TauriApiWrapper.Converters;
using TauriApiWrapper.Enums;
using TauriApiWrapper.Objects.Responses.Dungeon;

namespace TauriApiWrapper.Objects.Responses.Character
{
    public sealed class CharacterSheet : CharacterData
    {
        [JsonProperty("name")]
        public new string Name { get; set; }

        [JsonProperty("realm"), JsonConverter(typeof(RealmNameConverter))]
        public Realm Realm { get; set; }

        [JsonProperty("guid")]
        public int Guid { get; set; }

        //[JsonProperty("name")]
        //public new string Name { get; set; }

        [JsonProperty("titleName")]
        public string TitleName { get; set; }

        [JsonProperty("urlName")]
        public string UrlName { get; set; }

        [JsonProperty("portrait_path")]
        public string PortraitPath { get; set; }

        [JsonProperty("pts")]
        public int AchievementPoints { get; set; }

        [JsonProperty("faction_string_class"), JsonConverter(typeof(FactionConverter))]
        public new Faction Faction { get; set; }

        [JsonProperty("guildLinkName")]
        public string GuildLinkName { get; set; }

        [JsonProperty("arenaTeam2v2id")]
        public int ArenaTeam2V2ID { get; set; }

        [JsonProperty("arenaTeam3v3id")]
        public int ArenaTeam3V3ID { get; set; }

        [JsonProperty("arenaTeam5v5id")]
        public int ArenaTeam5V5ID { get; set; }

        [JsonProperty("dualSpec")]
        public bool DualSpec { get; set; }

        [JsonProperty("activeSpec")]
        public int ActiveSpec { get; set; }

        [JsonProperty("talents_builds_0")]
        public string TalentsBuilds0 { get; set; }

        [JsonProperty("treeName_0")]
        public string TreeName0 { get; set; }

        [JsonProperty("treeIcon_0")]
        public string TreeIcon0 { get; set; }

        [JsonProperty("talents_0")]
        public string Talents0 { get; set; }

        [JsonProperty("ds_0")]
        public string[] Ds0 { get; set; }

        [JsonProperty("talents_builds_1")]
        public string TalentsBuilds1 { get; set; }

        [JsonProperty("treeName_1")]
        public string TreeName1 { get; set; }

        [JsonProperty("treeIcon_1")]
        public string TreeIcon1 { get; set; }

        [JsonProperty("talents_1")]
        public string Talents1 { get; set; }

        [JsonProperty("ds_1")]
        public string[] Ds1 { get; set; }

        [JsonProperty("disabledDS_1")]
        public bool DisabledDs1 { get; set; }

        [JsonProperty("playerHonorKills")]
        public int PlayerHonorKills { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("tname")]
        public string NameWithTitle { get; set; }

        [JsonProperty("isBookmarked")]
        public bool IsBookmarked { get; set; }

        [JsonProperty("characterArenaTeamInfoButton")]
        public bool CharacterArenaTeamInfoButton { get; set; }

        [JsonProperty("character_url_string")]
        public string CharacterUrlString { get; set; }

        [JsonProperty("avgitemlevel")]
        public int AvgItemLevel { get; set; }

        [JsonProperty("skindata")]
        public SkinData SkinData { get; set; }

        [JsonProperty("challengemode")]
        public Dictionary<string, ChallengeMode> ChallengeMode { get; set; }

        [JsonProperty("healthValue")]
        public int HealthValue { get; set; }

        [JsonProperty("additionalBarInfo")]
        public AdditionalBarInfo AdditionalBarInfo { get; set; }

        [JsonProperty("characterStat")]
        public Dictionary<string, double> CharacterStat { get; set; }

        [JsonProperty("characterItems")]
        public CharacterItem[] CharacterItems { get; set; }

        [JsonProperty("primary_trade_skill_1")]
        public PrimaryTradeSkill PrimaryTradeSkill1 { get; set; }

        [JsonProperty("primary_trade_skill_2")]
        public PrimaryTradeSkill PrimaryTradeSkill2 { get; set; }

        [JsonProperty("characterArenaTeamInfo")]
        public Dictionary<string, CharacterArenaTeamInfo> CharacterArenaTeamInfo { get; set; }

        [JsonProperty("characterFeed")]
        public CharacterFeed[] CharacterFeed { get; set; }
    }
}