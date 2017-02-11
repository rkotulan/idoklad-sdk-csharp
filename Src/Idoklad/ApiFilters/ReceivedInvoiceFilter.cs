namespace IdokladSdk.ApiFilters
{
    /// <summary>
    /// Custom filter for recived invoice
    /// </summary>
    public class ReceivedInvoiceFilter : IssuedInvoiceFilter
    {
        public FilterItem PaymentStatus { get; set; } = new FilterItem("PaymentStatus");
        public CompareFilterItem DateOfReceiving { get; set; } = new CompareFilterItem("DateOfReceiving");
    }
}