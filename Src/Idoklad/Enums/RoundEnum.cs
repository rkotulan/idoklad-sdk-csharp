using System.Runtime.Serialization;

namespace IdokladSdk.Enums
{
    /// <summary>
    /// Výčet možností zaokrouhlování
    /// </summary>
    /// <summary>
    /// Possible types of rounding
    /// </summary>
    [DataContract]
    public enum RoundEnum
    {
        /// <summary>
        /// Nikdy se nebude zaokrouhlovat
        /// </summary>
        [EnumMember(Value = "0")]
        Never = 0,

        /// <summary>
        /// Vždy se bude zaokrouhlovat
        /// </summary>
        [EnumMember(Value = "1")]
        Always = 1,

        /// <summary>
        /// Zaokrouhlovat se bude podle způsobu úhrady (při platbě hotovostí se zaokrouhlí)
        /// </summary>
        [EnumMember(Value = "2")]
        ByPaymentOption = 2
    }
}