using System.Collections.Generic;
using IdokladSdk;
using IdokladSdk.ApiFilters;
using IdokladSdk.ApiModels;
using IdokladSdk.Clients;
using IdokladSdk.Clients.Auth;

namespace ConsoleSampleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var url = AuthorizationCodeAuth.GetClientAuthenticationUrl("client_id", "http://localhost:3432");
            var authCredentials = new AuthorizationCodeAuth("client_id", "client_secret", "code", "http://localhost:3432");

            var clientCred = new ClientCredentialAuth("client_id", "client_secret");
            var apiContext = new ApiContext(clientCred)
            {
                AppName = "Application name"
            };

            var api = new ApiExplorer(apiContext);

            var test = api.Contacts.Contacts(new ContactFilter());

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
