using Newtonsoft.Json;
using System;
using TauriApiWrapper.Converters;

namespace TauriApiWrapper.Objects.Responses.Achievement
{
    public sealed class CharacterAchievementsLoaderAchievement
    {
        [JsonProperty("date"), JsonConverter(typeof(UnixDateConverter))]
        public DateTime Date { get; set; }

        [JsonProperty("catid")]
        public int Catid { get; set; }
    }
}