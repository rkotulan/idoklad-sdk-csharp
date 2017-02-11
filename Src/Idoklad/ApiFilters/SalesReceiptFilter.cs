namespace IdokladSdk.ApiFilters
{
    /// <summary>
    /// Custom filter for sales receipt
    /// </summary>
    public class SalesReceiptFilter : FilterableObjectBase
    {
        public FilterItem Id { get; set; } = new FilterItem("Id");
        public CompareFilterItem DateOfIssue { get; set; } = new CompareFilterItem("DateOfIssue");
        public FilterItem Exported { get; set; } = new FilterItem("Exported");
        public FilterItem SalesPosEquipmentId { get; set; } = new FilterItem("SalesPosEquipmentId");
    }
}