using Microsoft.VisualStudio.TestTools.UnitTesting;
using TauriApiWrapper;
using TauriApiWrapper.Objects;
using TauriApiWrapper.Objects.Responses.Challenge;

namespace TauriApiWrapperTests
{
    [TestClass]
    public class ChallengeModeTester
    {
        private static readonly ApiCredentials _credentials = ApiCredentials.GetCredentials();

        [TestMethod]
        public void GetChallengeIndex()
        {
            TauriClient client = new TauriClient(_credentials.ApiKey, _credentials.ApiSecret, false);
            {
                ApiResponse<ChallengeIndex> returnData = ChallengeModeClient.GetChallengeIndex(client, TauriApiWrapper.Enums.Realm.Evermoon);
                Assert.IsTrue(returnData.IsSuccess);
                Assert.IsNotNull(returnData.Response);
                Assert.IsTrue(returnData.Response.Expansion == TauriApiWrapper.Enums.Expansion.MistsOfPandaria);
            }
        }

        [TestMethod]
        public void GetChallengeLeaderboard()
        {
            TauriClient client = new TauriClient(_credentials.ApiKey, _credentials.ApiSecret, false);
            {
                ApiResponse<ChallengeLeaderboard> returnData = ChallengeModeClient.GetChallengeLeaderboard(client, (int)TauriApiWrapper.Enums.ChallengeMap.TempleOfTheJadeSerpent, TauriApiWrapper.Enums.Realm.Evermoon);
                Assert.IsTrue(returnData.IsSuccess);
                Assert.IsNotNull(returnData.Response);
                Assert.IsTrue(returnData.Response.Expansion == TauriApiWrapper.Enums.Expansion.MistsOfPandaria);
            }
        }
    }
}