using System;

namespace IdokladSdk.ApiModels
{
    public class RegisteredSalesInformation
    {
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
        /// Date of answer
        /// </summary>
        public DateTime DateOfAnswer { get; set; }

        /// <summary>
        /// Date of sale
        /// </summary>
        public DateTime DateOfSale { get; set; }

        /// <summary>
        /// Date of send
        /// </summary>
        public DateTime DateOfSend { get; set; }

        /// <summary>
        /// Fiscal identification code
        /// </summary>
        public string Fik { get; set; }

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
        /// Point of sale equipment id
        /// </summary>
        public int? SalesPosEquipmentId { get; set; }

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
        /// Universally unique identifier
        /// </summary>
        public Guid Uuid { get; set; }

        /// <summary>
        /// VAT of taxpayer
        /// </summary>
        public string VatIdentificationNumber { get; set; }
    }
}