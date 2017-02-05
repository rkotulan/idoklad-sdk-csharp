using System;

namespace IdokladSdk.ApiModels
{
    public class CashVoucherUpdate
    {
        /// <summary> 
        /// Cash register id
        /// </summary>
        public int CashRegisterId { get; set; }

        /// <summary>
        /// The date of transaction 
        /// </summary>
        public DateTime DateOfTransaction { get; set; }

        /// <summary>
        /// Exchange rate
        /// </summary>
        public decimal? ExchangeRate { get; set; }

        /// <summary>
        /// Exchange rate amount
        /// </summary>
        public decimal? ExchangeRateAmount { get; set; }

        /// <summary> 
        /// Model of entity for updating a cash voucher item.
        /// </summary>
        public CashVoucherItemUpdate Item { get; set; }

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
    }
}
