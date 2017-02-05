using System;
using IdokladSdk.ApiModels.BaseModels;
using IdokladSdk.Enums;
using IdokladSdk.ValidationAttributes;

namespace IdokladSdk.ApiModels.ReadOnlyEntites
{
    public class VatRate : ApiModel
    {
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
        /// Interval platnosti sazby DPH od
        /// </summary>
        public DateTime DateValidityFrom { get; set; }

        /// <summary>
        /// Interval platnosti sazby DPH do
        /// </summary>
        public DateTime DateValidityTo { get; set; }

        /// <summary>
        /// Název sazby DPH
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Sazba DPH
        /// </summary>
        public decimal Rate { get; set; }

        /// <summary>
        /// Typ sazby
        /// </summary>
        [ValidEnumValue]
        public VatRateTypeEnum RateType { get; set; }
    }
}