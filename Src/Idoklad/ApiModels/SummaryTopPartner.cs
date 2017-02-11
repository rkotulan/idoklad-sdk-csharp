using IdokladSdk.ApiModels.BaseModels;

namespace IdokladSdk.ApiModels
{
    public class SummaryTopPartner : IApiModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal TotalWithVatHc { get; set; }
        public int ContactId { get; set; }
    }
}
