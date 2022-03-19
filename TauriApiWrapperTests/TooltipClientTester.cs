using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TauriApiWrapper;
using TauriApiWrapper.Objects;
using TauriApiWrapper.Objects.Responses.Character;
using TauriApiWrapper.Objects.Responses.Item;

namespace TauriApiWrapperTests
{
    [TestClass]
    public class TooltipClientTester
    {
        private static readonly ApiCredentials _credentials = ApiCredentials.GetCredentials();

        [TestMethod]
        public void GetItemById()
        {
            TauriClient client = new TauriClient(_credentials.ApiKey, _credentials.ApiSecret, false);
            {
                ApiResponse<ItemResponse> returnData = TooltipClient.GetItemByID(client, 99359);
                Assert.IsNotNull(returnData.Response);
                Assert.IsTrue(returnData.IsSuccess);
            }
        }
        

        [TestMethod]
        public void GetItemByIds()
        {
            TauriClient client = new TauriClient(_credentials.ApiKey, _credentials.ApiSecret, false);
            {
                ApiResponse<List<ItemResponse>> returnData = TooltipClient.GetItemsByIDs(client, new List<int> { 104633, 42944 });
                Assert.IsNotNull(returnData.Response);
                Assert.IsTrue(returnData.IsSuccess);
            }
        }
    }
}
