namespace IdokladSdk.ApiFilters
{
    /// <summary>
    /// Custom filter for sales office
    /// </summary>
    public class SalesOfficeFilter : FilterableObjectBase
    {
        public FilterItem Id { get; set; } = new FilterItem("Id");
    }
}