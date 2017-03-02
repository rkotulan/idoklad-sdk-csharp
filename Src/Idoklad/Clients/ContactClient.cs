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
        public const string ResourceUrl = "/Contacts";

        public ContactClient(ApiContext apiContext) : base(apiContext)
        {
        }

        /// <summary>
        /// GET api/Contacts/Default
        /// Returns default contact. This resource is suitable for creation of new contact by the POST method.
        /// </summary>
        public Contact Default()
        {
            return Get<Contact>(ResourceUrl + "/Default");
        }

        /// <summary>
        /// GET api/Contacts/Expand
        /// List of contacts with related entities.
        /// </summary>
        public RowsResultWrapper<ContactExpand> ContactsExpand(ApiFilter filter = null)
        {
            return Get<RowsResultWrapper<ContactExpand>>(ResourceUrl + "/Expand", filter);
        }

        /// <summary>
        /// GET api/Contacts/{id}/Expand
        /// Returns contact with related entities by contact Id.
        /// </summary>
        public ContactExpand ContactExpand(int contactId)
        {
            return Get<ContactExpand>(ResourceUrl + "/" + contactId + "/Expand");
        }

        /// <summary>
        /// DELETE api/Contacts/{id}
        /// Deletes contact.
        /// </summary>
        public bool Delete(int contactId)
        {
            return Delete(ResourceUrl + "/" + contactId);
        }

        /// <summary>
        /// GET api/Contacts
        /// List of contacts.
        /// </summary>
        public RowsResultWrapper<Contact> Contacts(ApiFilter filter = null)
        {
            return Get<RowsResultWrapper<Contact>>(ResourceUrl, filter);
        }

        /// <summary>
        /// GET api/Contacts/{id}
        /// Returns contact by Id.
        /// </summary>
        public Contact Contact(int contactId)
        {
            return Get<Contact>(ResourceUrl + "/" + contactId);
        }

        /// <summary>
        /// POST api/Contacts
        /// Add new contact.
        /// </summary>
        public Contact Create(ContactCreate model)
        {
            return Post<Contact, ContactCreate>(ResourceUrl, model);
        }

        /// <summary>
        /// PUT api/Contacts/{id}
        /// Update contact. 
        /// </summary>
        public Contact Update(int contactId, ContactUpdate model)
        {
            return Put<Contact, ContactUpdate>(ResourceUrl + "/" + contactId, model);
        }
    }
}
