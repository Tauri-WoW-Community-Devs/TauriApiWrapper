using Microsoft.VisualStudio.TestTools.UnitTesting;
using TauriApiWrapper;
using TauriApiWrapper.Objects;
using TauriApiWrapper.Objects.Responses.AuctionHouse;

namespace TauriApiWrapperTests
{
    [TestClass]
    public class AuctionHouseClientTester
    {
        private static readonly ApiCredentials _credentials = ApiCredentials.GetCredentials();

        [TestMethod]
        public void GetBlackMarketAuctions()
        {
            TauriClient client = new TauriClient(_credentials.ApiKey, _credentials.ApiSecret, false);
            {
                ApiResponse<BlackMarketResponse> data = BlackMarketClient.GetBlackMarketAuctions(client, TauriApiWrapper.Enums.Realm.Evermoon);
                Assert.IsNotNull(data.Response);
                Assert.IsTrue(data.IsSuccess);
                Assert.IsTrue(data.Response.Auctions.Count > 0);
                Assert.IsTrue(data.Response.Expansion == TauriApiWrapper.Enums.Expansion.MistsOfPandaria);
            }
        }

        [TestMethod]
        public void GetBlackMarketInfo()
        {
            TauriClient client = new TauriClient(_credentials.ApiKey, _credentials.ApiSecret, false);
            {
                ApiResponse<AuctionHouseInfoResponse> data = BlackMarketClient.GetBlackMarketInfo(client, TauriApiWrapper.Enums.Realm.Evermoon);
                Assert.IsTrue(data.IsSuccess);
                Assert.IsNotNull(data.Response);
                Assert.IsTrue(data.Response.Expansion == TauriApiWrapper.Enums.Expansion.MistsOfPandaria);
            }
        }

        [TestMethod]
        public void GetAuctionHouseInfo()
        {
            TauriClient client = new TauriClient(_credentials.ApiKey, _credentials.ApiSecret, false);
            {
                ApiResponse<AuctionHouseInfoResponse> data = AuctionHouseClient.GetAuctionHouseInfo(client, TauriApiWrapper.Enums.Realm.Evermoon);
                Assert.IsTrue(data.IsSuccess);
                Assert.IsNotNull(data.Response);
                Assert.IsTrue(data.Response.Expansion == TauriApiWrapper.Enums.Expansion.MistsOfPandaria);
            }
        }

        [TestMethod]
        public void GetAuctionsData()
        {
            TauriClient client = new TauriClient(_credentials.ApiKey, _credentials.ApiSecret, false);
            {
                ApiResponse<AuctionHouseResponse> data = AuctionHouseClient.GetAllAuctionsData(client, TauriApiWrapper.Enums.Realm.Tauri);
                Assert.IsTrue(data.IsSuccess);
                Assert.IsNotNull(data.Response);
                Assert.IsTrue(data.Response.Expansion == TauriApiWrapper.Enums.Expansion.MistsOfPandaria);
            }
        }


        [TestMethod]
        public void GetWrathAuctionsData()
        {
            TauriClient client = new TauriClient(_credentials.ApiKey, _credentials.ApiSecret, false);
            {
                ApiResponse<AuctionHouseResponse> data = AuctionHouseClient.GetAllAuctionsData(client, TauriApiWrapper.Enums.Realm.Crystalsong);
                Assert.IsTrue(data.IsSuccess);
                Assert.IsNotNull(data.Response);
                Assert.IsTrue(data.Response.Expansion == TauriApiWrapper.Enums.Expansion.WrathOfTheLichKing);
            }
        }


        [TestMethod]
        public void GetAuctionsDataLinkedRealm()
        {
            TauriClient client = new TauriClient(_credentials.ApiKey, _credentials.ApiSecret, false);
            {
                ApiResponse<AuctionHouseResponse> data = AuctionHouseClient.GetAllAuctionsData(client, TauriApiWrapper.Enums.Realm.Evermoon);
                Assert.IsTrue(data.IsSuccess);
                Assert.IsNotNull(data.Response);
                Assert.IsTrue(data.Response.Expansion == TauriApiWrapper.Enums.Expansion.MistsOfPandaria);
                Assert.IsTrue(!data.Response.Auctions.IsAuctionHouseEmpty());
            }
        }

        [TestMethod]
        public void GetAuctionItemPriceOnLinkedRealm()
        {
            TauriClient client = new TauriClient(_credentials.ApiKey, _credentials.ApiSecret, false);
            {
                ApiResponse<AuctionHouseResponse> data = AuctionHouseClient.GetAuctionsByItemID(client, 25707, TauriApiWrapper.Enums.Realm.Evermoon);
                Assert.IsTrue(data.IsSuccess);
                Assert.IsNotNull(data.Response);
                Assert.IsTrue(data.Response.Expansion == TauriApiWrapper.Enums.Expansion.MistsOfPandaria);
            }
        }

        [TestMethod]
        public void GetAuctionItemPrice()
        {
            TauriClient client = new TauriClient(_credentials.ApiKey, _credentials.ApiSecret, false);
            {
                ApiResponse<AuctionHouseResponse> data = AuctionHouseClient.GetAuctionsByItemID(client, 25707, TauriApiWrapper.Enums.Realm.Tauri);
                Assert.IsTrue(data.IsSuccess);
                Assert.IsNotNull(data.Response);
                Assert.IsTrue(data.Response.Expansion == TauriApiWrapper.Enums.Expansion.MistsOfPandaria);
            }
        }
    }
}