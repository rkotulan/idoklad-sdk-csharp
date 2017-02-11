using IdokladSdk.ApiModels.BaseModels;

namespace IdokladSdk.ApiModels.ReadOnlyEntites
{
    public class Currency : IApiModel
    {
        public int Id { get; set; }

        /// <summary>
        /// ISO 4217 Kód měny
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Název státu, kde je měna defaultní
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Název měny
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Priorita měny v ramci systému
        /// </summary>
        public int Priority { get; set; }

        /// <summary>
        /// Symbol měny
        /// </summary>
        public string Symbol { get; set; }
    }
}