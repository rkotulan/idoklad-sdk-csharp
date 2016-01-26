using IdokladSdk.ApiModels;

namespace IdokladSdk.Clients
{
    /// <summary>
    /// Methods for work with contact information of the invoices (documents).
    /// </summary>
    public class DocumentAddressClient : BaseClient
    {
        internal const string ResourceUrl = "/DocumentAddresses";

        public DocumentAddressClient(ApiContext apiContext) : base(apiContext)
        {
        }

        /// <summary>
        /// GET api/DocumentAddresses/{id} 
        /// Returns document contact information. Every invoice has two of this entities - one for supplier and one purchaser. This contact informations are created from Contacts, but can also contain different informations.
        /// </summary>
        public DocumentAddress DocumentAddress(int documentAddressId)
        {
            return Get<DocumentAddress>(ResourceUrl + "/" + documentAddressId);
        }

        /// <summary>
        /// PUT api/DocumentAddresses/{id}
        /// Method updates contact information on the invoice by DocumentAddressId.
        /// </summary>
        public DocumentAddress Update(int documentAddressId, DocumentAddress model)
        {
            return Put<DocumentAddress, DocumentAddress>(ResourceUrl + "/" + documentAddressId, model);
        }
    }
}