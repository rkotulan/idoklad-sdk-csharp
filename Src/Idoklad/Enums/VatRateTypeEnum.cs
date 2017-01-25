using System.Runtime.Serialization;
using IdokladSdk.Attributes;

namespace IdokladSdk.Enums
{
    /// <summary>
    /// Possible vat rate values
    /// </summary>
    public enum VatRateTypeEnum
    {
        /// <summary>
        /// Snížená sazba
        /// </summary>
        [Rank(1)]
        Reduced1
            = 0,

        /// <summary>
        /// Základní sazba
        /// </summary>
        [Rank(3)]
        Basic = 1,

        /// <summary>
        /// Nulová sazba
        /// </summary>
        [Rank(0)]
        Zero = 2,

        /// <summary>
        /// Snížená sazba 2
        /// </summary>
        [Rank(2)]
        Reduced2 = 3
    }
}