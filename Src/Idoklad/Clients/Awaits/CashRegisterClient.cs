using System.Threading.Tasks;
using IdokladSdk.ApiFilters;
using IdokladSdk.ApiModels;
using IdokladSdk.ApiModels.BaseModels;

namespace IdokladSdk.Clients
{
    public partial class CashRegisterClient : BaseClient
    {
        /// <summary>
        /// GET api/CashRegisters
        /// Method returns list of cash registers.
        /// </summary>
        public async Task<RowsResultWrapper<CashRegister>> CashRegistersAsync(ApiFilter filter = null)
        {
            return await GetAsync<RowsResultWrapper<CashRegister>>(ResourceUrl, filter);
        }

        /// <summary>
        /// GET api/CashRegisters/{id}
        /// Method returns cash register by Id.
        /// </summary>
        public async Task<CashRegister> CashRegisterAsync(int cashRegisterId)
        {
            return await GetAsync<CashRegister>(ResourceUrl + "/" + cashRegisterId);
        }

        /// <summary>
        /// GET api/CashRegisters/Expand
        /// List of cash registers with related entities.
        /// </summary>
        public async Task<RowsResultWrapper<CashRegisterExpand>> CashRegistersExpandAsync(ApiFilter filter = null)
        {
            return await GetAsync<RowsResultWrapper<CashRegisterExpand>>(ResourceUrl + "/Expand", filter);
        }

        /// <summary>
        /// GET api/CashRegisters/{id}/Expand
        /// Returns cash register with related entities by Id.
        /// </summary>
        public async Task<CashRegisterExpand> CashRegisterExpandAsync(int cashRegisterId)
        {
            return await GetAsync<CashRegisterExpand>(ResourceUrl + "/" + cashRegisterId + "/Expand");
        }
    }
}