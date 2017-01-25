using System;

namespace IdokladSdk.ApiModels
{
    public class CashRegister
    {
        /// <summary>
        /// Currency Id
        /// </summary>
        public int CurrencyId { get; set; }

        /// <summary>
        /// The date when the intial state was set
        /// </summary>
        public DateTime DateInitialState { get; set; }

        /// <summary>
        /// Initial amout of money in the cash register
        /// </summary>
        public decimal InitialState { get; set; }

        /// <summary>
        /// Cash register name
        /// </summary>
        public string Name { get; set; }
    }
}
