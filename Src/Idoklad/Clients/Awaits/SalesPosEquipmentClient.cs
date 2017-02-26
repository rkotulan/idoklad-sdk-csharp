using System.Threading.Tasks;
using IdokladSdk.ApiFilters;
using IdokladSdk.ApiModels;
using IdokladSdk.ApiModels.BaseModels;

namespace IdokladSdk.Clients
{
    public partial class SalesPosEquipmentClient : BaseClient
    {
        /// <summary>
        /// GET api/SalesPosEquipment
        /// Method returns list of sales pos equipments.
        /// </summary>
        public async Task<RowsResultWrapper<SalesPosEquipment>> SalesPosEquipmentAsync(ApiFilter filter = null)
        {
            return await GetAsync<RowsResultWrapper<SalesPosEquipment>>(ResourceUrl, filter);
        }

        /// <summary>
        /// GET api/SalesPosEquipment/Info
        /// Returns information about the paired device, including numeric sequence info.
        /// </summary>
        public async Task<SalesPosEquipmentInfo> InfoAsync()
        {
            return await GetAsync<SalesPosEquipmentInfo>(ResourceUrl + "/Info");
        }

        /// <summary>
        /// GET api/SalesPosEquipment/Expand
        /// Returns POS equipments list with related entities.
        /// </summary>
        public async Task<RowsResultWrapper<SalesPosEquipmentExpand>> ExpandAsync()
        {
            return await GetAsync<RowsResultWrapper<SalesPosEquipmentExpand>>(ResourceUrl + "/Expand");
        }
    }
}