using System;

namespace IdokladSdk.ApiFilters
{
    /// <summary>
    /// Custom filter for price list items
    /// </summary>
    public class PriceListFilter : Paging, IApiFilter
    {
        public int? Id { get; set; }
        public int? CurrencyId { get; set; }
        public string Name { get; set; }
        public DateTime? DateLastChange { get; set; }
    }
}