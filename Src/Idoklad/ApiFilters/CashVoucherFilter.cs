namespace IdokladSdk.ApiFilters
{
    /// <summary>
    /// Custom filter for cash voucher
    /// </summary>
    public class CashVoucherFilter : FilterableObjectBase
    {
        public FilterItem Id { get; set; } = new FilterItem("Id");
        public FilterItem CashRegisterId { get; set; } = new FilterItem("CashRegisterId");
        public FilterItem CurrencyId { get; set; } = new FilterItem("CurrencyId");
        public FilterItem Exported { get; set; } = new FilterItem("Exported");
        public FilterItem MovementType { get; set; } = new FilterItem("MovementType");
        public CompareFilterItem DateLastChange { get; set; } = new CompareFilterItem("DateLastChange");
        public CompareFilterItem DateOfTransaction { get; set; } = new CompareFilterItem("DateOfTransaction");
        public ContainFilterItem DocumentNumber { get; set; } = new ContainFilterItem("DocumentNumber");
    }
}