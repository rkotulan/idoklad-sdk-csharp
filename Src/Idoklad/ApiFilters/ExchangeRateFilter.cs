namespace IdokladSdk.ApiFilters
{
    /// <summary>
    /// Custom filter for exchange rate
    /// </summary>
    public class ExchangeRateFilter : FilterableObjectBase
    {
        public FilterItem CurrencyId { get; set; } = new FilterItem("CurrencyId");
        public CompareFilterItem Date { get; set; } = new CompareFilterItem("Date");
        public FilterItem ExchangeListId { get; set; } = new FilterItem("ExchangeListId");
    }
}