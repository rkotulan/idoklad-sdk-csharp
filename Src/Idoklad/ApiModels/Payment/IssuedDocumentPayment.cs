using IdokladSdk.Enums;

namespace IdokladSdk.ApiModels
{
    public class IssuedDocumentPayment : Payment
    {
        /// <summary>
        /// Responsibility for handlig of electronic records of sales of payments document
        /// </summary>
        public EetResponsibilityEnum EetResponsibility { get; set; }

        public EetStatusEnum EetStatus { get; set; }

        /// <summary>
        /// Indicates whether the document of payment is registered in electronics records of sales.
        /// </summary>
        public bool IsEet { get; set; }

        /// <summary>
        /// Registered sale
        /// </summary>
        public RegisteredSale RegisteredSale { get; set; }
    }
}
