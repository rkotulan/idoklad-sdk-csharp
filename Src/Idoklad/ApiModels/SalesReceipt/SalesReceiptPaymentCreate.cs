namespace IdokladSdk.ApiModels
{
    public class SalesReceiptPaymentCreate
    {
        /// <summary>
        /// Payment amount
        /// </summary>
        public decimal PaymentAmount { get; set; }

        /// <summary>
        /// Payment option id.
        /// </summary>
        public int PaymentOptionId { get; set; }

        /// <summary>
        /// Payment transaction code.
        /// </summary>
        public string PaymentTransactionCode { get; set; }
    }
}