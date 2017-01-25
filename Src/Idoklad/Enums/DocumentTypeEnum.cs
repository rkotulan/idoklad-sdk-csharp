namespace IdokladSdk.Enums
{
    public enum DocumentTypeEnum
    {
        /// <summary>
        /// Faktura vydaná
        /// </summary>
        IssuedInvoice = 0,

        /// <summary>
        /// Zálohová faktura
        /// </summary>
        ProformaInvoice = 1,

        /// <summary>
        /// Faktura vydaná jako pokladní doklad. Uchovává se pouze v èíselné øadì. 
        /// Nepoužívá se pro entity faktur!
        /// </summary>
        CashVoucher = 2,

        /// <summary>
        /// Dobropis pro fakturu
        /// </summary>
        CreditNote = 3,

        /// <summary>
        /// Bankovní výpis
        /// </summary>
        BankStatement = 4,

        /// <summary>
        /// Received Invoice only in numeric sequence.
        /// </summary>
        ReceivedInvoice = 5,

        /// <summary>
        /// Prodejka
        /// </summary>
        SalesReceipt = 6,

        /// <summary>
        /// Úètenka v EET
        /// </summary>
        RegisteredSale = 101
    }
}