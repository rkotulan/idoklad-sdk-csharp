using System.Threading.Tasks;
using IdokladSdk.ApiFilters;
using IdokladSdk.ApiModels;
using IdokladSdk.ApiModels.BaseModels;

namespace IdokladSdk.Clients
{
    public partial class SalesOfficeClient : BaseClient
    {
        /// <summary>
        /// GET api/SalesOffices
        /// Method returns list of sales offices.
        /// </summary>
        public async Task<RowsResultWrapper<SalesOffice>> SalesOfficesAsync(ApiFilter paging = null)
        {
            return await GetAsync<RowsResultWrapper<SalesOffice>>(ResourceUrl, paging);
        }
    }
}