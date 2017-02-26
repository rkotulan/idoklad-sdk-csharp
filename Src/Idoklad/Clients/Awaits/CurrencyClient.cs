using System;
using System.Threading.Tasks;
using IdokladSdk.ApiFilters;
using IdokladSdk.ApiModels.BaseModels;
using IdokladSdk.ApiModels.ReadOnlyEntites;

namespace IdokladSdk.Clients
{
    /// <summary>
    /// Method for currencies.
    /// </summary>
    public partial class CurrencyClient : BaseClient
    {
        /// <summary>
        /// GET api/Currencies/GetChanges
        /// Method returns list of currencies, that were changed.
        /// </summary>
        public async Task<RowsResultWrapper<Currency>> ChangesAsync(DateTime lastCheck, ApiFilter filter = null)
        {
            return await GetAsync<RowsResultWrapper<Currency>>(ResourceUrl + "/GetChanges"  + "?lastCheck=" + lastCheck.ToString(ApiContextConfiguration.DateFormat), filter);
        }

        /// <summary>
        /// api/Currencies
        /// Method returns list of currencies.
        /// </summary>
        public async Task<RowsResultWrapper<Currency>> CurrenciesAsync(ApiFilter filter = null)
        {
            return await GetAsync<RowsResultWrapper<Currency>>(ResourceUrl, filter);
        }

        /// <summary>
        /// api/Currencies/{id}
        /// Method returns currency by Id.
        /// </summary>
        public async Task<Currency> CurrencyAsync(int currencyId)
        {
            return await GetAsync<Currency>(ResourceUrl + "/" + currencyId);
        }
    }
}