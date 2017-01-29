using System;
using IdokladSdk.Enums;

namespace IdokladSdk.ApiFilters
{
    public class ReceivedInvoiceFilter : IssuedInvoiceFilter
    {
        public PaymentStatusEnum? PaymentStatus { get; set; }
        public DateTime? DateOfReceiving { get; set; }
    }
}