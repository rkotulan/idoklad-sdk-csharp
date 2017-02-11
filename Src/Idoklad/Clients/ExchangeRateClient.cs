using System;
using IdokladSdk.ApiFilters;
using IdokladSdk.ApiModels.BaseModels;
using IdokladSdk.ApiModels.ReadOnlyEntites;

namespace IdokladSdk.Clients
{
    /// <summary>
    /// Method for exchange rates.
    /// </summary>
    public class ExchangeRateClient : BaseClient
    {
        public const string ResourceUrl = "/ExchangeRates";

        public ExchangeRateClient(ApiContext apiContext) : base(apiContext)
        {
        }

        /// <summary>
        /// GET api/ExchangeRates/GetChanges
        /// Method returns list of exchange rates, that were changed.
        /// </summary>
        public RowsResultWrapper<ExchangeRate> Changes(DateTime lastCheck, ApiFilter filter = null)
        {
            return Get<RowsResultWrapper<ExchangeRate>>(ResourceUrl + "/GetChanges" + "?lastCheck=" + lastCheck.ToString(ApiContext.Configuration.DateFormat), filter);
        }

        /// <summary>
        /// GET api/ExchangeRates
        /// Method returns list of exchange rates.
        /// </summary>
        public RowsResultWrapper<ExchangeRate> ExchangeRates(ApiFilter filter = null)
        {
            return Get<RowsResultWrapper<ExchangeRate>>(ResourceUrl, filter);
        }

        /// <summary>
        /// GET api/ExchangeRates/{id}
        /// Method returns exchange rate by Id.
        /// </summary>
        public ExchangeRate ExchangeRate(int exchangeRateId)
        {
            return Get<ExchangeRate>(ResourceUrl + "/" + exchangeRateId);
        }
    }
}