using Newtonsoft.Json;
using System;
using TauriApiWrapper.Converters;

namespace TauriApiWrapper.Objects.Responses.Arena
{
    public sealed class ArenaGame : BaseApiResponse
    {
        [JsonProperty("matchid")]
        public int MatchID { get; set; }

        [JsonProperty("mapid")]
        public int MapID { get; set; }

        [JsonProperty("mapname")]
        public string MapName { get; set; }

        [JsonProperty("winner")]
        public long Winner { get; set; }

        [JsonProperty("bgtype")]
        public int BgType { get; set; }

        [JsonProperty("isranked")]
        public bool IsTanked { get; set; }

        [JsonProperty("losermmravg")]
        public int LoserMmrAvg { get; set; }

        [JsonProperty("winnermmravg")]
        public int WinnerMmrAvg { get; set; }

        [JsonProperty("loserpersonalavg")]
        public int LoserPersonalAvg { get; set; }

        [JsonProperty("winnerpersonalavg")]
        public int WinnerPersonalAvg { get; set; }

        [JsonProperty("starttime"), JsonConverter(typeof(UnixDateConverter))]
        public DateTime StartTime { get; set; }

        [JsonProperty("length"), JsonConverter(typeof(TimeSpanMillisecondsConverter))]
        public TimeSpan Duration { get; set; }

        [JsonProperty("side0")]
        public int Side0 { get; set; }

        [JsonProperty("side1")]
        public int Side1 { get; set; }

        [JsonProperty("playerSide")]
        public int PlayerSide { get; set; }

        [JsonProperty("matchMembers")]
        public ArenaGameMatchMembers MatchMembers { get; set; }
    }
}
