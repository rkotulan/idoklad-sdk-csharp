using System;
using IdokladSdk.ApiModels.BaseModels;

namespace IdokladSdk.ApiModels.ReadOnlyEntites
{
    public class PaymentOption : IApiModel
    {
        public int Id { get; set; }

        /// <summary>
        /// Kód způsobu úhrady
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Datum poslední změny
        /// </summary>
        public DateTime DateLastChange { get; set; }

        /// <summary>
        /// Příznak výchozího způsobu úhrady
        /// </summary>
        public bool IsDefault { get; set; }

        /// <summary>
        /// Příznak zaokrouhlení pro daný způsob úhrady
        /// </summary>
        public bool IsRounded { get; set; }

        /// <summary>
        /// Název způsobu úhrady
        /// </summary>
        public string Name { get; set; }
    }
}