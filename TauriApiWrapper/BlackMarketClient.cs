using System.Threading.Tasks;
using TauriApiWrapper.Enums;
using TauriApiWrapper.Extensions;
using TauriApiWrapper.Objects;
using TauriApiWrapper.Objects.Requests;
using TauriApiWrapper.Objects.Responses.AuctionHouse;

namespace TauriApiWrapper
{
    public static class BlackMarketClient
    {
        private class Endpoints
        {
            public const string AuctionsData = "bmauctions-data";
            public const string AuctionsInfo = "bmauctions-info";
        }

        #region Sync

        public static ApiResponse<BlackMarketResponse> GetBlackMarketAuctions(TauriClient client, Realm realm)
        {
            if (realm.GetRealmExpansion() < Expansion.MistsOfPandaria)
                return new ApiResponse<BlackMarketResponse>() { ErrorMessage = TauriClient.InvalidExpansion };

            ApiParams param = new ApiParams(Endpoints.AuctionsData, client.ApiSecret, new AuctionHouseBaseRequest(realm));
            return client.Communicate<BlackMarketResponse>(param);
        }

        public static ApiResponse<AuctionHouseInfoResponse> GetBlackMarketInfo(TauriClient client, Realm realm)
        {
            if (realm.GetRealmExpansion() < Expansion.MistsOfPandaria)
                return new ApiResponse<AuctionHouseInfoResponse>() { ErrorMessage = TauriClient.InvalidExpansion };

            ApiParams param = new ApiParams(Endpoints.AuctionsInfo, client.ApiSecret, new AuctionHouseBaseRequest(realm));
            return client.Communicate<AuctionHouseInfoResponse>(param);
        }

        #endregion Sync

        #region Async

        public static async Task<ApiResponse<BlackMarketResponse>> GetBlackMarketAuctionsAsync(TauriClient client, Realm realm)
        {
            if (realm.GetRealmExpansion() < Expansion.MistsOfPandaria)
                return new ApiResponse<BlackMarketResponse>() { ErrorMessage = TauriClient.InvalidExpansion };

            ApiParams param = new ApiParams(Endpoints.AuctionsData, client.ApiSecret, new AuctionHouseBaseRequest(realm));
            return await client.CommunicateAsync<BlackMarketResponse>(param);
        }

        public static async Task<ApiResponse<AuctionHouseInfoResponse>> GetBlackMarketInfoAsync(TauriClient client, Realm realm)
        {
            if (realm.GetRealmExpansion() < Expansion.MistsOfPandaria)
                return new ApiResponse<AuctionHouseInfoResponse>() { ErrorMessage = TauriClient.InvalidExpansion };

            ApiParams param = new ApiParams(Endpoints.AuctionsInfo, client.ApiSecret, new AuctionHouseBaseRequest(realm));
            return await client.CommunicateAsync<AuctionHouseInfoResponse>(param);
        }

        #endregion Async
    }
}