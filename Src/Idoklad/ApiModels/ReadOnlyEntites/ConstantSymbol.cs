using System;
using IdokladSdk.ApiModels.BaseModels;

namespace IdokladSdk.ApiModels.ReadOnlyEntites
{
    public class ConstantSymbol : IApiModel
    {
        public int Id { get; set; }

        /// <summary>
        /// Code (4 places)
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Information about country
        /// </summary>
        public Country Country { get; set; }

        /// <summary>
        /// Country ID
        /// </summary>
        public int CountryId { get; set; }

        /// <summary>
        /// Date of last change
        /// </summary>
        public DateTime DateLastChange { get; set; }

        /// <summary>
        /// Is constant symbol default pro country?
        /// </summary>
        public bool IsDefault { get; set; }

        /// <summary>
        /// Name of the constant symbol
        /// </summary>
        public string Name { get; set; }
    }
}