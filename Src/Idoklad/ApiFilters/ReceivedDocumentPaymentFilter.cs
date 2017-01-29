using System;

namespace IdokladSdk.ApiFilters
{
    public class ReceivedDocumentPaymentFilter : Paging, IApiFilter
    {
        public int? Id { get; set; }
        public int? InvoiceId { get; set; }
        public int? PaymentOptionId { get; set; }
        public DateTime? DateOfPayment { get; set; }
    }
}