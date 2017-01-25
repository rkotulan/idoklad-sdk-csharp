using System.Runtime.Serialization;

namespace IdokladSdk.Enums
{
    /// <summary>
    /// Possible Price type values
    /// </summary>
    public enum PriceTypeEnum
    {
        /// <summary>
        /// Cena s daní
        /// </summary>
        WithVat = 0,

        /// <summary>
        /// Cena bez daně
        /// </summary>
        WithoutVat = 1,

        /// <summary>
        /// Pouze zaklad
        /// </summary>
        OnlyBase = 2
    }
}