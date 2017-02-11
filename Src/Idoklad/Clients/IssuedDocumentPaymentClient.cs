using IdokladSdk.ApiFilters;
using IdokladSdk.ApiModels;
using IdokladSdk.ApiModels.BaseModels;
using IdokladSdk.Enums;

namespace IdokladSdk.Clients
{
    public class IssuedDocumentPaymentClient : BaseClient
    {
        public const string ResourceUrl = "/IssuedDocumentPayments";

        public IssuedDocumentPaymentClient(ApiContext apiContext) : base(apiContext)
        {
        }

        /// <summary>
        /// GET api/IssuedDocumentPayments/Default/{documentId}
        /// Method returns empty issued document payment with default values.
        /// </summary>
        public IssuedDocumentPaymentCreate Default(int documentId)
        {
            return Get<IssuedDocumentPaymentCreate>(ResourceUrl + "/Default"  + "/" + documentId);
        }

        /// <summary>
        /// GET api/IssuedDocumentPayments
        /// Returns list of payments.
        /// </summary>
        public RowsResultWrapper<IssuedDocumentPayment> IssuedDocumentPayments(ApiFilter filter)
        {
            return Get<RowsResultWrapper<IssuedDocumentPayment>>(ResourceUrl, filter);
        }

        /// <summary>
        /// GET api/IssuedDocumentPayments/{id}
        /// Returns information about a payment.
        /// </summary>
        public IssuedDocumentPayment IssuedDocumentPayment(int issuedDocumentPaymentId)
        {
            return Get<IssuedDocumentPayment>(ResourceUrl + "/" + issuedDocumentPaymentId);
        }

        /// <summary>
        /// GET api/IssuedDocumentPayments/Expand
        /// Returns list of payments with related entities such as document of payment.
        /// </summary>
        public RowsResultWrapper<IssuedDocumentPaymentExpand> IssuedDocumentPaymentsExpand(ApiFilter filter = null)
        {
            return Get<RowsResultWrapper<IssuedDocumentPaymentExpand>>(ResourceUrl + "/Expand", filter);
        }

        /// <summary>
        /// GET api/IssuedDocumentPayments/{id}/Expand
        /// Returns payment with related entities by Id.
        /// </summary>
        public IssuedDocumentPaymentExpand IssuedDocumentPaymentExpand(int issuedDocumentPaymentId)
        {
            return Get<IssuedDocumentPaymentExpand>(ResourceUrl + "/" + issuedDocumentPaymentId + "/Expand");
        }

        /// <summary>
        /// POST api/IssuedDocumentPayments
        /// Create new payment. Payment should contains id of payed document.
        /// </summary>
        public IssuedDocumentPayment Create(IssuedDocumentPaymentCreate invoice)
        {
            return Post<IssuedDocumentPayment, IssuedDocumentPaymentCreate>(ResourceUrl, invoice);
        }

        /// <summary>
        /// PUT api/IssuedDocumentPayments/{id}/Exported/{exported}
        /// Method updates Exported property of the payment.
        /// </summary>
        public IssuedInvoice Update(int paymentId, ExportedStateEnum  exportedState)
        {
            return Put<IssuedInvoice>(ResourceUrl + "/" + paymentId + "/" + (int)exportedState);
        }

        /// <summary>
        /// DELETE api/IssuedDocumentPayments/{id}
        /// Deletes payment by Id. If payment has cash voucher, it is deleted as well.
        /// </summary>
        public bool Delete(int invoiceId)
        {
            return Delete(ResourceUrl + "/" + invoiceId);
        }
    }
}