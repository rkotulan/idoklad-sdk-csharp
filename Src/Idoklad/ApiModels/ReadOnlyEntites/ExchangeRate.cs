using System;
using IdokladSdk.ApiModels.BaseModels;

namespace IdokladSdk.ApiModels.ReadOnlyEntites
{
    public class ExchangeRate : ApiModel
    {
        /// <summary>
        /// Množství cizí měny
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// Informace o měně
        /// </summary>
        public virtual Currency Currency { get; set; }

        /// <summary>
        /// Id měny
        /// </summary>
        public int CurrencyId { get; set; }

        /// <summary>
        /// Datum vystavení kurzu
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Datum poslední změny záznamu
        /// </summary>
        public DateTime DateLastChange { get; set; }

        /// <summary>
        /// Id kurzovního lístku
        /// </summary>
        public int ExchangeListId { get; set; }

        /// <summary>
        /// Kurz pro převod měny
        /// </summary>
        public decimal ExchangeRateValue { get; set; }
    }
}