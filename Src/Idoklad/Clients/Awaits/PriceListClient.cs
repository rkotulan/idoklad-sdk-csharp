using System.Threading.Tasks;
using IdokladSdk.ApiFilters;
using IdokladSdk.ApiModels;
using IdokladSdk.ApiModels.BaseModels;

namespace IdokladSdk.Clients
{
    /// <summary>
    /// Methods for price list.
    /// </summary>
    public partial class PriceListClient : BaseClient
    {
        /// <summary>
        /// GET api/PriceListItems/Default
        /// Method returns default price list item that is suitable for new item creation.
        /// </summary>
        public async Task<PriceList> DefaultAsync()
        {
            return await GetAsync<PriceList>(ResourceUrl + "/Default");
        }

        /// <summary>
        /// GET api/PriceListItems/{id}/Expand
        /// Method returns price list item by its Id with extended entities.
        /// </summary>
        public async Task<PriceListExpand> PriceListItemExpandAsync(int priceListItemId)
        {
            return await GetAsync<PriceListExpand>(ResourceUrl + "/" + priceListItemId + "/Expand");
        }

        /// <summary>
        /// DELETE api/PriceListItems/{id}
        /// Method deletes price list item.
        /// </summary>
        public async Task<bool> DeleteAsync(int priceListItemId)
        {
            return await DeleteAsync(ResourceUrl + "/" + priceListItemId);
        }

        /// <summary>
        /// DELETE api/PriceListItems/Batch/{deleteIfReferenced}
        /// Method deletes price list items, including ones referenced on invoices, stock, etc.
        /// </summary>
        public async Task<bool> DeleteBatchAsync(bool deleteIfReferenced, object[] ids)
        {
            return await DeleteAsync(ResourceUrl + "/" + "Batch" + "/" + deleteIfReferenced, ids);
        }

        /// <summary>
        /// GET api/PriceListItems
        /// Returns price list with pages.
        /// </summary>
        public async Task<RowsResultWrapper<PriceList>> PriceListItemsAsync(ApiFilter filter)
        {
            return await GetAsync<RowsResultWrapper<PriceList>>(ResourceUrl, filter);
        }

        /// <summary>
        /// GET api/PriceListItems/{id}
        /// Returns price list item by Id.
        /// </summary>
        public async Task<PriceList> PriceListItemAsync(int priceListItemId)
        {
            return await GetAsync<PriceList>(ResourceUrl + "/" + priceListItemId);
        }

        /// <summary>
        /// POST api/PriceListItems
        /// Insert new price item into the price list.
        /// </summary>
        public async Task<PriceList> CreateAsync(PriceList model)
        {
            return await PostAsync<PriceList, PriceList>(ResourceUrl, model);
        }

        /// <summary>
        /// PUT api/PriceListItems/{id}
        /// Method updates price list item.
        /// </summary>
        public async Task<PriceList> UpdateAsync(int priceListItemId, PriceList model)
        {
            return await PutAsync<PriceList, PriceList>(ResourceUrl + "/" + priceListItemId, model);
        }
    }
}