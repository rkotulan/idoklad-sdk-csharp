using System;

namespace IdokladSdk.ApiFilters
{
    public class ReceivedInvoiceFilter : Paging, IApiFilter
    {
        public int? CurrencyId { get; set; }
        public DateTime? DateLastChange { get; set; }
        public DateTime? DateOfIssue { get; set; }
        public DateTime? DateOfPayment { get; set; }
        public DateTime? DateOfReceiving { get; set; }
        public FilterType? Filter { get; set; }
        public FilterType? FilterExported { get; set; }
        public bool? IsPaid { get; set; }

        /// <summary>
        /// Search by invoice document number and invoice description
        /// </summary>
        public string Query { get; set; }
    }
}