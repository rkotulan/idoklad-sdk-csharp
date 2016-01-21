using System.Runtime.Serialization;

namespace IdokladSdk.Enums
{
    [DataContract]
    public enum ExportedStateEnum
    {
        /// <summary>
        /// Doklad nebyl exportován
        /// </summary>
        [EnumMember(Value = "0")]
        NotExported = 0,

        /// <summary>
        /// Doklad byl exportován do externího účetního software
        /// </summary>
        [EnumMember(Value = "1")]
        Exported = 1,

        /// <summary>
        /// Doklad byl exportován a následně v iDokladu změněn
        /// </summary>
        [EnumMember(Value = "2")]
        Changed = 2,

        /// <summary>
        /// Doklad byl exportován a následně v iDokladu smazán
        /// </summary>
        [EnumMember(Value = "3")]
        Deleted = 3
    }
}