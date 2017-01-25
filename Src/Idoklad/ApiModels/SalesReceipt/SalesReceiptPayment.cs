namespace IdokladSdk.ApiModels
{
    public class SalesReceiptPayment
    {
        /// <summary>
        /// Payment amount
        /// </summary>
        public decimal PaymentAmount { get; set; }

        /// <summary>
        /// PaymentApiModel id.
        /// </summary>
        public int PaymentOptionId { get; set; }

        /// <summary>
        /// Payment transaction code.
        /// </summary>
        public string PaymentTransactionCode { get; set; }

        /// <summary>
        /// Sales receipt id.
        /// </summary>
        public int SalesReceiptId { get; set; }
    }
}