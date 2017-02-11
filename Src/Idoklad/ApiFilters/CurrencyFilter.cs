namespace IdokladSdk.ApiFilters
{
    /// <summary>
    /// Custom filter for currency
    /// </summary>
    public class CurrencyFilter : FilterableObjectBase
    {
        public FilterItem Code { get; set; } = new FilterItem("Code");
    }
}