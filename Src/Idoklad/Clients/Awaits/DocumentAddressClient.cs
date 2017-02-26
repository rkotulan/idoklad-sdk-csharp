using System.Threading.Tasks;
using IdokladSdk.ApiModels;

namespace IdokladSdk.Clients
{
    /// <summary>
    /// Methods for work with contact information of the invoices (documents).
    /// </summary>
    public partial class DocumentAddressClient : BaseClient
    {
        /// <summary>
        /// GET api/DocumentAddresses/{id} 
        /// Returns document contact information. Every invoice has two of this entities - one for supplier and one purchaser. This contact informations are created from Contacts, but can also contain different informations.
        /// </summary>
        public async Task<DocumentAddress> DocumentAddressAsync(int documentAddressId)
        {
            return await GetAsync<DocumentAddress>(ResourceUrl + "/" + documentAddressId);
        }

        /// <summary>
        /// PUT api/DocumentAddresses/{id}
        /// Method updates contact information on the invoice by DocumentAddressId.
        /// </summary>
        public async Task<DocumentAddress> UpdateAsync(int documentAddressId, DocumentAddress model)
        {
            return await PutAsync<DocumentAddress, DocumentAddress>(ResourceUrl + "/" + documentAddressId, model);
        }
    }
}