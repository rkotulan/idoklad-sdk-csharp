using System.Threading.Tasks;
using IdokladSdk.ApiFilters;
using IdokladSdk.ApiModels;
using IdokladSdk.ApiModels.BaseModels;
using IdokladSdk.Enums;

namespace IdokladSdk.Clients
{
    public partial class RegisteredSaleClient : BaseClient
    {
        /// <summary>
        /// GET api/RegisteredSales
        /// Method returns list of registered sales.
        /// </summary>
        public async Task<RowsResultWrapper<RegisteredSale>> RegisteredSalesAsync(ApiFilter filter = null)
        {
            return await GetAsync<RowsResultWrapper<RegisteredSale>>(ResourceUrl, filter);
        }

        /// <summary>
        /// GET api/RegisteredSales/{id}
        /// Method returns registered sale by Id.
        /// </summary>
        public async Task<RegisteredSale> RegisteredSaleAsync(SalesTypeEnum type, int registeredSaleId)
        {
            return await GetAsync<RegisteredSale>(ResourceUrl + "/" + (int)type + "/" + registeredSaleId);
        }

        /// <summary>
        /// GET api/RegisteredSales/Expand
        /// List of registered sales with related entities.
        /// </summary>
        public async Task<RowsResultWrapper<RegisteredSaleExpand>> RegisteredSalesExpandAsync(ApiFilter filter = null)
        {
            return await GetAsync<RowsResultWrapper<RegisteredSaleExpand>>(ResourceUrl + "/Expand", filter);
        }

        /// <summary>
        /// GET api/RegisteredSales/{id}/Expand
        /// Returns registered sales with related entities by Id.
        /// </summary>
        public async Task<RegisteredSaleExpand> RegisteredSalesExpandAsync(SalesTypeEnum type, int registeredSaleId)
        {
            return await GetAsync<RegisteredSaleExpand>(ResourceUrl + "/" + (int)type + "/" + registeredSaleId + "/Expand");
        }

        /// <summary>
        /// GET api/RegisteredSales/Default
        /// Method returns empty registered sale with default values. Returned resource is suitable for creation of a new registered sale.
        /// </summary>
        public async Task<RegisteredSaleCreate> DefaultAsync()
        {
            return await GetAsync<RegisteredSaleCreate>(ResourceUrl + "/Default");
        }

        /// <summary>
        /// POST api/RegisteredSales/{type}/{id}
        /// Create new registered sale.
        /// </summary>
        public async Task<RegisteredSale> CreateAsync(SalesTypeEnum salesType, int salesDocumentId, RegisteredSaleCreate model)
        {
            return await PostAsync<RegisteredSale, RegisteredSaleCreate>(ResourceUrl + "/" + (int)salesType + "/" + salesDocumentId, model);
        }
    }
}