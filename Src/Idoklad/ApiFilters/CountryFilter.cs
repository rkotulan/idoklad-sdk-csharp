namespace IdokladSdk.ApiFilters
{
    /// <summary>
    /// Custom filter for country
    /// </summary>
    public class CountryFilter : FilterableObjectBase
    {
        public ContainFilterItem Code { get; set; } = new ContainFilterItem("Code");
        public FilterItem CurrencyId { get; set; } = new FilterItem("CurrencyId");
        public CompareFilterItem DateLastChange { get; set; } = new CompareFilterItem("DateLastChange");
    }
}