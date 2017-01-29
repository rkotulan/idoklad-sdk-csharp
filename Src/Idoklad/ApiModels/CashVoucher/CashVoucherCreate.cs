using System;
using System.ComponentModel.DataAnnotations;
using IdokladSdk.Enums;
using IdokladSdk.ValidationAttributes;

namespace IdokladSdk.ApiModels
{
    public class CashVoucherCreate
    {
        /// <summary> 
        /// Cash register id
        /// </summary>
        public int CashRegisterId { get; set; }

        /// <summary>
        /// The date of transaction 
        /// </summary>
        [Required]
        public DateTime DateOfTransaction { get; set; }

        /// <summary xml:lang="en">
        /// Electronic records of sales information.
        /// </summary>
        public ElectronicRecordsOfSales ElectronicRecordsOfSales { get; set; }

        /// <summary xml:lang="en">
        /// Exchange rate
        /// </summary>
        public decimal? ExchangeRate { get; set; }

        /// <summary xml:lang="en">
        /// Exchange rate amount
        /// </summary>
        public decimal? ExchangeRateAmount { get; set; }

        /// <summary xml:lang="en">
        /// Document Serial Number
        /// </summary>
        public int DocumentSerialNumber { get; set; }

        /// <summary xml:lang="en">
        /// Export to another accounting software indication. (It is recommended to use only one external accounting software beside iDoklad.)
        /// </summary>
        [ValidEnumValue]
        public ExportedStateEnum Exported { get; set; }

        /// <summary> 
        /// Model of entity for inserting a new item.
        /// </summary>
        public CashVoucherItemCreate Item { get; set; }

        /// <summary> 
        /// The movement type (issue/entry)
        /// </summary>
        public MovementTypeEnum MovementType { get; set; }

        /// <summary xml:lang="en">
        /// Id of your contact information at the time of saving.
        /// </summary>
        public int? MyCompanyDocumentAddressId { get; set; }

        /// <summary> 
        /// Id of the partner's contact.
        /// </summary>
        public int? PartnerContactId { get; set; }

        /// <summary> 
        /// Id of the partner's contact at the time of saving.
        /// </summary>
        public int? PartnerDocumentAddressId { get; set; }

        /// <summary> 
        /// Name of the supplier/customer. Can also be used as a note.
        /// </summary>
        public string Person { get; set; }
    }
}
