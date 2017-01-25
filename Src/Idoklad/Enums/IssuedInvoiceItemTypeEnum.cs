using System.Runtime.Serialization;

namespace IdokladSdk.Enums
{
    /// <summary>
    /// Invoice item types
    /// </summary>
    public enum IssuedInvoiceItemTypeEnum
    {
        /// <summary>
        /// Normální položka faktury
        /// </summary>
        ItemTypeNormal = 0,

        /// <summary>
        /// Zaokrouhlovací typ polozky
        /// </summary>
        ItemTypeRound = 1,

        /// <summary>
        /// Reduced item for accounted by proforma invoices
        /// </summary>
        ItemTypeReduce = 2,

        /// <summary>
        /// Slevová položka
        /// </summary>
        ItemTypeDiscount = 3
    }
}