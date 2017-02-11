namespace IdokladSdk.ApiFilters
{
    /// <summary>
    /// Custom filter for cash register
    /// </summary>
    public class CashRegisterFilter : FilterableObjectBase
    {
        public FilterItem CurrencyId { get; set; } = new FilterItem("CurrencyId");
    }
}