using System.ComponentModel.DataAnnotations;
using IdokladSdk.ApiModels.BaseModels;

namespace IdokladSdk.ApiModels
{
    public class SalesReceiptPaymentUpdate : IApiModel
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