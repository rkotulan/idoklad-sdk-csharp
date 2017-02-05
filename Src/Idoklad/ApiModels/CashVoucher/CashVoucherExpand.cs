using IdokladSdk.ApiModels.ReadOnlyEntites;

namespace IdokladSdk.ApiModels
{
    public class CashVoucherExpand : CashVoucher
    {
        /// <summary>
        /// Cash register entity
        /// </summary>
        public CashRegister CashRegister { get; set; }

        /// <summary>
        /// Currency entity
        /// </summary>
        public Currency Currency { get; set; }

        /// <summary>
        /// Your company address entity
        /// </summary>
        public DocumentAddress MyCompanyDocumentAddress { get; set; }

        /// <summary>
        /// Entity of your partner's contact
        /// </summary>
        public Contact PartnerContact { get; set; }

        /// <summary>
        /// Entity of your partner's address
        /// </summary>
        public DocumentAddress PartnerDocumentAddress { get; set; }
    }
}