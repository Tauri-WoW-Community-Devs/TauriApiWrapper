using Newtonsoft.Json;
using System;
using TauriApiWrapper.Converters;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Responses.Achievement
{
    /// <summary>
    /// Including the achivements with the characters who first made it
    /// </summary>
    public sealed class AchievementData
    {
        /// <summary>
        /// The full name of the realm
        /// </summary>
        [JsonProperty("charname")]
        public string Name { get; set; }

        /// <summary>
        /// Race of the Character
        /// </summary>
        [JsonProperty("race")]
        public Race Race { get; set; }

        /// <summary>
        /// Class of the Character
        /// </summary>
        [JsonProperty("class")]
        public Class Class { get; set; }

        /// <summary>
        /// Gender of the Character
        /// </summary>
        [JsonProperty("gender")]
        public Gender Gender { get; set; }

        /// <summary>
        /// Guild name of the character
        /// </summary>
        [JsonProperty("guildname")]
        public string GuildName { get; set; }

        /// <summary>
        /// Name of the Achievement
        /// </summary>
        [JsonProperty("name")]
        public string AchievementName { get; set; }

        /// <summary>
        /// Description of the Achievement
        /// </summary>
        [JsonProperty("description")]
        public string AchievementDescription { get; set; }

        [JsonProperty("point")]
        public int AchievementPoint { get; set; }

        /// <summary>
        /// Point reward of the Achievement
        /// </summary>
        [JsonProperty("reward")]
        public string AchievementReward { get; set; }

        /// <summary>
        /// Achievement Date
        /// </summary>
        [JsonProperty("timestamp"), JsonConverter(typeof(UnixDateConverter))]
        public DateTime AchievementTimestamp { get; set; }
    }
}