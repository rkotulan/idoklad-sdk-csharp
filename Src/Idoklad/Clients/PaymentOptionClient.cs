using IdokladSdk.ApiModels.BaseModels;
using IdokladSdk.ApiModels.ReadOnlyEntites;

namespace IdokladSdk.Clients
{
    /// <summary>
    /// Method for payment options.
    /// </summary>
    public class PaymentOptionClient : BaseClient
    {
        internal const string ResourceUrl = "/PaymentOptions";

        public PaymentOptionClient(ApiContext apiContext) : base(apiContext)
        {
        }

        /// <summary>
        /// GET api/PaymentOptions/GetChanges
        /// Method returns list of payment options, that were changed.
        /// </summary>
        public RowsResultWrapper<PaymentOption> Changes()
        {
            return base.Get<RowsResultWrapper<PaymentOption>>(ResourceUrl + "/GetChanges");
        }

        /// <summary>
        /// GET api/PaymentOptions
        /// Method returns list of payment options.
        /// </summary>
        public RowsResultWrapper<PaymentOption> PaymentOptions()
        {
            return base.Get<RowsResultWrapper<PaymentOption>>(ResourceUrl);
        }

        /// <summary>
        /// GET api/PaymentOptions/{id}
        /// Method returns payment option by Id.
        /// </summary>
        public PaymentOption PaymentOption(int paymentOptionId)
        {
            return base.Get<PaymentOption>(ResourceUrl + "/" + paymentOptionId);
        }
    }
}