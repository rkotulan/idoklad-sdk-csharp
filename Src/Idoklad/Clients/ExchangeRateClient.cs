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
        /// GET api/ExchangeRates
        /// Method returns list of exchange rates.
        /// </summary>
        public RowsResultWrapper<ExchangeRate> ExchangeRates()
        {
            return Get<RowsResultWrapper<ExchangeRate>>(ResourceUrl);
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