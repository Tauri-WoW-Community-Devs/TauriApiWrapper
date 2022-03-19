using Microsoft.VisualStudio.TestTools.UnitTesting;
using TauriApiWrapper;
using TauriApiWrapper.Objects;
using TauriApiWrapper.Objects.Responses.Achievement;

namespace TauriApiWrapperTests
{
    [TestClass]
    public class AchievementClientTester
    {
        private static readonly ApiCredentials _credentials = ApiCredentials.GetCredentials();

        [TestMethod]
        public void GetAchievementFirst()
        {
            TauriClient client = new TauriClient(_credentials.ApiKey, _credentials.ApiSecret, false);

            ApiResponse<AchievementFirst> returnData = AchievementClient.GetAchievementFirsts(client, TauriApiWrapper.Enums.Realm.Evermoon);
            Assert.IsTrue(returnData.IsSuccess);
            Assert.IsNotNull(returnData.Response);
            Assert.IsTrue(returnData.Response.AchievementFirstArray.Count > 0);

        }

        [TestMethod]
        public void GetCharacterAchievements()
        {
            TauriClient client = new TauriClient(_credentials.ApiKey, _credentials.ApiSecret, false);

            {
                ApiResponse<CharacterAchievements> returnData = AchievementClient.GetCharacterAchievements(client, "Rdzio", TauriApiWrapper.Enums.Realm.Evermoon);
                Assert.IsTrue(returnData.IsSuccess);
                Assert.IsNotNull(returnData.Response);
            }
        }

        [TestMethod]
        public void GetCharacterAchievementsLoader()
        {
            TauriClient client = new TauriClient(_credentials.ApiKey, _credentials.ApiSecret, false);
            {
                ApiResponse<CharacterAchievementsLoader> returnData = AchievementClient.GetCharacterAchievementsLoader(client, "Rdzio", (int)TauriApiWrapper.Enums.AchievementCategory.Guild, TauriApiWrapper.Enums.Realm.Evermoon);
                Assert.IsTrue(returnData.IsSuccess);
                Assert.IsNotNull(returnData.Response);
            }
        }
    }
}