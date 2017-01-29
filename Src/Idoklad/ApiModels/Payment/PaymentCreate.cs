using System;
using System.ComponentModel.DataAnnotations;

namespace IdokladSdk.ApiModels
{
    public class PaymentCreate
    {
        /// <summary>
        /// Date of payment
        /// </summary>
        public DateTime DateOfPayment { get; set; }

        /// <summary>
        /// Date of vat application
        /// </summary>
        public DateTime DateOfVatApplication { get; set; }

        public string Exported { get; set; } = "0";

        /// <summary>
        /// Document Id
        /// </summary>
        [Required]
        public int InvoiceId { get; set; }

        /// <summary>
        /// Payment ammount
        /// </summary>
        public decimal PaymentAmount { get; set; }

        /// <summary>
        /// Payment option id
        /// </summary>
        public int PaymentOptionId { get; set; }
    }
}