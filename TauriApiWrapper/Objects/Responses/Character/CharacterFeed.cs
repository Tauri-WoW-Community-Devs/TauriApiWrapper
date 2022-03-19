using Newtonsoft.Json;
using System;
using TauriApiWrapper.Converters;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Responses.Character
{
    public sealed class CharacterFeed
    {
        [JsonProperty("type")]
        public CharacterFeedType Type { get; set; }

        [JsonProperty("data")]
        public int Data { get; set; }

        [JsonProperty("date"), JsonConverter(typeof(UnixDateConverter))]
        public DateTime Date { get; set; }

        [JsonProperty("counter")]
        public int Counter { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("Quality", NullValueHandling = NullValueHandling.Ignore)]
        public int? Quality { get; set; }

        [JsonProperty("icon", NullValueHandling = NullValueHandling.Ignore)]
        public string Icon { get; set; }

        [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
        public string Location { get; set; }

        [JsonProperty("desc", NullValueHandling = NullValueHandling.Ignore)]
        public string Desc { get; set; }

        [JsonProperty("point", NullValueHandling = NullValueHandling.Ignore)]
        public int? Point { get; set; }

        [JsonProperty("reward", NullValueHandling = NullValueHandling.Ignore)]
        public string Reward { get; set; }
    }
}