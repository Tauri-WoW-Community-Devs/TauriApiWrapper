using System.Threading.Tasks;
using TauriApiWrapper.Enums;
using TauriApiWrapper.Objects;
using TauriApiWrapper.Objects.Requests;
using TauriApiWrapper.Objects.Responses.Character;

namespace TauriApiWrapper
{
    public static class CharacterClient
    {
        private class Endpoints
        {
            public const string SheetUrl = "character-sheet";
            public const string Talents = "character-talents";
            public const string Reputation = "character-reputation";
            public const string Feed = "character-feed";
            public const string Mounts = "character-mounts";
        }

        #region Sync
        public static ApiResponse<CharacterSheet> GetCharacterSheet(TauriClient client, string characterName, Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.SheetUrl, client.ApiSecret, new CharacterRequest(characterName, realm));
            return client.Communicate<CharacterSheet>(param);
        }

        public static ApiResponse<CharacterTalents> GetCharacterTalents(TauriClient client, string characterName, Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.Talents, client.ApiSecret, new CharacterRequest(characterName, realm));
            return client.Communicate<CharacterTalents>(param);
        }

        public static ApiResponse<CharacterReputation> GetCharacterReputation(TauriClient client, string characterName, Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.Reputation, client.ApiSecret, new CharacterRequest(characterName, realm));
            return client.Communicate<CharacterReputation>(param);
        }

        public static ApiResponse<CharacterMounts> GetCharacterMountsByName(TauriClient client, string characterName, Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.Mounts, client.ApiSecret, new CharacterRequest(characterName, realm));
            return client.Communicate<CharacterMounts>(param);
        }


        #endregion Sync

        #region Async

        public static async Task<ApiResponse<CharacterMounts>> GetCharacterMountsByNameAsync(TauriClient client, string characterName, Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.Mounts, client.ApiSecret, new CharacterRequest(characterName, realm));
            return await client.CommunicateAsync<CharacterMounts>(param);
        }

        public static async Task<ApiResponse<CharacterFeedList>> GetCharacterFeedByNameAsync(TauriClient client, string characterName, Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.Feed, client.ApiSecret, new CharacterRequest(characterName, realm));
            return await client.CommunicateAsync<CharacterFeedList>(param);
        }

        public static async Task<ApiResponse<CharacterSheet>> GetCharacterSheetAsync(TauriClient client, string characterName, Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.SheetUrl, client.ApiSecret, new CharacterRequest(characterName, realm));
            return await client.CommunicateAsync<CharacterSheet>(param);
        }

        public static async Task<ApiResponse<CharacterTalents>> GetCharacterTalentsAsync(TauriClient client, string characterName, Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.Talents, client.ApiSecret, new CharacterRequest(characterName, realm));
            return await client.CommunicateAsync<CharacterTalents>(param);
        }

        public static async Task<ApiResponse<CharacterReputation>> GetCharacterReputationAsync(TauriClient client, string characterName, Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.Reputation, client.ApiSecret, new CharacterRequest(characterName, realm));
            return await client.CommunicateAsync<CharacterReputation>(param);
        }

        #endregion Async
    }
}
