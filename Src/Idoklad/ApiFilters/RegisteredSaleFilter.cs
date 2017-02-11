namespace IdokladSdk.ApiFilters
{
    /// <summary>
    /// Custom filter for registered sale
    /// </summary>
    public class RegisteredSaleFilter : FilterableObjectBase
    {
        public FilterItem Id { get; set; } = new FilterItem("Id");
        public FilterItem SalesReceiptId { get; set; } = new FilterItem("SalesReceiptId");
        public FilterItem CashVoucherId { get; set; } = new FilterItem("CashVoucherId");
        public FilterItem IssuedInvoicePaymentId { get; set; } = new FilterItem("IssuedInvoicePaymentId");
        public FilterItem SalesPosEquipmentId { get; set; } = new FilterItem("SalesPosEquipmentId");
        public FilterItem DocumentType { get; set; } = new FilterItem("DocumentType");
        public ContainFilterItem DocumentNumber { get; set; } = new ContainFilterItem("DocumentNumber");
        public FilterItem DateOfSale { get; set; } = new FilterItem("DateOfSale");
    }
}