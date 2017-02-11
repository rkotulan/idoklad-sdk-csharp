namespace IdokladSdk.ApiFilters
{
    /// <summary>
    /// Custom filter for payment
    /// </summary>
    public class PaymentFilter : FilterableObjectBase
    {
        public FilterItem Id { get; set; } = new FilterItem("Id");
        public FilterItem InvoiceId { get; set; } = new FilterItem("InvoiceId");
        public FilterItem PaymentOptionId { get; set; } = new FilterItem("PaymentOptionId");
        public CompareFilterItem DateOfPayment { get; set; } = new CompareFilterItem("DateOfPayment");
    }
}