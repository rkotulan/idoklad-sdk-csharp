using IdokladSdk.ApiModels.BaseModels;
using IdokladSdk.ApiModels.ReadOnlyEntites;

namespace IdokladSdk.Clients
{
    public class CurrencyClient : BaseClient
    {
        internal const string ResourceUrl = "/Currencies";

        public CurrencyClient(ApiContext apiContext)
            : base(apiContext)
        {
        }

        /// <summary>
        /// GET api/Currencies/GetChanges
        /// Method returns list of currencies, that were changed.
        /// </summary>
        public RowsResultWrapper<Currency> Changes()
        {
            return base.Get<RowsResultWrapper<Currency>>(ResourceUrl + "/GetChanges");
        }

        /// <summary>
        /// api/Currencies
        /// Method returns list of currencies.
        /// </summary>
        public RowsResultWrapper<Currency> Currencies()
        {
            return base.Get<RowsResultWrapper<Currency>>(ResourceUrl);
        }

        /// <summary>
        /// api/Currencies/{id}
        /// Method returns currency by Id.
        /// </summary>
        public Currency Currency(int currencyId)
        {
            return base.Get<Currency>(ResourceUrl + "/" + currencyId);
        }
    }
}