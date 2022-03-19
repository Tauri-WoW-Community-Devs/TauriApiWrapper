using System.Threading.Tasks;
using TauriApiWrapper.Enums;
using TauriApiWrapper.Objects;
using TauriApiWrapper.Objects.Requests;
using TauriApiWrapper.Objects.Responses.Challenge;

namespace TauriApiWrapper
{
    public static class ChallengeModeClient
    {
        private class Endpoints
        {
            public const string ChallengeIndex = "challenge-index";
            public const string ChallengeLeaderboard = "challenge-leaderboard";
            public const string CaallengeLeaderboardGuild = "challenge-leaderboard-guild"; // same as the ChallengeLeaderboard
        }


        #region Sync

        public static ApiResponse<ChallengeIndex> GetChallengeIndex(TauriClient client, Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.ChallengeIndex, client.ApiSecret, new ChallengeModeBaseRequest(realm));
            return client.Communicate<ChallengeIndex>(param);
        }

        public static ApiResponse<ChallengeLeaderboard> GetChallengeLeaderboard(TauriClient client, int mapID, Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.ChallengeLeaderboard, client.ApiSecret, new ChallengeModeLeaderboardRequest(mapID, realm));
            return client.Communicate<ChallengeLeaderboard>(param);
        }

        #endregion Sync

        #region Async

        public static async Task<ApiResponse<ChallengeIndex>> GetChallengeIndexAsync(TauriClient client, Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.ChallengeIndex, client.ApiSecret, new ChallengeModeBaseRequest(realm));
            return await client.CommunicateAsync<ChallengeIndex>(param);
        }

        public static async Task<ApiResponse<ChallengeLeaderboard>> GetChallengeLeaderboardAsync(TauriClient client, int mapID, Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.ChallengeLeaderboard, client.ApiSecret, new ChallengeModeLeaderboardRequest(mapID, realm));
            return await client.CommunicateAsync<ChallengeLeaderboard>(param);
        }

        #endregion Async
    }
}