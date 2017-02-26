using System;
using System.Threading.Tasks;
using IdokladSdk.ApiFilters;
using IdokladSdk.ApiModels.BaseModels;
using IdokladSdk.ApiModels.ReadOnlyEntites;

namespace IdokladSdk.Clients
{
    /// <summary>
    /// Method for payment options.
    /// </summary>
    public partial class PaymentOptionClient : BaseClient
    {
        /// <summary>
        /// GET api/PaymentOptions/GetChanges
        /// Method returns list of payment options, that were changed.
        /// </summary>
        public async Task<RowsResultWrapper<PaymentOption>> ChangesAsync(DateTime lastCheck, ApiFilter filter = null)
        {
            return await GetAsync<RowsResultWrapper<PaymentOption>>(ResourceUrl + "/GetChanges" + "?lastCheck" + lastCheck.ToString(ApiContextConfiguration.DateFormat), filter);
        }

        /// <summary>
        /// GET api/PaymentOptions
        /// Method returns list of payment options.
        /// </summary>
        public async Task<RowsResultWrapper<PaymentOption>> PaymentOptionsAsync(PageFilter paging = null)
        {
            return await GetAsync<RowsResultWrapper<PaymentOption>>(ResourceUrl, paging);
        }

        /// <summary>
        /// GET api/PaymentOptions/{id}
        /// Method returns payment option by Id.
        /// </summary>
        public async Task<PaymentOption> PaymentOptionAsync(int paymentOptionId)
        {
            return await GetAsync<PaymentOption>(ResourceUrl + "/" + paymentOptionId);
        }
    }
}