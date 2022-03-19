using System.Threading.Tasks;
using TauriApiWrapper.Enums;
using TauriApiWrapper.Extensions;
using TauriApiWrapper.Objects;
using TauriApiWrapper.Objects.Requests;
using TauriApiWrapper.Objects.Responses.AuctionHouse;

namespace TauriApiWrapper
{
    public static class AuctionHouseClient
    {
        private class Endpoints
        {
            public const string AuctionsInfo = "auctions-info";
            public const string AuctionsData = "auctions-data";
            public const string AuctionItemData = "auctions-item-prices";
        }


        #region Sync

        public static ApiResponse<AuctionHouseInfoResponse> GetAuctionHouseInfo(TauriClient client, Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.AuctionsInfo, client.ApiSecret, new AuctionHouseBaseRequest(realm.ToMasterRealm()));
            return client.Communicate<AuctionHouseInfoResponse>(param);
        }

        public static ApiResponse<AuctionHouseResponse> GetAllAuctionsData(TauriClient client, Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.AuctionsData, client.ApiSecret, new AuctionHouseBaseRequest(realm.ToMasterRealm()));
            return client.Communicate<AuctionHouseResponse>(param);
        }

        public static ApiResponse<AuctionHouseResponse> GetAuctionsByItemID(TauriClient client, int itemID, Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.AuctionItemData, client.ApiSecret, new AuctionHouseItemPriceRequest(itemID, realm.ToMasterRealm()));
            return client.Communicate<AuctionHouseResponse>(param);
        }

        #endregion Sync

        #region Async

        public static async Task<ApiResponse<AuctionHouseInfoResponse>> GetAuctionHouseInfoAsync(TauriClient client, Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.AuctionsInfo, client.ApiSecret, new AuctionHouseBaseRequest(realm.ToMasterRealm()));
            return await client.CommunicateAsync<AuctionHouseInfoResponse>(param);
        }

        public static async Task<ApiResponse<AuctionHouseResponse>> GetAllAuctionsDataAsync(TauriClient client, Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.AuctionsData, client.ApiSecret, new AuctionHouseBaseRequest(realm.ToMasterRealm()));
            return await client.CommunicateAsync<AuctionHouseResponse>(param);
        }

        public static async Task<ApiResponse<AuctionHouseResponse>> GetAuctionsByItemIDAsync(TauriClient client, int itemID, Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.AuctionItemData, client.ApiSecret, new AuctionHouseItemPriceRequest(itemID, realm.ToMasterRealm()));
            return await client.CommunicateAsync<AuctionHouseResponse>(param);
        }

        #endregion Async
    }
}