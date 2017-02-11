namespace IdokladSdk.ApiFilters
{
    /// <summary>
    /// Custom filter for constant symbol
    /// </summary>
    public class ConstantSymbolFilter : FilterableObjectBase
    {
        public FilterItem CountryId { get; set; } = new FilterItem("CountryId");
        public CompareFilterItem DateLastChange { get; set; } = new CompareFilterItem("DateLastChange");
    }
}