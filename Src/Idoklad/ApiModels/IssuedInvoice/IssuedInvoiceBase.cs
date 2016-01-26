using System;
using System.ComponentModel.DataAnnotations;
using IdokladSdk.ApiModels.BaseModels;
using IdokladSdk.Enums;

namespace IdokladSdk.ApiModels.IssuedInvoice
{
    public class IssuedInvoiceBase : ApiModel
    {
        /// <summary>
        /// Tax base - basic rate
        /// </summary>
        public decimal BaseTaxBasicRate { get; set; }

        /// <summary>
        /// Tax base - basic rate in home currency
        /// </summary>
        public decimal BaseTaxBasicRateHc { get; set; }

        /// <summary>
        /// Tax base - Reduce rate 1
        /// </summary>
        public decimal BaseTaxReducedRate1 { get; set; }

        /// <summary>
        /// Tax base - Reduce rate 1 in home currency
        /// </summary>
        public decimal BaseTaxReducedRate1Hc { get; set; }

        /// <summary>
        /// Tax base - Reduce rate 2
        /// </summary>
        public decimal BaseTaxReducedRate2 { get; set; }

        /// <summary>
        /// Tax base - Reduce rate 2 in home currency
        /// </summary>
        public decimal BaseTaxReducedRate2Hc { get; set; }

        /// <summary>
        /// Tax base - Zero rate
        /// </summary>
        public decimal BaseTaxZeroRate { get; set; }

        /// <summary>
        /// Tax base - Zero rate in home currency
        /// </summary>
        public decimal BaseTaxZeroRateHc { get; set; }

        /// <summary>
        /// Constant symbol Id
        /// </summary>
        public int ConstantSymbolId { get; set; }

        /// <summary>
        /// Currency Id
        /// </summary>
        public int CurrencyId { get; set; }

        /// <summary>
        /// Date last change
        /// </summary>
        public DateTime DateLastChange { get; set; }

        /// <summary>
        /// Date of accounting event
        /// </summary>
        public DateTime DateOfAccountingEvent { get; set; }

        /// <summary>
        /// Date of issue
        /// </summary>
        public DateTime DateOfIssue { get; set; }

        /// <summary>
        /// Date of last reminder
        /// </summary>
        public DateTime DateOfLastReminder { get; set; }

        /// <summary>
        /// Date of maturity
        /// </summary>
        public DateTime DateOfMaturity { get; set; }

        /// <summary>
        /// Date of payment
        /// </summary>
        public DateTime DateOfPayment { get; set; }

        /// <summary>
        /// Date of taxing
        /// </summary>
        public DateTime DateOfTaxing { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// DocumentNumber
        /// </summary>
        [StringLength(10)]
        public string DocumentNumber { get; set; }

        /// <summary>
        /// Document Serial Number
        /// </summary>
        public int DocumentSerialNumber { get; set; }

        /// <summary>
        /// Exchange rate
        /// </summary>
        public decimal ExchangeRate { get; set; }

        /// <summary>
        /// Exchange rate amount
        /// </summary>
        public decimal ExchangeRateAmount { get; set; }

        /// <summary>
        /// Export to another accounting software indication. (It is recommended to use only one external accounting software
        /// beside iDoklad.)
        /// </summary>
        public ExportedStateEnum Exported { get; set; }

        /// <summary>
        /// Indicate sending to accountant
        /// </summary>
        public bool IsSentToAccountant { get; set; }

        /// <summary>
        /// Indicate sending to purchaser
        /// </summary>
        public bool IsSentToPurchaser { get; set; }

        /// <summary>
        /// Items text prefix
        /// </summary>
        public string ItemsTextPrefix { get; set; }

        /// <summary>
        /// Items text suffix
        /// </summary>
        public string ItemsTextSuffix { get; set; }

        /// <summary>
        /// Report language Id
        /// </summary>
        public int LanguageId { get; set; }

        /// <summary>
        /// Maturity in days
        /// </summary>
        public short Maturity { get; set; }

        /// <summary>
        /// My company document address Id
        /// </summary>
        public int MyCompanyDocumentAdrressId { get; set; }

        /// <summary>
        /// Note
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
        public int PaymentOptionId { get; set; }

        /// <summary>
        /// Status of the payment
        /// </summary>
        public PaymentStatusEnum PaymentStatus { get; set; }

        /// <summary>
        /// Purchaser contact address ID
        /// </summary>
        public int PurchaserDocumentAddressId { get; set; }

        /// <summary>
        /// Purchase ID
        /// </summary>
        public int PurchaserId { get; set; }

        /// <summary>
        /// Count of sent reminders
        /// </summary>
        public int RemindersCount { get; set; }

        /// <summary>
        /// Report color in html color format
        /// </summary>
        public string ReportColorValue { get; set; }

        /// <summary>
        /// ID of the report type
        /// </summary>
        public int ReportId { get; set; }

        /// <summary>
        /// Rounding difference amount
        /// </summary>
        public decimal RoundingDifference { get; set; }

        /// <summary>
        /// Daň v základní sazbě v cizí měně
        /// </summary>
        public decimal TaxBasicRate { get; set; }

        /// <summary>
        /// Daň v základní sazbě v domácí měně
        /// </summary>
        public decimal TaxBasicRateHc { get; set; }

        /// <summary>
        /// Daň ve snížené sazbě 1 v cizí měně
        /// </summary>
        public decimal TaxReducedRate1 { get; set; }

        /// <summary>
        /// Daň ve snížené sazbě 1 v domácí měně
        /// </summary>
        public decimal TaxReducedRate1Hc { get; set; }

        /// <summary>
        /// Daň ve snížené sazbě 2 v cizí měně
        /// </summary>
        public decimal TaxReducedRate2 { get; set; }

        /// <summary>
        /// Daň ve snížené sazbě 2 v domácí měně
        /// </summary>
        public decimal TaxReducedRate2Hc { get; set; }

        /// <summary>
        /// Celková částka v základní sazbě v cizí měně
        /// </summary>
        public decimal TotalBasicRate { get; set; }

        /// <summary>
        /// Celková částka v základní sazbě v domácí měně
        /// </summary>
        public decimal TotalBasicRateHc { get; set; }

        /// <summary>
        /// Celková částka ve snížené sazbě 1 v cizí měně
        /// </summary>
        public decimal TotalReducedRate1 { get; set; }

        /// <summary>
        /// Celková částka ve snížené sazbě 1 v domácí měně
        /// </summary>
        public decimal TotalReducedRate1Hc { get; set; }

        /// <summary>
        /// Celková částka ve snížené sazbě 2 v cizí měně
        /// </summary>
        public decimal TotalReducedRate2 { get; set; }

        /// <summary>
        /// Celková částka ve snížené sazbě 2 v domácí měně
        /// </summary>
        public decimal TotalReducedRate2Hc { get; set; }

        /// <summary>
        /// Celková daň v cizí měně
        /// </summary>
        public decimal TotalVat { get; set; }

        /// <summary>
        /// Celková daň v domácí měně
        /// </summary>
        public decimal TotalVatHc { get; set; }

        /// <summary>
        /// Celková částka s daní v cizí měně
        /// </summary>
        public decimal TotalWithVat { get; set; }

        /// <summary>
        /// Celková částka s daní v domácí měně
        /// </summary>
        public decimal TotalWithVatHc { get; set; }

        /// <summary>
        /// Celková částka bez daně v cizí měně
        /// </summary>
        public decimal TotalWithoutVat { get; set; }

        /// <summary>
        /// Celková částka bez daně v domácí měně
        /// </summary>
        public decimal TotalWithoutVatHc { get; set; }

        /// <summary>
        /// Discount for invoice
        /// </summary>
        public decimal Discount { get; set; }

        /// <summary>
        /// Variabilní symbol
        /// </summary>
        [StringLength(10)]
        public string VariableSymbol { get; set; }

        /// <summary>
        /// Základní sazba daně
        /// </summary>
        public decimal VatRateBasic { get; set; }

        /// <summary>
        /// Snížena sazba daně 1
        /// </summary>
        public decimal VatRateReduced1 { get; set; }

        /// <summary>
        /// Snížena sazba daně 2
        /// </summary>
        public decimal VatRateReduced2 { get; set; }
    }
}