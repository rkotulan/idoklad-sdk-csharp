using System.Runtime.Serialization;

namespace IdokladSdk.Enums
{
    /// <summary>
    /// Possible types of rounding
    /// </summary>
    public enum RoundEnum
    {
        /// <summary>
        /// Nikdy se nebude zaokrouhlovat
        /// </summary>
        Never = 0,

        /// <summary>
        /// Vždy se bude zaokrouhlovat
        /// </summary>
        Always = 1,

        /// <summary>
        /// Zaokrouhlovat se bude podle způsobu úhrady (při platbě hotovostí se zaokrouhlí)
        /// </summary>
        ByPaymentOption = 2
    }
}