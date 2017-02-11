using IdokladSdk.ApiFilters;
using IdokladSdk.ApiModels;
using IdokladSdk.ApiModels.BaseModels;

namespace IdokladSdk.Clients
{
    public class CashRegisterClient : BaseClient
    {
        public const string ResourceUrl = "/CashRegisters";

        public CashRegisterClient(ApiContext apiContext) : base(apiContext)
        {
        }

        /// <summary>
        /// GET api/CashRegisters
        /// Method returns list of cash registers.
        /// </summary>
        public RowsResultWrapper<CashRegister> CashRegisters(ApiFilter filter = null)
        {
            return Get<RowsResultWrapper<CashRegister>>(ResourceUrl, filter);
        }

        /// <summary>
        /// GET api/CashRegisters/{id}
        /// Method returns cash register by Id.
        /// </summary>
        public CashRegister CashRegister(int cashRegisterId)
        {
            return Get<CashRegister>(ResourceUrl + "/" + cashRegisterId);
        }

        /// <summary>
        /// GET api/CashRegisters/Expand
        /// List of cash registers with related entities.
        /// </summary>
        public RowsResultWrapper<CashRegisterExpand> CashRegistersExpand(ApiFilter filter = null)
        {
            return Get<RowsResultWrapper<CashRegisterExpand>>(ResourceUrl + "/Expand", filter);
        }

        /// <summary>
        /// GET api/CashRegisters/{id}/Expand
        /// Returns cash register with related entities by Id.
        /// </summary>
        public CashRegisterExpand CashRegisterExpand(int cashRegisterId)
        {
            return Get<CashRegisterExpand>(ResourceUrl + "/" + cashRegisterId + "/Expand");
        }
    }
}