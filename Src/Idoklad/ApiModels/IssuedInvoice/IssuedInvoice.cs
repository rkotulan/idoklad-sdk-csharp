using System.Collections.Generic;

namespace IdokladSdk.ApiModels
{
    public class IssuedInvoice : IssuedInvoiceBase
    {
        /// <summary>
        /// Invoice items
        /// </summary>
        public List<IssuedInvoiceItem> IssuedInvoiceItems { get; set; }

        /// <summary>
        /// Numeric sequence ID
        /// </summary>
        public int NumericSequenceId { get; set; }

        /// <summary>
        /// Name of the attached file. If no attachment is included, this will be empty
        /// </summary>
        public string AttachmentFileName { get; set; }
    }
}