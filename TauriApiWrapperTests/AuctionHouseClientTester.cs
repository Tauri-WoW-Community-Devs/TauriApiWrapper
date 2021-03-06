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
            using (BlackMarketClient client = new BlackMarketClient(_credentials.ApiKey, _credentials.ApiSecret))
            {
                ApiResponse<BlackMarketResponse> data = client.GetBlackMarketAuctions(TauriApiWrapper.Enums.Realm.Evermoon);
                Assert.IsNotNull(data.Response);
                Assert.IsTrue(data.IsSuccess);
                Assert.IsTrue(data.Response.Auctions.Count > 0);
                Assert.IsTrue(data.Response.Expansion == TauriApiWrapper.Enums.Expansion.MistsOfPandaria);
            }
        }

        [TestMethod]
        public void GetBlackMarketInfo()
        {
            using (BlackMarketClient client = new BlackMarketClient(_credentials.ApiKey, _credentials.ApiSecret))
            {
                ApiResponse<AuctionHouseInfoResponse> data = client.GetBlackMarketInfo(TauriApiWrapper.Enums.Realm.Evermoon);
                Assert.IsTrue(data.IsSuccess);
                Assert.IsNotNull(data.Response);
                Assert.IsTrue(data.Response.Expansion == TauriApiWrapper.Enums.Expansion.MistsOfPandaria);
            }
        }

        [TestMethod]
        public void GetAuctionHouseInfo()
        {
            using (AuctionHouseClient client = new AuctionHouseClient(_credentials.ApiKey, _credentials.ApiSecret))
            {
                ApiResponse<AuctionHouseInfoResponse> data = client.GetAuctionHouseInfo(TauriApiWrapper.Enums.Realm.Evermoon);
                Assert.IsTrue(data.IsSuccess);
                Assert.IsNotNull(data.Response);
                Assert.IsTrue(data.Response.Expansion == TauriApiWrapper.Enums.Expansion.MistsOfPandaria);
            }
        }

        [TestMethod]
        public void GetAuctionsData()
        {
            using (AuctionHouseClient client = new AuctionHouseClient(_credentials.ApiKey, _credentials.ApiSecret))
            {
                ApiResponse<AuctionHouseResponse> data = client.GetAllAuctionsData(TauriApiWrapper.Enums.Realm.Tauri);
                Assert.IsTrue(data.IsSuccess);
                Assert.IsNotNull(data.Response);
                Assert.IsTrue(data.Response.Expansion == TauriApiWrapper.Enums.Expansion.MistsOfPandaria);
            }
        }


        [TestMethod]
        public void GetWrathAuctionsData()
        {
            using (AuctionHouseClient client = new AuctionHouseClient(_credentials.ApiKey, _credentials.ApiSecret))
            {
                ApiResponse<AuctionHouseResponse> data = client.GetAllAuctionsData(TauriApiWrapper.Enums.Realm.Crystalsong);
                Assert.IsTrue(data.IsSuccess);
                Assert.IsNotNull(data.Response);
                Assert.IsTrue(data.Response.Expansion == TauriApiWrapper.Enums.Expansion.WrathOfTheLichKing);
            }
        }


        [TestMethod]
        public void GetAuctionsDataLinkedRealm()
        {
            using (AuctionHouseClient client = new AuctionHouseClient(_credentials.ApiKey, _credentials.ApiSecret))
            {
                ApiResponse<AuctionHouseResponse> data = client.GetAllAuctionsData(TauriApiWrapper.Enums.Realm.Evermoon);
                Assert.IsTrue(data.IsSuccess);
                Assert.IsNotNull(data.Response);
                Assert.IsTrue(data.Response.Expansion == TauriApiWrapper.Enums.Expansion.MistsOfPandaria);
                Assert.IsTrue(!data.Response.Auctions.IsAuctionHouseEmpty());
            }
        }

        [TestMethod]
        public void GetAuctionItemPriceOnLinkedRealm()
        {
            using (AuctionHouseClient client = new AuctionHouseClient(_credentials.ApiKey, _credentials.ApiSecret))
            {
                ApiResponse<AuctionHouseResponse> data = client.GetAuctionsByItemID(25707, TauriApiWrapper.Enums.Realm.Evermoon);
                Assert.IsTrue(data.IsSuccess);
                Assert.IsNotNull(data.Response);
                Assert.IsTrue(data.Response.Expansion == TauriApiWrapper.Enums.Expansion.MistsOfPandaria);
            }
        }

        [TestMethod]
        public void GetAuctionItemPrice()
        {
            using (AuctionHouseClient client = new AuctionHouseClient(_credentials.ApiKey, _credentials.ApiSecret))
            {
                ApiResponse<AuctionHouseResponse> data = client.GetAuctionsByItemID(25707, TauriApiWrapper.Enums.Realm.Tauri);
                Assert.IsTrue(data.IsSuccess);
                Assert.IsNotNull(data.Response);
                Assert.IsTrue(data.Response.Expansion == TauriApiWrapper.Enums.Expansion.MistsOfPandaria);
            }
        }
    }
}