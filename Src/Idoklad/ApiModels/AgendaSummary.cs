using IdokladSdk.ApiModels.BaseModels;

namespace IdokladSdk.ApiModels
{
    /// <summary>
    /// Counts of agendas resources
    /// </summary>
    public class AgendaSummary : IApiModel
    {
        public int Id { get; set; }

        /// <summary>
        /// Počet kontaktů
        /// </summary>
        public int Contacts { get; set; }

        /// <summary>
        /// Počet faktur
        /// </summary>
        public int IssuedInvoices { get; set; }

        /// <summary>
        /// Počet položek ceníku
        /// </summary>
        public int PriceListItems { get; set; }
    }
}