using System.Threading.Tasks;
using IdokladSdk.ApiFilters;
using IdokladSdk.ApiModels;
using IdokladSdk.ApiModels.BaseModels;

namespace IdokladSdk.Clients
{
    /// <summary>
    /// Contacts section. Here are described methods for working with agendas contacts. API allows creation of invoice only for already created contacts.
    /// </summary>
    public partial class ContactClient : BaseClient
    {
        /// <summary>
        /// GET api/Contacts/Default
        /// Returns default contact. This resource is suitable for creation of new contact by the POST method.
        /// </summary>
        public async Task<Contact> DefaulAsync()
        {
            return await GetAsync<Contact>(ResourceUrl + "/Default");
        }

        /// <summary>
        /// GET api/Contacts/Expand
        /// List of contacts with related entities.
        /// </summary>
        public async Task<RowsResultWrapper<ContactExpand>> ContactsExpandAsync(ApiFilter filter = null)
        {
            return await GetAsync<RowsResultWrapper<ContactExpand>>(ResourceUrl + "/Expand", filter);
        }

        /// <summary>
        /// GET api/Contacts/{id}/Expand
        /// Returns contact with related entities by contact Id.
        /// </summary>
        public async Task<ContactExpand> ContactExpandAsync(int contactId)
        {
            return await GetAsync<ContactExpand>(ResourceUrl + "/" + contactId + "/Expand");
        }

        /// <summary>
        /// DELETE api/Contacts/{id}
        /// Deletes contact.
        /// </summary>
        public async Task<bool> DeleteAsync(int contactId)
        {
            return await DeleteAsync(ResourceUrl + "/" + contactId);
        }

        /// <summary>
        /// GET api/Contacts
        /// List of contacts.
        /// </summary>
        public async Task<RowsResultWrapper<Contact>> ContactsAsync(ApiFilter filter = null)
        {
            return await GetAsync<RowsResultWrapper<Contact>>(ResourceUrl, filter);
        }

        /// <summary>
        /// GET api/Contacts/{id}
        /// Returns contact by Id.
        /// </summary>
        public async Task<Contact> ContactAsync(int contactId)
        {
            return await GetAsync<Contact>(ResourceUrl + "/" + contactId);
        }

        /// <summary>
        /// POST api/Contacts
        /// Add new contact.
        /// </summary>
        public async Task<Contact> CreateAsync(ContactCreate model)
        {
            return await PostAsync<Contact, ContactCreate>(ResourceUrl, model);
        }

        /// <summary>
        /// PUT api/Contacts/{id}
        /// Update contact. 
        /// </summary>
        public async Task<Contact> UpdateAsync(int contactId, ContactUpdate model)
        {
            return await PutAsync<Contact, ContactUpdate>(ResourceUrl + "/" + contactId, model);
        }
    }
}
