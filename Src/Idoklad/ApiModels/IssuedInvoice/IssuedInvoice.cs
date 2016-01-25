using System.Collections.Generic;

namespace IdokladSdk.ApiModels.IssuedInvoice
{
    public class IssuedInvoice : IssuedInvoiceBase
    {
        /// <summary>
        /// Invoice items
        /// </summary>
        public List<IssuedInvoiceItem> IssuedInvoiceItems { get; set; }
    }
}