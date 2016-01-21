using System;
using IdokladSdk.ApiModels.BaseModels;

namespace IdokladSdk.ApiModels.ReadOnlyEntites
{
    public class ConstantSymbol : ApiModel
    {
        /// <summary>
        /// Čtyřmístný kód
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
        /// Příznak výchozího konstantního symbolu pro daný stát
        /// </summary>
        public bool IsDefault { get; set; }

        /// <summary>
        /// Jméno konstantního symbolu
        /// </summary>
        public string Name { get; set; }
    }
}