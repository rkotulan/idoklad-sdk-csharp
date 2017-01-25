using IdokladSdk.Enums;

namespace IdokladSdk.ApiModels
{
    public class ReceivedDocumentPayment : Payment
    {
        public EetResponsibilityEnum EetResponsibility { get; set; }
        public EetStatusEnum EetStatus { get; set; }
        public bool IsEet { get; set; }
        public RegisteredSale RegisteredSale { get; set; }
    }
}