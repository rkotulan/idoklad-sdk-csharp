using System;
using System.Threading.Tasks;
using IdokladSdk.ApiFilters;
using IdokladSdk.ApiModels.BaseModels;
using IdokladSdk.ApiModels.ReadOnlyEntites;

namespace IdokladSdk.Clients
{
    /// <summary>
    /// Method for work with Vat rates.
    /// </summary>
    public partial class VatRateClient : BaseClient
    {
        /// <summary>
        /// GET api/VatRates/GetChanges
        /// Method returns list of the VAT rates that were changed
        /// </summary>
        public async Task<RowsResultWrapper<VatRate>> ChangesAsync(ApiFilter filter)
        {
            return await GetAsync<RowsResultWrapper<VatRate>>(ResourceUrl + "/GetChanges", filter);
        }

        /// <summary>
        /// GET api/VatRates
        /// Method returns list of Vat rates.
        /// </summary>
        public async Task<RowsResultWrapper<VatRate>> VatRatesAsync(DateTime lastCheck, ApiFilter filter = null)
        {
            return await GetAsync<RowsResultWrapper<VatRate>>(ResourceUrl + "?lastCheck=" + lastCheck.ToString(ApiContextConfiguration.DateFormat), filter);
        }

        /// <summary>
        /// GET api/VatRates/{id}
        /// Method returns Vat rate by Id.
        /// </summary>
        public async Task<VatRate> VatRateAsync(int vatRateId)
        {
            return await GetAsync<VatRate>(ResourceUrl + "/" + vatRateId);
        }
    }
}