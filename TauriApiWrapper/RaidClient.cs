using System.Threading.Tasks;
using TauriApiWrapper.Enums;
using TauriApiWrapper.Objects;
using TauriApiWrapper.Objects.Requests;
using TauriApiWrapper.Objects.Responses.Raid;

namespace TauriApiWrapper
{
    public static class RaidClient
    {
        private class Endpoints
        {
            public const string RaidMaps = "raid-maps";
            public const string RaidLog = "raid-log";
            public const string LatestRaids = "raid-last";
            public const string RaidPlayer = "raid-player";
            public const string RaidGuild = "raid-guild";
            public const string RaidRankEcounter = "raid-rank-encounter";
            public const string RaidGuildRankEncounter = "raid-guildrank-encounter";
        }


        #region Sync

        public static ApiResponse<RaidMaps> GetRaidMaps(TauriClient client, Realm realm = Realm.Evermoon)
        {
            ApiParams param = new ApiParams(Endpoints.RaidMaps, client.ApiSecret, new RaidMapRequest(realm));
            return client.Communicate<RaidMaps>(param);
        }

        public static ApiResponse<RaidLogsResponse> GetLatestRaids(TauriClient client, Realm realm, int? mapID = null, long? fromID = null, int limit = 0)
        {
            ApiParams param = new ApiParams(Endpoints.LatestRaids, client.ApiSecret, new RaidListRequest(realm, mapID, fromID: fromID, limit: limit));
            return client.Communicate<RaidLogsResponse>(param);
        }

        public static ApiResponse<RaidLog> GetRaidLogFromID(TauriClient client, int fromID, Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.RaidLog, client.ApiSecret, new RaidLogRequest(fromID, realm));
            return client.Communicate<RaidLog>(param);
        }

        public static ApiResponse<RaidLogsResponse> GetRaidLogFromPlayerName(TauriClient client, string name, Realm realm, long? fromID = null, int limit = 0)
        {
            ApiParams param = new ApiParams(Endpoints.RaidPlayer, client.ApiSecret, new PlayerRaidLogRequest(name, realm, fromID: fromID, limit: limit));
            return client.Communicate<RaidLogsResponse>(param);
        }

        public static ApiResponse<RaidLogsResponse> GetRaidLogFromGuildName(TauriClient client, string name, Realm realm, long? fromID = null, int limit = 0)
        {
            ApiParams param = new ApiParams(Endpoints.RaidGuild, client.ApiSecret, new GuildRaidLogRequest(name, realm, fromID: fromID, limit: limit));
            return client.Communicate<RaidLogsResponse>(param);
        }

        public static ApiResponse<RaidEncounterRankingResponse> GetRaidEncounterRanking(TauriClient client, int encounter, RaidDifficulty difficulty, Realm realm, long? fromID = null, int limit = 0)
        {
            ApiParams param = new ApiParams(Endpoints.RaidRankEcounter, client.ApiSecret, new EncounterRankingRequest(encounter, difficulty, realm, fromID: fromID, limit: limit));
            return client.Communicate<RaidEncounterRankingResponse>(param);
        }

        public static ApiResponse<RaidEncounterRankingResponse> GetRaidGuildEncounterRanking(TauriClient client, int encounter, RaidDifficulty difficulty, Realm realm, long? fromID = null, int limit = 0)
        {
            ApiParams param = new ApiParams(Endpoints.RaidGuildRankEncounter, client.ApiSecret, new EncounterRankingRequest(encounter, difficulty, realm, fromID: fromID, limit: limit));
            return client.Communicate<RaidEncounterRankingResponse>(param);
        }

        #endregion Sync

        #region Async

        public static async Task<ApiResponse<RaidMaps>> GetRaidMapsAsync(TauriClient client, Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.RaidMaps, client.ApiSecret, new RaidMapRequest(realm));
            return await client.CommunicateAsync<RaidMaps>(param);
        }

        public static async Task<ApiResponse<RaidLogsResponse>> GetLatestRaidsAsync(TauriClient client, Realm realm,  int? mapID = null, long? fromID = null, int limit = 50)
        {
            ApiParams param = new ApiParams(Endpoints.LatestRaids, client.ApiSecret, new RaidListRequest(realm, mapID, fromID: fromID, limit: limit));
            return await client.CommunicateAsync<RaidLogsResponse>(param);
        }

        public static async Task<ApiResponse<RaidLog>> GetRaidLogFromIDAsync(TauriClient client, int fromID, Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.RaidLog, client.ApiSecret, new RaidLogRequest(fromID, realm));
            return await client.CommunicateAsync<RaidLog>(param);
        }

        public static async Task<ApiResponse<RaidLog>> GetRaidLogFromPlayerNameAsync(TauriClient client, string name, Realm realm, long? fromID = null, int limit = 0)
        {
            ApiParams param = new ApiParams(Endpoints.RaidPlayer, client.ApiSecret, new PlayerRaidLogRequest(name, realm, fromID: fromID, limit: limit));
            return await client.CommunicateAsync<RaidLog>(param);
        }

        public static async Task<ApiResponse<RaidLogsResponse>> GetRaidLogFromGuildNameAsync(TauriClient client, string name, Realm realm, long? fromID = null, int limit = 0)
        {
            ApiParams param = new ApiParams(Endpoints.RaidGuild, client.ApiSecret, new GuildRaidLogRequest(name, realm, fromID: fromID, limit: limit));
            return await client.CommunicateAsync<RaidLogsResponse>(param);
        }

        public static async Task<ApiResponse<RaidEncounterRankingResponse>> GetRaidEncounterRankingAsync(TauriClient client, int encounter, RaidDifficulty difficulty, Realm realm, long? fromID = null, int limit = 0)
        {
            ApiParams param = new ApiParams(Endpoints.RaidRankEcounter, client.ApiSecret, new EncounterRankingRequest(encounter, difficulty, realm, fromID: fromID, limit: limit));
            return await client.CommunicateAsync<RaidEncounterRankingResponse>(param);
        }

        public static async Task<ApiResponse<RaidEncounterRankingResponse>> GetRaidGuildEncounterRankingAsync(TauriClient client, int encounter, RaidDifficulty difficulty, Realm realm, long? fromID = null, int limit = 0)
        {
            ApiParams param = new ApiParams(Endpoints.RaidGuildRankEncounter, client.ApiSecret, new EncounterRankingRequest(encounter, difficulty, realm, fromID: fromID, limit: limit));
            return await client.CommunicateAsync<RaidEncounterRankingResponse>(param);
        }
        #endregion Async
    }
}