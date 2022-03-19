using Microsoft.VisualStudio.TestTools.UnitTesting;
using TauriApiWrapper;
using TauriApiWrapper.Objects;
using TauriApiWrapper.Objects.Responses.Guild;

namespace TauriApiWrapperTests
{
    [TestClass]
    public class GuildClientTester
    {
        private static readonly ApiCredentials _credentials = ApiCredentials.GetCredentials();

        [TestMethod]
        public void GetGuildRoster()
        {
            TauriClient client = new TauriClient(_credentials.ApiKey, _credentials.ApiSecret, false);
            {
                ApiResponse<GuildRoster> returnData = GuildClient.GetGuildRoster(client, "Muzykanci z Gruzji", TauriApiWrapper.Enums.Realm.Evermoon);
                Assert.IsTrue(returnData.IsSuccess);
                Assert.IsNotNull(returnData.Response);
                Assert.IsTrue(returnData.Response.GuildList.Count > 0);
            }
        }

        [TestMethod]
        public void GetGuildStats()
        {
            TauriClient client = new TauriClient(_credentials.ApiKey, _credentials.ApiSecret, false);
            {
                ApiResponse<GuildStats> returnData = GuildClient.GetGuildStats(client, "Muzykanci z Gruzji", TauriApiWrapper.Enums.Realm.Evermoon);
                Assert.IsTrue(returnData.IsSuccess);
                Assert.IsNotNull(returnData.Response);
                Assert.IsTrue(returnData.Response.GuildList.Count > 0);
            }
        }
    }
}