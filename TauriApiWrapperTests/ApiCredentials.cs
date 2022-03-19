using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.IO;

namespace TauriApiWrapperTests
{
    internal class ApiCredentials
    {
        [JsonProperty("APIKEY")]
        public string ApiKey { get; set; }

        [JsonProperty("APISECRET")]
        public string ApiSecret { get; set; }

        public static ApiCredentials GetCredentials()
        {
            return JsonConvert.DeserializeObject<ApiCredentials>(File.ReadAllText("../../../settings.json"));
        }
    }

    [TestClass]
    public class ApiCredentialsTester
    {
        private static readonly ApiCredentials _credentials = ApiCredentials.GetCredentials();

        [TestMethod]
        public void CheckAPICredentials()
        {
            Assert.IsTrue(!string.IsNullOrEmpty(_credentials.ApiKey));
            Assert.IsTrue(!string.IsNullOrEmpty(_credentials.ApiSecret));
        }
    }
}