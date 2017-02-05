namespace IdokladSdk.ApiFilters
{
    /// <summary>
    /// Custom filter for cash register
    /// </summary>
    public class CashRegisterFilter : ApiFilter, IApiFilter
    {
        public int? Id { get; set; }
        public int? CurrencyId { get; set; }
    }
}