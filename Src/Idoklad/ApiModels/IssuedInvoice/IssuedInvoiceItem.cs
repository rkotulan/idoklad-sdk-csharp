using System.Runtime.Serialization;

namespace IdokladSdk.ApiModels
{
    /// <summary>
    /// Issued invoice item
    /// </summary>
    [KnownType(typeof (IssuedInvoiceItem))]
    public class IssuedInvoiceItem : IssuedInvoiceItemBase
    {
        /// <summary>
        /// Id příslušné faktury
        /// </summary>
        public int InvoiceId { get; set; }
    }
}