using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using TauriApiWrapper;
using TauriApiWrapper.Objects.Responses.Character;

namespace TauriApiWrapperTests
{
    [TestClass]
    public class CharacterClientTester
    {
        private static readonly ApiCredentials _credentials = ApiCredentials.GetCredentials();

        [TestMethod]
        public void GetCharacterSheetByName()
        {
            TauriClient c = new TauriClient(_credentials.ApiKey, _credentials.ApiSecret, false);
            {
                TauriApiWrapper.Objects.ApiResponse<CharacterSheet> data = CharacterClient.GetCharacterSheet(c, "Querý", TauriApiWrapper.Enums.Realm.Evermoon);
                Assert.IsNotNull(data.Response);
                Assert.IsTrue(data.IsSuccess);
                Assert.IsTrue(!string.IsNullOrEmpty(data.Response.Name));
                Assert.IsNotNull(data.Response.CharacterItems);
            }
        }

        [TestMethod]
        public void GetCharacterTalentsByName()
        {
            TauriClient c = new TauriClient(_credentials.ApiKey, _credentials.ApiSecret, false);
            {
                TauriApiWrapper.Objects.ApiResponse<CharacterTalents> data = CharacterClient.GetCharacterTalents(c, "Querý", TauriApiWrapper.Enums.Realm.Evermoon);
                Assert.IsNotNull(data.Response);
                Assert.IsTrue(data.IsSuccess);
                Assert.IsTrue(!string.IsNullOrEmpty(data.Response.Name));
            }
        }

        [TestMethod]
        public async Task GetCharacterMountsByName()
        {
            TauriClient c = new TauriClient(_credentials.ApiKey, _credentials.ApiSecret, false);
            {
                TauriApiWrapper.Objects.ApiResponse<CharacterMounts> data = await CharacterClient.GetCharacterMountsByNameAsync(c, "Querý", TauriApiWrapper.Enums.Realm.Evermoon);
                Assert.IsNotNull(data.Response);
                Assert.IsTrue(data.IsSuccess);
            }
        }

        [TestMethod]
        public async Task GetCharacterFeedByName()
        {
            TauriClient c = new TauriClient(_credentials.ApiKey, _credentials.ApiSecret, false);
            {
                TauriApiWrapper.Objects.ApiResponse<CharacterFeedList> data = await CharacterClient.GetCharacterFeedByNameAsync(c, "Querý", TauriApiWrapper.Enums.Realm.Evermoon);
                Assert.IsNotNull(data.Response);
                Assert.IsTrue(data.IsSuccess);
            }
        }
    }
}