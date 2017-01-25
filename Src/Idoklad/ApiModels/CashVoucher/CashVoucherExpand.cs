using IdokladSdk.ApiModels.ReadOnlyEntites;

namespace IdokladSdk.ApiModels
{
    public class CashVoucherExpand : CashVoucher
    {
        public CashRegister CashRegister { get; set; }
        public Currency Currency { get; set; }
        public DocumentAddress MyCompanyDocumentAddress { get; set; }
        public Contact PartnerContact { get; set; }
        public DocumentAddress PartnerDocumentAddress { get; set; }
    }
}