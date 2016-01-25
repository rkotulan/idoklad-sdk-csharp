using System;

namespace IdokladSdk.ApiFilters
{
    /// <summary>
    /// Custom filter for price list items
    /// </summary>
    public class PriceListFilter : Paging, IApiFilter
    {
        public int? CurrencyId { get; set; }
        public DateTime? DateLastChange { get; set; }
        public FilterType? Filter { get; set; }
        public string Query { get; set; }
    }
}