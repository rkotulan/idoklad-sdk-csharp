using IdokladSdk.ApiModels.BaseModels;
using IdokladSdk.ApiModels.ReadOnlyEntites;

namespace IdokladSdk.Clients
{
    /// <summary>
    /// Method for work with Vat rates.
    /// </summary>
    public class VatRateClient : BaseClient
    {
        internal const string ResourceUrl = "/VatRates";

        public VatRateClient(ApiContext apiContext) : base(apiContext)
        {
        }

        /// <summary>
        /// GET api/VatRates/GetChanges
        /// Method returns list of the VAT rates that were changed
        /// </summary>
        public RowsResultWrapper<VatRate> Changes()
        {
            return base.Get<RowsResultWrapper<VatRate>>(ResourceUrl + "/GetChanges");
        }

        /// <summary>
        /// GET api/VatRates
        /// Method returns list of Vat rates.
        /// </summary>
        public RowsResultWrapper<VatRate> VatRates()
        {
            return base.Get<RowsResultWrapper<VatRate>>(ResourceUrl);
        }

        /// <summary>
        /// GET api/VatRates/{id}
        /// Method returns Vat rate by Id.
        /// </summary>
        public VatRate VatRate(int vatRateId)
        {
            return base.Get<VatRate>(ResourceUrl + "/" + vatRateId);
        }
    }
}