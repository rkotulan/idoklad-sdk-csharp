using System;
using IdokladSdk.Enums;

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
        public DateTime? DateOfMaturity { get; set; }
        public ExportedStateEnum? Exported { get; set; }
        public string Description { get; set; }
        public int NumericSequenceId { get; set; }
        public string DocumentNumber { get; set; }
        public bool? IsPaid { get; set; }
    }
}