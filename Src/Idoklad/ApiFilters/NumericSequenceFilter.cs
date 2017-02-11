namespace IdokladSdk.ApiFilters
{
    /// <summary>
    /// Custom filter for change
    /// </summary>
    public class NumericSequenceFilter : FilterableObjectBase
    {
        public FilterItem Id { get; set; } = new FilterItem("Id");
        public FilterItem IsDefault { get; set; } = new FilterItem("IsDefault");
        public FilterItem DocumentType { get; set; } = new FilterItem("DocumentType");

    }
}