using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using IdokladSdk.ApiModels.BaseModels;
using IdokladSdk.Enums;
using IdokladSdk.ValidationAttributes;

namespace IdokladSdk.ApiModels
{
    public class CashVoucher : ApiModel
    {

        /// <summary>
        /// Cash register
        /// </summary>
        public int CashRegisterId { get; set; }
        
        public int CurrencyId { get; set; }

        /// <summary>
        /// Date since the last change
        /// </summary>
        public DateTime DateLastChange { get; set; }

        /// <summary>
        /// The date of transaction 
        /// </summary>
        [Required]
        public DateTime DateOfTransaction { get; set; }

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

        [IgnoreDataMember]
        public EetStatusEnum EetStatus { get; set; }

        /// <summary>
        /// Exchange rate
        /// </summary>
        public decimal? ExchangeRate { get; set; }

        /// <summary>
        /// Exchange rate amount
        /// </summary>
        public decimal? ExchangeRateAmount { get; set; }

        /// <summary>
        /// Export to another accounting software indication. (It is recommended to use only one external accounting software beside iDoklad.)
        /// </summary>
        [ValidEnumValue]
        public ExportedStateEnum Exported { get; set; }

        /// <summary>
        /// The cash voucher item.
        /// </summary>
        public CashVoucherItem Item { get; set; }

        /// <summary>
        /// Indicates whether the sales receipt is registered in EET.
        /// </summary>
        public bool IsEet { get; set; }

        /// <summary>
        /// The movement type (issue/entry)
        /// </summary>
        [ValidEnumValue]
        public MovementTypeEnum MovementType { get; set; }

        /// <summary>
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

        /// <summary>
        /// Registered sale
        /// </summary>
        public RegisteredSale RegisteredSale { get; set; }

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
