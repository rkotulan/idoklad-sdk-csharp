using System;
using IdokladSdk.ApiModels.BaseModels;

namespace IdokladSdk.ApiModels.ReadOnlyEntites
{
    public class Bank : ApiModel
    {
        /// <summary>
        /// Zkratka banky
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Informace o státu
        /// </summary>
        public Country Country { get; set; }

        /// <summary>
        /// Id státu
        /// </summary>
        public int CountryId { get; set; }

        /// <summary>
        /// Datum poslední změny
        /// </summary>
        public DateTime DateLastChange { get; set; }

        /// <summary>
        /// Název banky
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Kód banky
        /// </summary>
        public string NumberCode { get; set; }

        /// <summary>
        /// Swift identifikace banky
        /// </summary>
        public string Swift { get; set; }

        /// <summary>
        /// Indicate that bank is no longer an active
        /// </summary>
        public bool IsOutOfDate { get; set; }
    }
}