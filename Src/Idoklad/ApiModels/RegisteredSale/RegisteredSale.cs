using System;
using IdokladSdk.ApiModels.BaseModels;
using IdokladSdk.Enums;

namespace IdokladSdk.ApiModels
{
    public class RegisteredSale : IApiModel
    {
        public int Id { get; set; }

        /// <summary>
        /// Base tax basic rate
        /// </summary>
        public decimal BaseTaxBasicRateHc { get; set; }

        /// <summary>
        /// Base tax first reduced rate
        /// </summary>
        public decimal BaseTaxReducedRate1Hc { get; set; }

        /// <summary>
        /// Base tax second reduced rate
        /// </summary>
        public decimal BaseTaxReducedRate2Hc { get; set; }

        /// <summary>
        /// Base tax zero rate
        /// </summary>
        public decimal BaseTaxZeroRateHc { get; set; }

        /// <summary>
        /// Taxpayers security code
        /// </summary>
        public string Bkp { get; set; }

        /// <summary> 
        /// The cash voucher id.
        /// </summary>
        public int? CashVoucherId { get; set; }

        /// <summary>
        /// Date of sale
        /// </summary>
        public DateTime DateOfSale { get; set; }

        /// <summary>
        /// Document number
        /// </summary>
        public string DocumentNumber { get; set; }

        /// <summary>
        /// Document type
        /// </summary>
        public DocumentTypeEnum DocumentType { get; set; }

        /// <summary>
        /// Eet regime
        /// </summary>
        public EetRegimeEnum EetRegime { get; set; }

        /// <summary>
        /// Issued invoice id
        /// </summary>
        public int? IssuedInvoiceId { get; set; }

        /// <summary>
        /// Canceled registered sale id
        /// </summary>
        public int? CancelledRegisteredSaleId { get; set; }

        /// <summary>
        /// Payment id
        /// </summary>
        public int? IssuedInvoicePaymentId { get; set; }

        /// <summary>
        /// Taxpayers signature code
        /// </summary>
        public string Pkp { get; set; }

        /// <summary>
        /// Receipt number
        /// </summary>
        public string ReceiptNumber { get; set; }

        /// <summary>
        /// Sales office designation
        /// </summary>
        public int SalesOfficeDesignation { get; set; }

        /// <summary>
        /// Point of sale equipment designation
        /// </summary>
        public string SalesPosEquipmentDesignation { get; set; }

        /// <summary>
        /// Point of sale equipment id
        /// </summary>
        public int? SalesPosEquipmentId { get; set; }

        /// <summary>
        /// Sales receipt id
        /// </summary>
        public int? SalesReceiptId { get; set; }

        /// <summary>
        /// Tax basic rate
        /// </summary>
        public decimal TaxBasicRateHc { get; set; }

        /// <summary>
        /// Tax first reduced rate
        /// </summary>
        public decimal TaxReducedRate1Hc { get; set; }

        /// <summary>
        /// Tax second reduced rate
        /// </summary>
        public decimal TaxReducedRate2Hc { get; set; }

        /// <summary>
        /// Total advance payment
        /// </summary>
        public decimal TotalAdvancePayment { get; set; }

        /// <summary>
        /// Total from advance payment
        /// </summary>
        public decimal TotalFromAdvancePayment { get; set; }

        /// <summary>
        /// Total travel service
        /// </summary>
        public decimal TotalTravelServiceHc { get; set; }

        /// <summary>
        /// Total used goods
        /// </summary>
        public decimal TotalUsedGoodsBasicRateHc { get; set; }

        /// <summary>
        /// Total used goods first reduced rate
        /// </summary>
        public decimal TotalUsedGoodsReducedRate1Hc { get; set; }

        /// <summary>
        /// Total used goods second reduced rate
        /// </summary>
        public decimal TotalUsedGoodsReducedRate2Hc { get; set; }

        /// <summary>
        /// Total with vat
        /// </summary>
        public decimal TotalWithVatHc { get; set; }

        /// <summary>
        /// VAT of taxpayer
        /// </summary>
        public string VatIdentificationNumber { get; set; }

        /// <summary>
        /// Date of answer
        /// </summary>
        public DateTime DateOfAnswer { get; set; }

        /// <summary>
        /// Date of send
        /// </summary>
        public DateTime DateOfSend { get; set; }

        /// <summary>
        /// Error code
        /// </summary>
        public int ErrorCode { get; set; }

        /// <summary>
        /// Error text
        /// </summary>
        public string ErrorText { get; set; }

        /// <summary>
        /// Fiscal identification code
        /// </summary>
        public string Fik { get; set; }

        /// <summary>
        /// Is canceled
        /// </summary>
        public bool IsCanceled { get; set; }

        /// <summary>
        /// Is first report
        /// </summary>
        public bool IsFirstReport { get; set; }

        /// <summary>
        /// Universally unique identifier
        /// </summary>
        public Guid Uuid { get; set; }
    }
}
