using System;

namespace IdokladSdk.ApiFilters
{
    public class IssuedInvoiceFilter : Paging, IApiFilter
    {
        public int? ConstantSymbolId { get; set; }
        public int? CurrencyId { get; set; }
        public DateTime? DateLastChange { get; set; }
        public DateTime? DateOfIssue { get; set; }
        public DateTime? DateOfPayment { get; set; }
        public FilterType? Filter { get; set; }
        public FilterType? FilterExported { get; set; }
        public bool? IsPaid { get; set; }

        /// <summary>
        /// Search by invoice document number and invoice description
        /// </summary>
        public string Query { get; set; }
    }
}
