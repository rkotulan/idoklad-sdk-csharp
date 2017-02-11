using System;
using System.Collections.Generic;
using IdokladSdk;
using IdokladSdk.ApiFilters;
using IdokladSdk.ApiModels;
using IdokladSdk.Clients.Auth;

namespace ConsoleSampleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //var url = AuthorizationCodeAuth.GetClientAuthenticationUrl("client_id", "http://localhost:3432");
            //var authCredentials = new AuthorizationCodeAuth("client_id", "client_secret", "code", "http://localhost:3432");

            // choose authorization flow
            var clientCred = new ClientCredentialAuth("client_id", "client_secret");

            // initialise context with configuration
            var apiContext = new ApiContext(clientCred)
            {
                AppName = "Application name",
                Configuration = {DateFormat = "yyyy-MM-dd HH:mm"}
            };

            // initialise api explorer
            var api = new ApiExplorer(apiContext);

            // prepare custom filter for querying
            var contactFilter = new ContactFilter();
            contactFilter.DateLastChange.IsEqualOrGreatherThan(new DateTime(2016,1,1));

            // query data using custom filter
            var contacts = api.Contacts.ContactsExpand(
                new ApiFilter(contactFilter, FilterType.And).AddOrderDesc("Id").WithPaging(1, 5));

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
