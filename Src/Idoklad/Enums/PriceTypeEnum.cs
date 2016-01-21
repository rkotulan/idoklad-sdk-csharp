using System.Runtime.Serialization;

namespace IdokladSdk.Enums
{
    /// <summary>
    /// Číselník typů ceny
    /// </summary>
    /// <summary xml:lang="en">
    /// Possible Price type values
    /// </summary>
    [DataContract]
    public enum PriceTypeEnum
    {
        /// <summary>
        /// Cena s daní
        /// </summary>
        [EnumMember(Value = "0")]
        WithVat = 0,

        /// <summary>
        /// Cena bez daně
        /// </summary>
        [EnumMember(Value = "1")]
        WithoutVat = 1,

        /// <summary>
        /// Pouze zaklad
        /// </summary>
        [EnumMember(Value = "2")]
        OnlyBase = 2
    }
}