using System.Threading.Tasks;
using TauriApiWrapper.Enums;
using TauriApiWrapper.Objects;
using TauriApiWrapper.Objects.Requests;
using TauriApiWrapper.Objects.Responses.Guild;

namespace TauriApiWrapper
{
    public static class GuildClient
    {
        private class Endpoints
        {
            public const string GuildInfo = "guild-info";
            public const string GuildStats = "guild-stats";
            public const string GuildBankContents = "guild-bank-contents";
            public const string GuildBankLogs = "guild-bank-log";
        }



        public static async Task<ApiResponse<GuildRoster>> GetGuildRosterAsync(TauriClient client, string guildName, Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.GuildInfo, client.ApiSecret, new GuildRequest(guildName, realm));
            return await client.CommunicateAsync<GuildRoster>(param);
        }

        public static async Task<ApiResponse<GuildStats>> GetGuildStatsAsync(TauriClient client, string guildName, Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.GuildStats, client.ApiSecret, new GuildRequest(guildName, realm));
            return await client.CommunicateAsync<GuildStats>(param);
        }

        public static async Task<ApiResponse<GuildBankContent>> GetGuildBankContentsAsync(TauriClient client, string guildName, Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.GuildBankContents, client.ApiSecret, new GuildRequest(guildName, realm));
            return await client.CommunicateAsync<GuildBankContent>(param);
        }

        public static async Task<ApiResponse<GuildBankLog>> GetGuildBankLogsAsync(TauriClient client, string guildName, Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.GuildBankLogs, client.ApiSecret, new GuildRequest(guildName, realm));
            return await client.CommunicateAsync<GuildBankLog>(param);
        }

        public static ApiResponse<GuildRoster> GetGuildRoster(TauriClient client, string guildName, Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.GuildInfo, client.ApiSecret, new GuildRequest(guildName, realm));
            return client.Communicate<GuildRoster>(param);
        }

        public static ApiResponse<GuildStats> GetGuildStats(TauriClient client, string guildName, Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.GuildStats, client.ApiSecret, new GuildRequest(guildName, realm));
            return client.Communicate<GuildStats>(param);
        }

        public static ApiResponse<GuildBankContent> GetGuildBankContents(TauriClient client, string guildName, Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.GuildBankContents, client.ApiSecret, new GuildRequest(guildName, realm));
            return client.Communicate<GuildBankContent>(param);
        }

        public static ApiResponse<GuildBankLog> GetGuildBankLogs(TauriClient client, string guildName, Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.GuildBankLogs, client.ApiSecret, new GuildRequest(guildName, realm));
            return client.Communicate<GuildBankLog>(param);
        }
    }
}