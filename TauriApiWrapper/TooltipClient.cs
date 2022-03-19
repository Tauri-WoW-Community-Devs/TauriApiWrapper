using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TauriApiWrapper.Enums;
using TauriApiWrapper.Objects;
using TauriApiWrapper.Objects.Requests;
using TauriApiWrapper.Objects.Responses.Item;

namespace TauriApiWrapper
{
    public static class TooltipClient
    {
        private class Endpoints
        {
            public const string ItemTooltip = "item-tooltip";
        }


        #region Sync

        /// <summary>
        /// Returns an items, without enchants/gems
        /// </summary>
        /// <param name="id">ID of the Item</param>
        /// <param name="realm">Realm to search on. Default is <see cref="Realm.Evermoon"/></param>
        public static ApiResponse<ItemResponse> GetItemByID(TauriClient client, int id, Realm realm = Realm.Evermoon)
        {
            ApiParams param = new ApiParams(Endpoints.ItemTooltip, client.ApiSecret, new ItemRequest(id, realm));
            return client.Communicate<ItemResponse>(param);
        }

        /// <summary>
        /// Returns a list of items, without enchants/gems
        /// </summary>
        /// <param name="itemIDs">IDs of the items you want to search for</param>
        /// <param name="realm">Realm to search on. Default is <see cref="Realm.Evermoon"/></param>
        public static ApiResponse<List<ItemResponse>> GetItemsByIDs(TauriClient client, IEnumerable<int> itemIDs, Realm realm = Realm.Evermoon)
        {
            ApiParams param = new ApiParams(Endpoints.ItemTooltip, client.ApiSecret, new ItemBulkRequest(itemIDs, realm));

            ApiResponse<JObject> apiItems = client.Communicate<JObject>(param);
            ApiResponse<List<ItemResponse>> sanitizedResponse = GenerateApiResponseFromJson(itemIDs, apiItems);
            return sanitizedResponse;
        }

        /// <summary>
        /// Gets an item holded by the player, with all the data it should contain such as enchants and gems
        /// </summary>
        /// <param name="guid">Guid of the player's item</param>
        /// <param name="pcs">Pcs param from the <see cref="TauriApiWrapper.Objects.Responses.Character.CharacterItem.QueryParams"/> object to see the fully built Tier Set Data</param>
        /// <param name="realm">Realm to search on. Default is <see cref="Realm.Evermoon"/></param>
        public static ApiResponse<ItemResponse> GetItemByGuid(TauriClient client, long guid, string pcs, Realm realm = Realm.Evermoon)
        {
            ApiParams param = new ApiParams(Endpoints.ItemTooltip, client.ApiSecret, new ItemRequest(guid, pcs, realm));
            return client.Communicate<ItemResponse>(param);
        }

        #endregion Sync

        #region Async

        /// <summary>
        /// Returns an items, without enchants/gems
        /// </summary>
        /// <param name="id">ID of the Item</param>
        /// <param name="realm">Realm to search on. Default is <see cref="Realm.Evermoon"/></param>
        public static async Task<ApiResponse<ItemResponse>> GetItemByIDAsync(TauriClient client, int id, Realm realm = Realm.Evermoon)
        {
            ApiParams param = new ApiParams(Endpoints.ItemTooltip, client.ApiSecret, new ItemRequest(id, realm));
            return await client.CommunicateAsync<ItemResponse>(param);
        }

        /// <summary>
        /// Returns a list of items, without enchants/gems
        /// </summary>
        /// <param name="itemIDs">IDs of the items you want to search for</param>
        /// <param name="realm">Realm to search on. Default is <see cref="Realm.Evermoon"/></param>
        public static async Task<ApiResponse<List<ItemResponse>>> GetItemsByIDsAsync(TauriClient client, IEnumerable<int> itemIDs, Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.ItemTooltip, client.ApiSecret, new ItemBulkRequest(itemIDs, realm));

            ApiResponse<JObject> apiItems = await client.CommunicateAsync<JObject>(param);
            ApiResponse<List<ItemResponse>> sanitizedResponse = GenerateApiResponseFromJson(itemIDs, apiItems);
            return sanitizedResponse;
        }

        /// <summary>
        /// Gets an item holded by the player, with all the data it should contain such as enchants and gems
        /// </summary>
        /// <param name="guid">Guid of the player's item</param>
        /// <param name="pcs">Pcs param from the <see cref="TauriApiWrapper.Objects.Responses.Character.CharacterItem.QueryParams"/> object to see the fully built Tier Set Data</param>
        /// <param name="realm">Realm to search on. Default is <see cref="Realm.Evermoon"/></param>
        public static async Task<ApiResponse<ItemResponse>> GetItemByGuidAsync(TauriClient client, long guid, string pcs, Realm realm)
        {
            ApiParams param = new ApiParams(Endpoints.ItemTooltip, client.ApiSecret, new ItemRequest(guid, pcs, realm));
            return await client.CommunicateAsync<ItemResponse>(param);
        }

        #endregion Async

        #region Private

        private static ApiResponse<List<ItemResponse>> GenerateApiResponseFromJson(IEnumerable<int> itemIDs, ApiResponse<JObject> apiItems)
        {
            List<ItemResponse> items = new List<ItemResponse>();
            List<string> comparerKeys = itemIDs.Select(x => x.ToString()).ToList();
            foreach (KeyValuePair<string, JToken> item in apiItems.Response)
            {
                if (!comparerKeys.Contains(item.Key))
                    continue;

                items.Add(item.Value.ToObject<ItemResponse>());
            }

            ApiResponse<List<ItemResponse>> sanitizedResponse = new ApiResponse<List<ItemResponse>>()
            {
                ErrorCode = apiItems.ErrorCode,
                ErrorMessage = apiItems.ErrorMessage,
                IsSuccess = apiItems.IsSuccess,
                Response = items
            };
            return sanitizedResponse;
        }

        #endregion Private
    }
}