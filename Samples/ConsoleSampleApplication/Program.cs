using System.Collections.Generic;
using IdokladSdk;
using IdokladSdk.ApiFilters;
using IdokladSdk.ApiModels;
using IdokladSdk.ApiModels.IssuedInvoice;
using IdokladSdk.Clients;

namespace ConsoleSampleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var authClient = new OAuthClient("your@email.tld", "password");
            var apiContext = new ApiContext(authClient.GetSecureToken())
            {
                AppName = "Application name",
            };

            var api = new ApiExplorer(apiContext);

            // get template for new contact
            var template = api.Contacts.Default();

            // cast to insert model
            var contact = (ContactCreate)template;

            // fill new contact
            contact.CompanyName = "New Company";

            // insert
            var addedContact = api.Contacts.Create(contact);

            // delete
            bool isDeleted = api.Contacts.Delete(addedContact.Id);
            

            List<ValidationMessage> errors;
            bool isValid = ApiValidator.ValidateObject(contact, out errors);

            if (isValid)
            {
                var result = api.Contacts.Create(new ContactCreate());
            }
        }
    }
}
