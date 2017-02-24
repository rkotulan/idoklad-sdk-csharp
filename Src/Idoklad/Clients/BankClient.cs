using System;
using System.Threading.Tasks;
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
        public RowsResultWrapper<Bank> Changes(DateTime lastCheck, ApiFilter filter = null)
        {
            return Get<RowsResultWrapper<Bank>>(ResourceUrl + "/GetChanges" + "?lastCheck=" + lastCheck.ToString(ApiContextConfiguration.DateFormat), filter);
        }

        /// <summary>
        /// GET api/Banks/GetChanges
        /// Method returns list of banks, that were changed.
        /// </summary>
        public async Task<RowsResultWrapper<Bank>> ChangesAsync(DateTime lastCheck, ApiFilter filter = null)
        {
            return await GetAsync<RowsResultWrapper<Bank>>(ResourceUrl + "/GetChanges" + "?lastCheck=" + lastCheck.ToString(ApiContextConfiguration.DateFormat), filter);
        }

        /// <summary>
        /// GET api/Banks
        /// Method returns list of banks.
        /// </summary>
        public RowsResultWrapper<Bank> Banks(ApiFilter filter = null)
        {
            return Get<RowsResultWrapper<Bank>>(ResourceUrl, filter);
        }

        /// <summary>
        /// GET api/Banks
        /// Method returns list of banks.
        /// </summary>
        public async Task<RowsResultWrapper<Bank>> BanksAsync(ApiFilter filter = null)
        {
            return await GetAsync<RowsResultWrapper<Bank>>(ResourceUrl, filter);
        }

        /// <summary>
        /// GET api/Banks/{id}
        /// Method returns bank by Id.
        /// </summary>
        public Bank Bank(int bankAccountId)
        {
            return Get<Bank>(ResourceUrl + "/" + bankAccountId);
        }

        /// <summary>
        /// GET api/Banks/{id}
        /// Method returns bank by Id.
        /// </summary>
        public async Task<Bank> BankAsync(int bankAccountId)
        {
            return await GetAsync<Bank>(ResourceUrl + "/" + bankAccountId);
        }
    }
}