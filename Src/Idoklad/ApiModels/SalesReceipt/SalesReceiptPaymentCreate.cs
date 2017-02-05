using System.ComponentModel.DataAnnotations;

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
        [Required(AllowEmptyStrings = true)]
        [StringLength(20)]
        public string PaymentTransactionCode { get; set; }
    }
}