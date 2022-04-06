using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using TauriApiWrapper;
using TauriApiWrapper.Enums;
using TauriApiWrapper.Objects;
using TauriApiWrapper.Objects.Responses.Raid;

namespace TauriApiWrapperTests
{
    [TestClass]
    public class RaidClientTester
    {
        private static readonly ApiCredentials _credentials = ApiCredentials.GetCredentials();

        [TestMethod]
        public void GetRaidMapsInfo()
        {
            TauriClient client = new TauriClient(_credentials.ApiKey, _credentials.ApiSecret, false);
            ApiResponse<RaidMaps> returnData = RaidClient.GetRaidMaps(client);
            Assert.IsNotNull(returnData.Response);
            Assert.IsTrue(returnData.IsSuccess);
            Assert.IsTrue(returnData.Response.ClassicRaids.Length > 0);
            Assert.IsTrue(returnData.Response.BurningCrusadeRaids.Length > 0);
            Assert.IsTrue(returnData.Response.WrathOfTheLichKingRaids.Length > 0);
            Assert.IsTrue(returnData.Response.CataclysmRaids.Length > 0);
            Assert.IsTrue(returnData.Response.MistsOfPandariaRaids.Length > 0);
        }

        [TestMethod]
        public void GetLatestRaidsInfo()
        {
            TauriClient client = new TauriClient(_credentials.ApiKey, _credentials.ApiSecret, false);
            {
                ApiResponse<RaidLogsResponse> returnData = RaidClient.GetLatestRaids(client, TauriApiWrapper.Enums.Realm.Tauri, mapID: 996, limit: 5);
                Assert.IsTrue(returnData.IsSuccess);
                Assert.IsNotNull(returnData.Response);
                Assert.IsNotNull(returnData.Response.Logs);
                Assert.IsTrue(returnData.Response.Logs.Length > 0);
            }
        }

        [TestMethod]
        public void GetLatestRaidLogInfo()
        {
            TauriClient client = new TauriClient(_credentials.ApiKey, _credentials.ApiSecret, false);
            {
                ApiResponse<RaidLogsResponse> returnData = RaidClient.GetLatestRaids(client, TauriApiWrapper.Enums.Realm.Evermoon, limit: 5);
                Assert.IsNotNull(returnData.Response);
                Assert.IsTrue(returnData.IsSuccess);
                Assert.IsNotNull(returnData.Response.Logs);
                Assert.IsTrue(returnData.Response.Logs.Length > 0);

                ApiResponse<RaidLog> raidlog = RaidClient.GetRaidLogFromID(client, returnData.Response.Logs[0].LogID, TauriApiWrapper.Enums.Realm.Evermoon);
                Assert.IsTrue(raidlog.IsSuccess);
                Assert.IsNotNull(raidlog.Response);
                Assert.IsNotNull(raidlog.Response.Encounter);
            }
        }

        [TestMethod]
        public async Task GetRaidEncounterRankings()
        {
            TauriClient client = new TauriClient(_credentials.ApiKey, _credentials.ApiSecret, false);
            {
                var returnData = await RaidClient.GetRaidEncounterRankingAsync(client, 1623, RaidDifficulty.TwentyFivePlayerHeroic, TauriApiWrapper.Enums.Realm.Evermoon);
                Assert.IsNotNull(returnData.Response);
                Assert.IsTrue(returnData.IsSuccess);
                Assert.IsNotNull(returnData.Response.Logs);
                Assert.IsTrue(returnData.Response.Logs.Length > 0);
            }
        }


    }
}