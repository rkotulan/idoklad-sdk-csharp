namespace IdokladSdk.ApiFilters
{
    /// <summary>
    /// Custom filter for price list
    /// </summary>
    public class PriceListFilter : FilterableObjectBase
    {
        public FilterItem Id { get; set; } = new FilterItem("Id");
        public FilterItem CurrencyId { get; set; } = new FilterItem("CurrencyId");
        public ContainFilterItem Name { get; set; } = new ContainFilterItem("Name");
        public CompareFilterItem DateLastChange { get; set; } = new CompareFilterItem("DateLastChange");
    }
}