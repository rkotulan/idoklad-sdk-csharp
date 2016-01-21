using System.Collections.Generic;

namespace IdokladSdk.ApiModels.IssuedInvoice
{
    public class IssuedInvoice : IssuedInvoiceBase
    {
        /// <summary>
        /// Položky faktury
        /// </summary>
        /// <summary xml:lang="en">
        /// Invoice items
        /// </summary>
        public List<IssuedInvoiceItem> IssuedInvoiceItems { get; set; }
    }
}