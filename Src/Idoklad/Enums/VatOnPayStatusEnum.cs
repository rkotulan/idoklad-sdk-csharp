namespace IdokladSdk.Enums
{
    public enum VatOnPayStatusEnum
    {
        /// <summary>
        /// Není v režim
        /// </summary>
        Disabled = 0,

        /// <summary>
        /// Je v režimu
        /// </summary>
        Enabled = 1,

        /// <summary>
        /// Faktura je v režimu do data
        /// </summary>
        InvoiceNeedsTaxing = 2
    }
}