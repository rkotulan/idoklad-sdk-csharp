using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using IdokladSdk.ApiModels.BaseModels;
using IdokladSdk.Enums;

namespace IdokladSdk.ApiModels
{
    public class ProformaInvoiceUpdate : IApiModel
    {
        /// <summary>
        /// Bank account number
        /// </summary>
        [StringLength(50)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Bank Id from bank list
        /// </summary> 
        public int? BankId { get; set; }

        /// <summary>
        /// Name of the bank
        /// </summary>
        [StringLength(100)]
        public string BankName { get; set; }

        /// <summary>
        /// Code of the bank
        /// </summary>
        [StringLength(4)]
        public string BankNumberCode { get; set; }

        /// <summary>
        /// Constant symbol ID
        /// </summary>
        public int? ConstantSymbolId { get; set; }

        /// <summary>
        /// Currency ID
        /// </summary>
        public int? CurrencyId { get; set; }

        /// <summary>
        /// Date of invoice issue
        /// </summary>
        public DateTime? DateOfIssue { get; set; }

        /// <summary>
        /// Date of maturity
        /// </summary>
        public DateTime? DateOfMaturity { get; set; }

        /// <summary>
        /// Payment date
        /// </summary>
        public DateTime? DateOfPayment { get; set; }

        /// <summary>
        /// Description of ivoice
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Exchange rate
        /// </summary>
        public decimal? ExchangeRate { get; set; }

        /// <summary>
        /// Amount for exchange rate
        /// </summary>
        public decimal? ExchangeRateAmount { get; set; }

        /// <summary>
        /// Internation bank account number
        /// </summary>
        [StringLength(50)]
        public string Iban { get; set; }

        public ICollection<IssuedInvoiceItemUpdate> ProformaInvoiceItems { get; set; }

        /// <summary>
        /// Text before invoice items
        /// </summary>
        public string ItemsTextPrefix { get; set; }

        /// <summary>
        /// Text after invoice items
        /// </summary>
        public string ItemsTextSuffix { get; set; }

        /// <summary>
        /// Language code
        /// </summary>
        public string LanguageCode { get; set; }

        /// <summary>
        ///  Note
        /// </summary>
        public string Note { get; set; }

        /// <summary>
        /// Order number
        /// </summary>
        [StringLength(20)]
        public string OrderNumber { get; set; }

        /// <summary>
        /// Payment option ID
        /// </summary>
        public int? PaymentOptionId { get; set; }

        /// <summary>
        /// Purchaser ID
        /// </summary>
        public int? PurchaserId { get; set; }

        /// <summary>
        /// Report color - in HTML fromat
        /// </summary>
        public string ReportColorValue { get; set; }

        /// <summary>
        /// Swift code
        /// </summary>
        [StringLength(11)]
        public string Swift { get; set; }

        /// <summary>
        /// Variable number
        /// </summary>
        [StringLength(10)]
        public string VariableSymbol { get; set; }

        /// <summary>
        /// Attribute for application of VAT based on payments
        /// </summary>
        public VatOnPayStatusEnum? VatOnPayStatus { get; set; }

        /// <summary>
        /// Is proforma taxed
        /// </summary>
        public bool IsProformaTaxed { get; set; }
    }
}