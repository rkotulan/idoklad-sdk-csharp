using IdokladSdk.ApiFilters;
using IdokladSdk.ApiModels;
using IdokladSdk.ApiModels.BaseModels;

namespace IdokladSdk.Clients
{
    public class ContactClient : BaseClient
    {
        internal const string ResourceUrl = "/Contacts";

        public ContactClient(ApiContext apiContext) : base(apiContext)
        {
        }

        /// <summary>
        /// GET api/Contacts/Default
        /// Returns default contact. This resource is suitable for creation of new contact by the POST method.
        /// </summary>
        public Contact Default()
        {
            return base.Get<Contact>(ResourceUrl + "/Default");
        }

        /// <summary>
        /// GET api/Contacts/Expand
        /// List of contacts with related entities.
        /// </summary>
        public RowsResultWrapper<ContactExpand> ContactsExpand(ContactFilter filter = null)
        {
            return base.Get<RowsResultWrapper<ContactExpand>>(ResourceUrl + "/Expand", filter);
        }

        /// <summary>
        /// GET api/Contacts/{id}/Expand
        /// Returns contact with related entities by contact Id.
        /// </summary>
        public ContactExpand ContactExpand(int contactId)
        {
            return base.Get<ContactExpand>(ResourceUrl + "/" + contactId + "/Expand");
        }

        /// <summary>
        /// DELETE api/Contacts/{id}
        /// Deletes contact.
        /// </summary>
        public bool Delete(int contactId)
        {
            return base.Delete(ResourceUrl + "/" + contactId);
        }

        /// <summary>
        /// GET api/Contacts
        /// List of contacts.
        /// </summary>
        public RowsResultWrapper<Contact> Contacts()
        {
            return base.Get<RowsResultWrapper<Contact>>(ResourceUrl);
        }

        /// <summary>
        /// GET api/Contacts/{id}
        /// Returns contact by Id.
        /// </summary>
        public Contact Contact(int contactId)
        {
            return base.Get<Contact>(ResourceUrl + "/" + contactId);
        }

        /// <summary>
        /// POST api/Contacts
        /// Add new contact.
        /// </summary>
        public Contact Create(ContactCreate model)
        {
            return base.Post<Contact, ContactCreate>(ResourceUrl, model);
        }

        /// <summary>
        /// PUT api/Contacts/{id}
        /// Update contact. Partial update is also possible.
        /// </summary>
        public Contact Update(int contactId, ContactUpdate model)
        {
            return base.Put<Contact, ContactUpdate>(ResourceUrl + "/" + contactId, model);
        }
    }
}
