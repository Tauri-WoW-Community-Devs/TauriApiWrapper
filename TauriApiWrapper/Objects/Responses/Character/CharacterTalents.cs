using Newtonsoft.Json;
using System.Collections.Generic;
using TauriApiWrapper.Enums;
using TauriApiWrapper.Objects.Responses.Dungeon;
using TauriApiWrapper.Objects.Responses.Item;

namespace TauriApiWrapper.Objects.Responses.Character
{
    public sealed class CharacterTalents : CharacterData
    {
        [JsonProperty("guid")]
        public long Guid { get; set; }

        [JsonProperty("name")]
        public new string Name { get; set; }

        [JsonProperty("titleName")]
        public string TitleName { get; set; }

        [JsonProperty("urlName")]
        public string UrlName { get; set; }

        [JsonProperty("portrait_path")]
        public string PortraitPath { get; set; }

        [JsonProperty("pts")]
        public long AchievmentPoints { get; set; }

        [JsonProperty("faction_string_class")]
        public Faction FactionStringClass { get; set; }

        [JsonProperty("guildLinkName")]
        public string GuildLinkName { get; set; }

        [JsonProperty("arenaTeam2v2id")]
        public long ArenaTeam2V2ID { get; set; }

        [JsonProperty("arenaTeam3v3id")]
        public long ArenaTeam3V3ID { get; set; }

        [JsonProperty("arenaTeam5v5id")]
        public long ArenaTeam5V5ID { get; set; }

        [JsonProperty("dualSpec")]
        public bool DualSpec { get; set; }

        [JsonProperty("activeSpec")]
        public long ActiveSpec { get; set; }

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
        public long PlayerHonorKills { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("isBookmarked")]
        public bool IsBookmarked { get; set; }

        [JsonProperty("characterArenaTeamInfoButton")]
        public bool CharacterArenaTeamInfoButton { get; set; }

        [JsonProperty("character_url_string")]
        public string CharacterUrlString { get; set; }

        [JsonProperty("avgitemlevel")]
        public long AvgItemlevel { get; set; }

        [JsonProperty("skindata")]
        public SkinData SkinData { get; set; }

        [JsonProperty("challengemode")]
        public Dictionary<string, ChallengeMode> ChallengeMode { get; set; }

        [JsonProperty("Glyphs_0")]
        public Glyph[] Glyphs0 { get; set; }

        [JsonProperty("Glyphs_1")]
        public Glyph[] Glyphs1 { get; set; }

        [JsonProperty("talents")]
        public string Talents { get; set; }

        [JsonProperty("talentsFileName")]
        public string TalentsFileName { get; set; }
    }
}