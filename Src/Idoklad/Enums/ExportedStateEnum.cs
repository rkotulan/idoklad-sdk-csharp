namespace IdokladSdk.Enums
{
    public enum ExportedStateEnum
    {
        /// <summary>
        /// Doklad nebyl exportován
        /// </summary>
        NotExported = 0,

        /// <summary>
        /// Doklad byl exportován do externího účetního software
        /// </summary>
        Exported = 1,

        /// <summary>
        /// Doklad byl exportován a následně v iDokladu změněn
        /// </summary>
        Changed = 2,

        /// <summary>
        /// Doklad byl exportován a následně v iDokladu smazán
        /// </summary>
        Deleted = 3
    }
}