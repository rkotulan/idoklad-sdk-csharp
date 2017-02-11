using IdokladSdk.ApiModels.BaseModels;

namespace IdokladSdk.ApiModels
{
    public class SalesOffice : IApiModel
    {
        public int Id { get; set; }

        public int Designation { get; set; }

        public string Name { get; set; }

        public string City { get; set; }

        public string Street { get; set; }

        public string PostalCode { get; set; }

        public int CountryId { get; set; }

        /// <summary>
        /// Flag determining whether the point of sale is registered for EET.
        /// </summary>
        public bool IsRegisteredEet { get; set; }
    }
}
