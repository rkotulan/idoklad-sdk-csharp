using System;

namespace IdokladSdk.ApiFilters
{
    /// <summary>
    /// Custom filter for credit notes
    /// </summary>
    public class CreditNoteFilter : Paging, IApiFilter
    {
        public int? ConstantSymbolId { get; set; }
        public int? CurrencyId { get; set; }
        public DateTime? DateLastChange { get; set; }
        public DateTime? DateOfIssue { get; set; }
        public DateTime? DateOfPayment { get; set; }
        public FilterType? Filter { get; set; }
        public FilterType? FilterExported { get; set; }
        public bool? IsPaid { get; set; }
        public string Query { get; set; }
    }
}