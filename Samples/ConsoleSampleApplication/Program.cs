using System.Collections.Generic;
using IdokladSdk;
using IdokladSdk.ApiFilters;
using IdokladSdk.ApiModels;
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

            var issuedInvoices = api.IssuedInvoices.IssuedInvoicesExpand(new IssuedInvoiceFilter());

            var agendas = api.Agendas.Agendas();

            var contacts = api.Contacts.ContactsExpand(new ContactFilter());

            var contact = new ContactPost();
            List<ValidationMessage> errors;
            bool isValid = ApiValidator.ValidateObject(contact, out errors);

            if (isValid)
            {
                var result = api.Contacts.Create(new ContactPost());
            }
        }
    }
}
