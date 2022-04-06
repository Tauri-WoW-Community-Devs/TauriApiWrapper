using System.Threading;
using System.Threading.Tasks;
using TauriApiWrapper.Enums;
using TauriApiWrapper.Extensions;
using TauriApiWrapper.Objects;
using TauriApiWrapper.Objects.Requests;
using TauriApiWrapper.Objects.Responses.Arena;

namespace TauriApiWrapper
{
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

        public static ApiResponse<ArenaLadder> GetArenaLadder(TauriClient client, ArenaTeamFormat teamSize, Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.ArenaLadder, client.ApiSecret, new ArenaLadderRequest(teamSize, realm));
            return client.Communicate<ArenaLadder>(param);
        }

        public static ApiResponse<ArenaTeamInfo> GetArenaTeamInfo(TauriClient client, ArenaTeamFormat teamSize, string teamName, Realm realm)
        {
            if (realm.GetRealmExpansion() > Expansion.Cataclysm)
                return new ApiResponse<ArenaTeamInfo>() { CustomError = CustomError.InvalidRealm, ErrorMessage = TauriClient.InvalidExpansion };

            ApiParams param = new ApiParams(Endpoints.TeamInfo, client.ApiSecret, new ArenaTeamRequest(realm, teamSize, teamName));
            return client.Communicate<ArenaTeamInfo>(param);
        }

        public static ApiResponse<ArenaTeamGameChart> GetArenaTeamGameChart(TauriClient client, ArenaTeamFormat teamSize, string teamName, Realm realm)
        {
            if (realm.GetRealmExpansion() > Expansion.Cataclysm)
                return new ApiResponse<ArenaTeamGameChart>() { CustomError = CustomError.InvalidRealm, ErrorMessage = TauriClient.InvalidExpansion };

            ApiParams param = new ApiParams(Endpoints.ArenaTeamGameChart, client.ApiSecret, new ArenaTeamRequest(realm, teamSize, teamName));
            return client.Communicate<ArenaTeamGameChart>(param);
        }

        public static ApiResponse<ArenaTeamReportOpposingTeams> GetArenaTeamReportOpposingTeams(TauriClient client, ArenaTeamFormat teamSize, string teamName, Realm realm)
        {
            if (realm.GetRealmExpansion() > Expansion.Cataclysm)
                return new ApiResponse<ArenaTeamReportOpposingTeams>() { CustomError = CustomError.InvalidRealm, ErrorMessage = TauriClient.InvalidExpansion };

            ApiParams param = new ApiParams(Endpoints.ArenaTeamReportOpposingTeams, client.ApiSecret, new ArenaTeamRequest(realm, teamSize, teamName));
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

        public static async Task<ApiResponse<ArenaLadder>> GetArenaLadderAsync(TauriClient client, ArenaTeamFormat teamSize, Realm realm, CancellationToken cancellationToken = default)
        {
            ApiParams param = new ApiParams(Endpoints.ArenaLadder, client.ApiSecret, new ArenaLadderRequest(teamSize, realm));
            return await client.CommunicateAsync<ArenaLadder>(param, cancellationToken);
        }

        public static async Task<ApiResponse<CharacterPvPStatSheet>> GetCharacterPvPStatsAsync(TauriClient client, Realm realm, string characterName, CancellationToken cancellationToken = default)
        {
            ApiParams param = new ApiParams(Endpoints.CharacterPvPStat, client.ApiSecret, new CharacterPvPStatsRequest(realm, characterName));
            return await client.CommunicateAsync<CharacterPvPStatSheet>(param, cancellationToken);
        }
        public static async Task<ApiResponse<object>> GetCharacterArenaTeamsAsync(TauriClient client, Realm realm, string characterName, CancellationToken cancellationToken = default)
        {
            ApiParams param = new ApiParams(Endpoints.CharacterArenaTeams, client.ApiSecret, new CharacterPvPStatsRequest(realm, characterName));
            return await client.CommunicateAsync<object>(param, cancellationToken);
        }

        public static async Task<ApiResponse<ArenaTeamInfo>> GetArenaTeamInfoAsync(TauriClient client, ArenaTeamFormat teamSize, string teamName, Realm realm, CancellationToken cancellationToken = default)
        {
            if (realm.GetRealmExpansion() > Expansion.Cataclysm)
                return new ApiResponse<ArenaTeamInfo>() { CustomError = CustomError.InvalidRealm, ErrorMessage = TauriClient.InvalidExpansion };

            ApiParams param = new ApiParams(Endpoints.TeamInfo, client.ApiSecret, new ArenaTeamRequest(realm, teamSize, teamName));
            return await client.CommunicateAsync<ArenaTeamInfo>(param, cancellationToken);
        }

        public static async Task<ApiResponse<ArenaTeamGameChart>> GetArenaTeamGameChartAsync(TauriClient client, ArenaTeamFormat teamSize, string teamName, Realm realm, CancellationToken cancellationToken = default)
        {
            if (realm.GetRealmExpansion() > Expansion.Cataclysm)
                return new ApiResponse<ArenaTeamGameChart>() { CustomError = CustomError.InvalidRealm, ErrorMessage = TauriClient.InvalidExpansion };

            ApiParams param = new ApiParams(Endpoints.ArenaTeamGameChart, client.ApiSecret, new ArenaTeamRequest(realm, teamSize, teamName));
            return await client.CommunicateAsync<ArenaTeamGameChart>(param, cancellationToken);
        }

        public static async Task<ApiResponse<ArenaTeamReportOpposingTeams>> GetArenaTeamReportOpposingTeamsAsync(TauriClient client, ArenaTeamFormat teamSize, string teamName, Realm realm, CancellationToken cancellationToken = default)
        {
            if (realm.GetRealmExpansion() > Expansion.Cataclysm)
                return new ApiResponse<ArenaTeamReportOpposingTeams>() { CustomError = CustomError.InvalidRealm, ErrorMessage = TauriClient.InvalidExpansion };

            ApiParams param = new ApiParams(Endpoints.ArenaTeamReportOpposingTeams, client.ApiSecret, new ArenaTeamRequest(realm, teamSize, teamName));
            return await client.CommunicateAsync<ArenaTeamReportOpposingTeams>(param, cancellationToken);
        }

        public static async Task<ApiResponse<ArenaGame>> GetArenaGameAsync(TauriClient client, int matchId, Realm realm, CancellationToken cancellationToken = default)
        {
            if (realm.GetRealmExpansion() > Expansion.Cataclysm)
                return new ApiResponse<ArenaGame>() { CustomError = CustomError.InvalidRealm, ErrorMessage = TauriClient.InvalidExpansion };

            ApiParams param = new ApiParams(Endpoints.ArenaGame, client.ApiSecret, new ArenaGameRequest(matchId, realm));
            return await client.CommunicateAsync<ArenaGame>(param, cancellationToken);
        }

        #endregion Async
    }
}