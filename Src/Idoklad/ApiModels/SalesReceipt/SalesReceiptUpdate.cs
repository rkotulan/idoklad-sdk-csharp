using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using IdokladSdk.ValidationAttributes;

namespace IdokladSdk.ApiModels
{
    public class SalesReceiptUpdate
    {
        /// <summary>
        /// Date of issue
        /// </summary>
        [DataType(DataType.DateTime)]
        public DateTime DateOfIssue { get; set; }

        /// <summary>
        /// Number assigned by external application.
        /// </summary>
        [Required(AllowEmptyStrings = true)]
        [StringLength(20)]
        public string ExternalDocumentNumber { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(200)]
        public string Name { get; set; }

        /// <summary>
        /// POS equipment id.
        /// </summary>
        public int? SalesPosEquipmentId { get; set; }

        /// <summary>
        /// List of items. Must be non-empty.
        /// </summary>
        [MinCollectionLength(1)]
        public ICollection<SalesReceiptItemUpdate> SalesReceiptItems { get; set; }

        /// <summary>
        /// List of payments
        /// </summary>
        [CollectionRange(1, 2)]
        public ICollection<SalesReceiptPaymentUpdate> SalesReceiptPayments { get; set; }
    }
}