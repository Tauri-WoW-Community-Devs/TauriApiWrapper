using Newtonsoft.Json;
using TauriApiWrapper.Enums;

namespace TauriApiWrapper.Objects.Responses.Arena
{
    public sealed class ArenaGame : BaseApiResponse
    {
        [JsonProperty("matchStart")]
        public int MatchStart { get; set; }

        [JsonProperty("matchLength")]
        public int MatchLength { get; set; }

        [JsonProperty("mapName")]
        public string MapName { get; set; }

        [JsonProperty("realm")]
        public Realm Realm { get; set; }

        [JsonProperty("winnerTeam")]
        public string WinnerTeam { get; set; }

        [JsonProperty("winnerRating")]
        public int WinnerRating { get; set; }

        [JsonProperty("winnerNetRating")]
        public int WinnerNetRating { get; set; }

        [JsonProperty("looserTeam")]
        public string LooserTeam { get; set; }

        [JsonProperty("looserRating")]
        public int LooserRating { get; set; }

        [JsonProperty("looserNetRating")]
        public int LooserNetRating { get; set; }

        [JsonProperty("matchMembers")]
        public ArenaGameMatchMembers MatchMembers { get; set; }
    }
}
