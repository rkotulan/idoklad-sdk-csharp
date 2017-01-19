using System;
using IdokladSdk.ApiModels.BaseModels;

namespace IdokladSdk.ApiModels.ReadOnlyEntites
{
    public class Bank : ApiModel
    {
        /// <summary>
        /// ISO 9362 Bank code
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Informaton about country
        /// </summary>
        public Country Country { get; set; }

        /// <summary>
        /// ID of the country
        /// </summary>
        public int CountryId { get; set; }

        /// <summary>
        /// Last change date
        /// </summary>
        public DateTime DateLastChange { get; set; }

        /// <summary>
        /// Name of the bank institution
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Code of the bank institution
        /// </summary>
        public string NumberCode { get; set; }

        /// <summary>
        /// Swift code
        /// </summary>
        public string Swift { get; set; }

        /// <summary>
        /// Indicate that bank is no longer an active
        /// </summary>
        public bool IsOutOfDate { get; set; }
    }
}