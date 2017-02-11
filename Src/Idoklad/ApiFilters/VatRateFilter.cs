namespace IdokladSdk.ApiFilters
{
    /// <summary>
    /// Custom filter for vat rate
    /// </summary>
    public class VatRateFilter : FilterableObjectBase
    {
        public FilterItem CountryId { get; set; } = new FilterItem("CountryId");
        public CompareFilterItem DateLastChange { get; set; } = new CompareFilterItem("DateLastChange");
        public CompareFilterItem DateValidityFrom { get; set; } = new CompareFilterItem("DateValidityFrom");
        public CompareFilterItem DateValidityTo { get; set; } = new CompareFilterItem("DateValidityTo");
        public FilterItem Type { get; set; } = new FilterItem("Type");
    }
}