using System;
using IdokladSdk.ApiFilters;
using IdokladSdk.ApiModels.BaseModels;
using IdokladSdk.ApiModels.ReadOnlyEntites;

namespace IdokladSdk.Clients
{
    /// <summary>
    /// Method for getting banks.
    /// </summary>
    public class BankClient : BaseClient
    {
        public const string ResourceUrl = "/Banks";

        public BankClient(ApiContext apiContext) : base(apiContext)
        {
        }

        /// <summary>
        /// GET api/Banks/GetChanges
        /// Method returns list of banks, that were changed.
        /// </summary>
        public RowsResultWrapper<Bank> Changes(ChangeFilter filter)
        {
            return Get<RowsResultWrapper<Bank>>(ResourceUrl + "/GetChanges", filter);
        }

        /// <summary>
        /// GET api/Banks
        /// Method returns list of banks.
        /// </summary>
        public RowsResultWrapper<Bank> Banks()
        {
            return Get<RowsResultWrapper<Bank>>(ResourceUrl);
        }

        /// <summary>
        /// GET api/Banks/{id}
        /// Method returns bank by Id.
        /// </summary>
        public Bank Bank(int bankAccountId)
        {
            return Get<Bank>(ResourceUrl + "/" + bankAccountId);
        }
    }
}