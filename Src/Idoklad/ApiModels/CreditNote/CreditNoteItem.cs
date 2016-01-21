using System.Runtime.Serialization;

namespace IdokladSdk.ApiModels.CreditNote
{
    /// <summary>
    /// Položka dobropisu
    /// </summary>
    /// <summary xml:lang="en">
    /// Credit note item
    /// </summary>
    [KnownType(typeof (CreditNoteItem))]
    public class CreditNoteItem : IssuedInvoiceItemBase
    {
    }
}