using System;
using IdokladSdk.ApiFilters;
using IdokladSdk.ApiModels.BaseModels;
using IdokladSdk.ApiModels.ReadOnlyEntites;

namespace IdokladSdk.Clients
{
    /// <summary>
    /// Method for currencies.
    /// </summary>
    public class CurrencyClient : BaseClient
    {
        public const string ResourceUrl = "/Currencies";

        public CurrencyClient(ApiContext apiContext)
            : base(apiContext)
        {
        }

        /// <summary>
        /// GET api/Currencies/GetChanges
        /// Method returns list of currencies, that were changed.
        /// </summary>
        public RowsResultWrapper<Currency> Changes(ChangeFilter filter)
        {
            return Get<RowsResultWrapper<Currency>>(ResourceUrl + "/GetChanges", filter);
        }

        /// <summary>
        /// api/Currencies
        /// Method returns list of currencies.
        /// </summary>
        public RowsResultWrapper<Currency> Currencies()
        {
            return Get<RowsResultWrapper<Currency>>(ResourceUrl);
        }

        /// <summary>
        /// api/Currencies/{id}
        /// Method returns currency by Id.
        /// </summary>
        public Currency Currency(int currencyId)
        {
            return Get<Currency>(ResourceUrl + "/" + currencyId);
        }
    }
}