using IdokladSdk.ApiModels.BaseModels;
using IdokladSdk.Enums;

namespace IdokladSdk.ApiModels
{
    public class Agenda : IApiModel
    {
        public int Id { get; set; }

        /// <summary>
        /// Id kontaktních údajů agendy
        /// </summary>
        public int ContactId { get; set; }

        /// <summary>
        /// Id výchozí měny pro agendu
        /// </summary>
        public int DefaultCurrencyId { get; set; }

        /// <summary>
        /// Příznak zda je agenda plátcem DPH
        /// </summary>
        public bool IsRegisteredForVat { get; set; }

        /// <summary>
        /// Název agendy
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Výchozí typ ceny
        /// </summary>
        public PriceTypeEnum PrefferedPrice { get; set; }

        /// <summary>
        /// Výchozí sazba DPH
        /// </summary>
        public VatRateTypeEnum PrefferedVatRate { get; set; }

        /// <summary>
        /// Výchozí způsob zaokrouhlení
        /// </summary>
        public RoundEnum RoundingDifference { get; set; }

        /// <summary>
        /// Příznak zvláštního režimu uplatnění DPH na základě tržeb
        /// </summary>
        public bool IsRegisteredForVatOnPay { get; set; }

        /// <summary>
        /// Typ plátce DPH
        /// </summary>
        //public VatRegistrationTypeEnum VatRegistrationType { get; set; }

        /// <summary>
        /// Počet desetinných míst jednotkové ceny
        /// </summary>
        public int CountOfDecimalsForPrice { get; set; }

        /// <summary>
        /// Počet desetinných míst pro množství
        /// </summary>
        public int CountOfDecimalsForAmount { get; set; }
    }
}