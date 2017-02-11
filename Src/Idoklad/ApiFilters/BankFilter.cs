namespace IdokladSdk.ApiFilters
{
    /// <summary>
    /// Custom filter for bank
    /// </summary>
    public class BankFilter : FilterableObjectBase
    {
        public FilterItem CountryId { get; set; } = new FilterItem("CountryId");
        public CompareFilterItem DateLastChange { get; set; } = new CompareFilterItem("DateLastChange");
        public FilterItem IsOutOfDate { get; set; } = new FilterItem("IsOutOfDate");
    }
}