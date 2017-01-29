using System;
using System.Collections.Generic;
using IdokladSdk.ApiModels.BaseModels;
using IdokladSdk.Enums;

namespace IdokladSdk.ApiModels
{
    public class SalesReceipt : ApiModel
    {
        /// <summary> 
        /// ID
        /// </summary>
        public int CurrencyId { get; set; }

        /// <summary>
        /// Date of issue
        /// </summary>
        public DateTime DateOfIssue { get; set; }

        /// <summary>
        /// DocumentNumber
        /// </summary>
        public string DocumentNumber { get; set; }

        /// <summary>
        /// Document Serial Number
        /// </summary>
        public int DocumentSerialNumber { get; set; }

        /// <summary>
        /// Responsibility for handlig of electronic records of sales
        /// </summary>
        public EetResponsibilityEnum EetResponsibility { get; set; }

        public EetStatusEnum EetStatus { get; set; }

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
        public ExportedStateEnum Exported { get; set; }

        /// <summary>
        /// Number assigned by external application.
        /// </summary>
        public string ExternalDocumentNumber { get; set; }

        /// <summary>
        /// Flag indicating whether the entity was imported from a different system.
        /// </summary>
        public ImportedStateEnum Imported { get; set; }

        /// <summary>
        /// Cummulative sales receipt
        /// </summary>
        public bool IsCumulative { get; set; }

        /// <summary>
        /// Flag indicating whether the sales receipt is registered in EET.
        /// </summary>
        public bool IsEet { get; set; }

        /// <summary>
        /// The name of the sales receipt.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Registered sale
        /// </summary>
        public RegisteredSale RegisteredSale { get; set; }

        /// <summary>
        /// <see cref="SalesPosEquipmentApiModel">POS equipment</see> Id.
        /// </summary>
        public int? SalesPosEquipmentId { get; set; }

        /// <summary>
        /// List of items.
        /// </summary>
        public virtual ICollection<SalesReceiptItem> SalesReceiptItems { get; set; }

        /// <summary>
        /// List of payments.
        /// </summary>
        public virtual ICollection<SalesReceiptPayment> SalesReceiptPayments { get; set; }

        /// <summary>
        /// Total amount of VAT in used currency
        /// </summary>
        public decimal TotalVat { get; set; }

        /// <summary>
        /// Total amount of VAT in home currency
        /// </summary>
        public decimal TotalVatHc { get; set; }

        /// <summary>
        /// Total amount without VAT in the used currency.
        /// </summary>
        public decimal TotalWithoutVat { get; set; }

        /// <summary>
        /// Total amount without VAT in home currency
        /// </summary>
        public decimal TotalWithoutVatHc { get; set; }

        /// <summary>
        /// Total amount with VAT in used currency
        /// </summary>
        public decimal TotalWithVat { get; set; }

        /// <summary>
        /// Total amount with VAT in home currency
        /// </summary>
        public decimal TotalWithVatHc { get; set; }
    }
}