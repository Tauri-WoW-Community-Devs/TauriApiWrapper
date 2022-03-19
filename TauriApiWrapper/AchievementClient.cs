using System.Threading.Tasks;
using TauriApiWrapper.Enums;
using TauriApiWrapper.Objects;
using TauriApiWrapper.Objects.Requests;
using TauriApiWrapper.Objects.Responses.Achievement;

namespace TauriApiWrapper
{
    public static class AchievementClient
    {
        private class Endpoints
        {
            public const string AchievementFirsts = "achievement-firsts";
            public const string CharacterAchievements = "character-achievements";
            public const string AchievementsLoader = "achievements-loader";
        }

        #region Sync

        public static ApiResponse<AchievementFirst> GetAchievementFirsts(TauriClient client, Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.AchievementFirsts, client.ApiSecret, new AchievementBaseRequest(realm));
            return client.Communicate<AchievementFirst>(param);
        }

        public static ApiResponse<CharacterAchievements> GetCharacterAchievements(TauriClient client, string characterName, Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.CharacterAchievements, client.ApiSecret, new CharacterAchievementsRequest(characterName, realm));
            return client.Communicate<CharacterAchievements>(param);
        }

        public static ApiResponse<CharacterAchievementsLoader> GetCharacterAchievementsLoader(TauriClient client, string characterName, int categoryID, Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.AchievementsLoader, client.ApiSecret, new AchievementsLoaderRequest(characterName, categoryID, realm));
            return client.Communicate<CharacterAchievementsLoader>(param);
        }

        #endregion Sync

        #region Async

        public static async Task<ApiResponse<AchievementFirst>> GetAchievementFirstsAsync(TauriClient client, Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.AchievementFirsts, client.ApiSecret, new AchievementBaseRequest(realm));
            return await client.CommunicateAsync<AchievementFirst>(param);
        }

        public static async Task<ApiResponse<CharacterAchievements>> GetCharacterAchievementsAsync(TauriClient client, string characterName, Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.CharacterAchievements, client.ApiSecret, new CharacterAchievementsRequest(characterName, realm));
            return await client.CommunicateAsync<CharacterAchievements>(param);
        }

        public static async Task<ApiResponse<CharacterAchievementsLoader>> GetCharacterAchievementsLoaderAsync(TauriClient client, string characterName, int categoryID, Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.AchievementsLoader, client.ApiSecret, new AchievementsLoaderRequest(characterName, categoryID, realm));
            return await client.CommunicateAsync<CharacterAchievementsLoader>(param);
        }

        #endregion Async
    }
}