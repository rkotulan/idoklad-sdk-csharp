using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using IdokladSdk.Enums;
using IdokladSdk.ValidationAttributes;

namespace IdokladSdk.ApiModels
{
    public class SalesReceiptCreate
    {
        /// <summary>
        /// Date of issue
        /// </summary>
        [DataType(DataType.DateTime)]
        public DateTime DateOfIssue { get; set; }

        /// <summary>
        /// Pořadové číslo dokumentu
        /// </summary>
        /// <summary>
        /// Document Serial Number
        /// </summary>
        public int DocumentSerialNumber { get; set; }

        /// <summary>
        /// Number assigned by external application.
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [StringLength(20)]
        public string ExternalDocumentNumber { get; set; }

        /// <summary>
        /// Cummulative sales receipt
        /// </summary>
        public bool IsCumulative { get; set; }

        /// <summary>
        /// Sales receipt name. If not set, it will be set to the first item's name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Electronic records of sales information.
        /// </summary>
        public ElectronicRecordsOfSales ElectronicRecordsOfSales { get; set; }

        /// <summary>
        /// List of items. Must be non-empty.
        /// </summary>
        [MinCollectionLength(1)]
        public ICollection<SalesReceiptItemCreate> SalesReceiptItems { get; set; }

        /// <summary>
        /// List of payments.
        /// </summary>
        [CollectionRange(1, 2)]
        public ICollection<SalesReceiptPaymentCreate> SalesReceiptPayments { get; set; }

        /// <summary>
        /// POS equipment id.
        /// </summary>
        public int? SalesPosEquipmentId { get; set; }

        /// <summary>
        /// Export to another accounting software indication. (It is recommended to use only one external accounting software beside iDoklad.)
        /// </summary>
        [ValidEnumValue]
        public ExportedStateEnum Exported { get; set; }
    }
}