using System;
using System.Threading.Tasks;
using TauriApiWrapper.Enums;
using TauriApiWrapper.Extensions;
using TauriApiWrapper.Objects;
using TauriApiWrapper.Objects.Requests;
using TauriApiWrapper.Objects.Responses.Arena;

namespace TauriApiWrapper
{
    [Obsolete("Currently not implemented in tauri, probably deprecated by them")]
    public static class ArenaClient 
    {
        private class Endpoints
        {
            public const string ArenaLadder = "arena-ladder";
            public const string TeamInfo = "team-info";
            public const string ArenaTeamGameChart = "arena-team-game-chart";
            public const string ArenaTeamReportOpposingTeams = "arena-team-report-opposing-teams"; // currently unused even on Crystalsong
            public const string ArenaGame = "arena-game"; // obsolete, use pvp-match instead
            public const string CharacterArenaTeams = "character-arenateams";
            public const string CharacterPvPStat = "character-pvp-stat";
            public const string PvPMatch = "pvp-match";
        }

    
        #region Sync

        public static ApiResponse<ArenaLadder> GetArenaLadder(TauriClient client, int teamSize, Realm realm)
        {
            if (realm.GetRealmExpansion() > Expansion.Cataclysm)
                return new ApiResponse<ArenaLadder>() { CustomError = CustomError.InvalidRealm, ErrorMessage = TauriClient.InvalidExpansion };

            ApiParams param = new ApiParams(Endpoints.ArenaLadder, client.ApiSecret, new ArenaLadderRequest(teamSize, realm));
            return client.Communicate<ArenaLadder>(param);
        }

        public static ApiResponse<ArenaTeamInfo> GetArenaTeamInfo(TauriClient client, int teamSize, string teamName, Realm realm)
        {
            if (realm.GetRealmExpansion() > Expansion.Cataclysm)
                return new ApiResponse<ArenaTeamInfo>() { CustomError = CustomError.InvalidRealm, ErrorMessage = TauriClient.InvalidExpansion };

            ApiParams param = new ApiParams(Endpoints.TeamInfo, client.ApiSecret, new ArenaTeamRequest(teamSize, teamName, realm));
            return client.Communicate<ArenaTeamInfo>(param);
        }

        public static ApiResponse<ArenaTeamGameChart> GetArenaTeamGameChart(TauriClient client, int teamSize, string teamName, Realm realm)
        {
            if (realm.GetRealmExpansion() > Expansion.Cataclysm)
                return new ApiResponse<ArenaTeamGameChart>() { CustomError = CustomError.InvalidRealm, ErrorMessage = TauriClient.InvalidExpansion };

            ApiParams param = new ApiParams(Endpoints.ArenaTeamGameChart, client.ApiSecret, new ArenaTeamRequest(teamSize, teamName, realm));
            return client.Communicate<ArenaTeamGameChart>(param);
        }

        public static ApiResponse<ArenaTeamReportOpposingTeams> GetArenaTeamReportOpposingTeams(TauriClient client, int teamSize, string teamName, Realm realm)
        {
            if (realm.GetRealmExpansion() > Expansion.Cataclysm)
                return new ApiResponse<ArenaTeamReportOpposingTeams>() { CustomError = CustomError.InvalidRealm, ErrorMessage = TauriClient.InvalidExpansion };

            ApiParams param = new ApiParams(Endpoints.ArenaTeamReportOpposingTeams, client.ApiSecret, new ArenaTeamRequest(teamSize, teamName, realm));
            return client.Communicate<ArenaTeamReportOpposingTeams>(param);
        }

        public static ApiResponse<ArenaGame> GetArenaGame(TauriClient client, int matchId, Realm realm)
        {
            if (realm.GetRealmExpansion() > Expansion.Cataclysm)
                return new ApiResponse<ArenaGame>() { CustomError = CustomError.InvalidRealm, ErrorMessage = TauriClient.InvalidExpansion };

            ApiParams param = new ApiParams(Endpoints.ArenaGame, client.ApiSecret, new ArenaGameRequest(matchId, realm));
            return client.Communicate<ArenaGame>(param);
        }

        #endregion Sync

        #region Async

        public static async Task<ApiResponse<ArenaLadder>> GetArenaLadderAsync(TauriClient client, int teamSize, Realm realm)
        {
            if (realm.GetRealmExpansion() > Expansion.Cataclysm)
                return new ApiResponse<ArenaLadder>() { CustomError = CustomError.InvalidRealm, ErrorMessage = TauriClient.InvalidExpansion };

            ApiParams param = new ApiParams(Endpoints.ArenaLadder, client.ApiSecret, new ArenaLadderRequest(teamSize, realm));
            return await client.CommunicateAsync<ArenaLadder>(param);
        }

        public static async Task<ApiResponse<ArenaTeamInfo>> GetArenaTeamInfoAsync(TauriClient client, int teamSize, string teamName, Realm realm)
        {
            if (realm.GetRealmExpansion() > Expansion.Cataclysm)
                return new ApiResponse<ArenaTeamInfo>() { CustomError = CustomError.InvalidRealm, ErrorMessage = TauriClient.InvalidExpansion };

            ApiParams param = new ApiParams(Endpoints.TeamInfo, client.ApiSecret, new ArenaTeamRequest(teamSize, teamName, realm));
            return await client.CommunicateAsync<ArenaTeamInfo>(param);
        }

        public static async Task<ApiResponse<ArenaTeamGameChart>> GetArenaTeamGameChartAsync(TauriClient client, int teamSize, string teamName, Realm realm)
        {
            if (realm.GetRealmExpansion() > Expansion.Cataclysm)
                return new ApiResponse<ArenaTeamGameChart>() { CustomError = CustomError.InvalidRealm, ErrorMessage = TauriClient.InvalidExpansion };

            ApiParams param = new ApiParams(Endpoints.ArenaTeamGameChart, client.ApiSecret, new ArenaTeamRequest(teamSize, teamName, realm));
            return await client.CommunicateAsync<ArenaTeamGameChart>(param);
        }

        public static async Task<ApiResponse<ArenaTeamReportOpposingTeams>> GetArenaTeamReportOpposingTeamsAsync(TauriClient client, int teamSize, string teamName, Realm realm)
        {
            if (realm.GetRealmExpansion() > Expansion.Cataclysm)
                return new ApiResponse<ArenaTeamReportOpposingTeams>() { CustomError = CustomError.InvalidRealm, ErrorMessage = TauriClient.InvalidExpansion };

            ApiParams param = new ApiParams(Endpoints.ArenaTeamReportOpposingTeams, client.ApiSecret, new ArenaTeamRequest(teamSize, teamName, realm));
            return await client.CommunicateAsync<ArenaTeamReportOpposingTeams>(param);
        }

        public static async Task<ApiResponse<ArenaGame>> GetArenaGameAsync(TauriClient client, int matchId, Realm realm)
        {
            if (realm.GetRealmExpansion() > Expansion.Cataclysm)
                return new ApiResponse<ArenaGame>() { CustomError = CustomError.InvalidRealm, ErrorMessage = TauriClient.InvalidExpansion };

            ApiParams param = new ApiParams(Endpoints.ArenaGame, client.ApiSecret, new ArenaGameRequest(matchId, realm));
            return await client.CommunicateAsync<ArenaGame>(param);
        }

        #endregion Async
    }
}