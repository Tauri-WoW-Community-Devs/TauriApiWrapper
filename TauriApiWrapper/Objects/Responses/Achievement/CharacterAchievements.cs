using Newtonsoft.Json;
using System.Collections.Generic;
using TauriApiWrapper.Converters;
using TauriApiWrapper.Enums;
using TauriApiWrapper.Objects.Responses.Challenge;
using TauriApiWrapper.Objects.Responses.Character;

namespace TauriApiWrapper.Objects.Responses.Achievement
{
    public class CharacterAchievements : BaseApiResponse
    {
        [JsonProperty("pts")]
        public int AchievementPoints { get; set; }

        [JsonProperty("categories")]
        public Dictionary<string, CharacterAchievementsCategory> Categories { get; set; }

        [JsonProperty("SummaryAchievement")]
        public Dictionary<string, long> SummaryAchievement { get; set; }

        [JsonProperty("SummaryEarnAchievement")]
        public Dictionary<string, long> SummaryEarnAchievement { get; set; }

        [JsonProperty("AchievementsCache")]
        public Dictionary<string, CharacterAchievementsCache> AchievementsCache { get; set; }

        [JsonProperty("Achievements")]
        public Dictionary<string, CharacterAchievement> Achievements { get; set; }

        //not directly related to achievements
        [JsonProperty("realm"), JsonConverter(typeof(RealmNameConverter))]
        public Realm Realm { get; set; }

        [JsonProperty("class")]
        public Class Class { get; set; }

        [JsonProperty("race")]
        public Race Race { get; set; }

        [JsonProperty("gender")]
        public Gender Gender { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("level")]
        public int Level { get; set; }

        [JsonProperty("portrait_path")]
        public string PortraitPath { get; set; }

        [JsonProperty("faction_string_class")]
        public string FactionStringClass { get; set; }

        [JsonProperty("guildName")]
        public string GuildName { get; set; }

        [JsonProperty("arenaTeam2v2id")]
        public int ArenaTeam2v2ID { get; set; }

        [JsonProperty("arenaTeam3v3id")]
        public int ArenaTeam3v3ID { get; set; }

        [JsonProperty("arenaTeam5v5id")]
        public int ArenaTeam5v5ID { get; set; }

        [JsonProperty("dualSpec")]
        public bool DualSpec { get; set; }

        [JsonProperty("talents_builds_0")]
        public string TalentsBuilds0 { get; set; }

        [JsonProperty("treeName_0")]
        public string TreeName0 { get; set; }

        [JsonProperty("treeIcon_0")]
        public string TreeIcon0 { get; set; }

        [JsonProperty("ds_0")]
        public string[] Ds0 { get; set; }

        [JsonProperty("talents_builds_1")]
        public string TalentsBuilds1 { get; set; }

        [JsonProperty("treeName_1")]
        public string TreeName1 { get; set; }

        [JsonProperty("treeIcon_1")]
        public string TreeIcon1 { get; set; }

        [JsonProperty("ds_1")]
        public string[] Ds1 { get; set; }

        [JsonProperty("disabledDS_0")]
        public bool DisabledDs0 { get; set; }

        [JsonProperty("disabledDS_1")]
        public bool DisabledDs1 { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        //addonitial data not specified in Tauri API response
        [JsonProperty("guildLinkName")]
        public string GuildLinkName { get; set; }

        [JsonProperty("activeSpec")]
        public int ActiveSpec { get; set; }

        [JsonProperty("talents_0")]
        public string Talents0 { get; set; }

        [JsonProperty("talents_1")]
        public string Talents1 { get; set; }

        [JsonProperty("titleName")]
        public string TitleName { get; set; }

        [JsonProperty("urlName")]
        public string UrlName { get; set; }

        [JsonProperty("tname")]
        public string TName { get; set; }

        [JsonProperty("isBookmarked")]
        public bool IsBookmarked { get; set; }

        [JsonProperty("characterArenaTeamInfoButton")]
        public bool CharacterArenaTeamInfoButton { get; set; }

        [JsonProperty("character_url_string")]
        public string CharacterUrlString { get; set; }

        [JsonProperty("avgitemlevel")]
        public int AvgItemLevel { get; set; }

        [JsonProperty("skindata")]
        public SkinData Skindata { get; set; }

        [JsonProperty("challengemode")]
        public Dictionary<string, ChallengeLeaderboardChallengesData> Challengemode { get; set; }
    }
}