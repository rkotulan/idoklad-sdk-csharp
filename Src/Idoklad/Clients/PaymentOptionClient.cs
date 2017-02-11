using System;
using IdokladSdk.ApiFilters;
using IdokladSdk.ApiModels.BaseModels;
using IdokladSdk.ApiModels.ReadOnlyEntites;

namespace IdokladSdk.Clients
{
    /// <summary>
    /// Method for payment options.
    /// </summary>
    public class PaymentOptionClient : BaseClient
    {
        public const string ResourceUrl = "/PaymentOptions";

        public PaymentOptionClient(ApiContext apiContext) : base(apiContext)
        {
        }

        /// <summary>
        /// GET api/PaymentOptions/GetChanges
        /// Method returns list of payment options, that were changed.
        /// </summary>
        public RowsResultWrapper<PaymentOption> Changes(DateTime lastCheck, ApiFilter filter = null)
        {
            return Get<RowsResultWrapper<PaymentOption>>(ResourceUrl + "/GetChanges" + "?lastCheck" + lastCheck.ToString(ApiContext.Configuration.DateFormat), filter);
        }

        /// <summary>
        /// GET api/PaymentOptions
        /// Method returns list of payment options.
        /// </summary>
        public RowsResultWrapper<PaymentOption> PaymentOptions(PageFilter paging = null)
        {
            return Get<RowsResultWrapper<PaymentOption>>(ResourceUrl, paging);
        }

        /// <summary>
        /// GET api/PaymentOptions/{id}
        /// Method returns payment option by Id.
        /// </summary>
        public PaymentOption PaymentOption(int paymentOptionId)
        {
            return Get<PaymentOption>(ResourceUrl + "/" + paymentOptionId);
        }
    }
}