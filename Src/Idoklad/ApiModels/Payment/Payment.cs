using System;
using System.ComponentModel.DataAnnotations;
using IdokladSdk.ApiModels.BaseModels;
using IdokladSdk.Enums;
using IdokladSdk.ValidationAttributes;

namespace IdokladSdk.ApiModels
{
    public class Payment : IApiModel
    {
        public int Id { get; set; }

        /// <summary>
        /// Currency Id
        /// </summary>
        public int CurrencyId { get; set; }

        /// <summary>
        /// Date created
        /// </summary>
        public DateTime DateCreated { get; set; }

        /// <summary>
        /// Date last change
        /// </summary>
        public DateTime DateLastChange { get; set; }

        /// <summary>
        /// Date of payment
        /// </summary>
        public DateTime DateOfPayment { get; set; }

        /// <summary>
        /// Datum uplatnění DPH
        /// </summary>
        public DateTime DateOfVatApplication { get; set; }

        /// <summary>
        /// Exchange rate
        /// </summary>
        public decimal ExchangeRate { get; set; }

        /// <summary>
        /// Exchange rate amount
        /// </summary>
        public decimal ExchangeRateAmount { get; set; }

        /// <summary>
        /// Export to another accounting software indication. (It is recommended to use only one external accounting software beside iDoklad.)
        /// </summary>
        
        [ValidEnumValue]
        public ExportedStateEnum Exported { get; set; }

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
        /// Payment ammount in home currency
        /// </summary>
        public decimal PaymentAmountHc { get; set; }

        /// <summary>
        /// Payment option id
        /// </summary>
        public int PaymentOptionId { get; set; }
    }
}
