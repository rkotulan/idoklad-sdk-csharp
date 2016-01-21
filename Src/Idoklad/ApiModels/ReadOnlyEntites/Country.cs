using System;
using IdokladSdk.ApiModels.BaseModels;

namespace IdokladSdk.ApiModels.ReadOnlyEntites
{
    public class Country : ApiModel
    {
        /// <summary>
        /// Kód státu
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Informace o měně
        /// </summary>
        public Currency Currency { get; set; }

        /// <summary>
        /// Id měny
        /// </summary>
        public int CurrencyId { get; set; }

        /// <summary>
        /// Datum poslední změny
        /// </summary>
        public DateTime DateLastChange { get; set; }

        /// <summary>
        /// Název banky
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Anglický název banky
        /// </summary>
        public string NameEnglish { get; set; }
    }
}