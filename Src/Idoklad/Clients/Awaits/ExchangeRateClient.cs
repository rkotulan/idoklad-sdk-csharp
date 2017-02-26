using System;
using System.Threading.Tasks;
using IdokladSdk.ApiFilters;
using IdokladSdk.ApiModels.BaseModels;
using IdokladSdk.ApiModels.ReadOnlyEntites;

namespace IdokladSdk.Clients
{
    /// <summary>
    /// Method for exchange rates.
    /// </summary>
    public partial class ExchangeRateClient : BaseClient
    {
        /// <summary>
        /// GET api/ExchangeRates/GetChanges
        /// Method returns list of exchange rates, that were changed.
        /// </summary>
        public async Task<RowsResultWrapper<ExchangeRate>> ChangesAsync(DateTime lastCheck, ApiFilter filter = null)
        {
            return await GetAsync<RowsResultWrapper<ExchangeRate>>(ResourceUrl + "/GetChanges" + "?lastCheck=" + lastCheck.ToString(ApiContextConfiguration.DateFormat), filter);
        }

        /// <summary>
        /// GET api/ExchangeRates
        /// Method returns list of exchange rates.
        /// </summary>
        public async Task<RowsResultWrapper<ExchangeRate>> ExchangeRatesAsync(ApiFilter filter = null)
        {
            return await GetAsync<RowsResultWrapper<ExchangeRate>>(ResourceUrl, filter);
        }

        /// <summary>
        /// GET api/ExchangeRates/{id}
        /// Method returns exchange rate by Id.
        /// </summary>
        public async Task<ExchangeRate> ExchangeRateAsync(int exchangeRateId)
        {
            return await GetAsync<ExchangeRate>(ResourceUrl + "/" + exchangeRateId);
        }
    }
}