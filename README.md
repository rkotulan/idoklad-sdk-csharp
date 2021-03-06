# IDoklad SDK for Csharp

**The SDK works directly with IDoklad API service. Below is described communication with the newest version IDoklad API 2.0**

Legacy version of SDK 1.0 is available in special branch: **[SDK_V1](https://github.com/mholec/idoklad-sdk-csharp/tree/SDK_V1)**. We recommend to use this version of SDK. This version fully supports newest version of iDoklad API.

## Quick start (examples)

- Basic use with client credential flow: **samples/ConsoleSampleApplication**
- Basic use with authorization code flow **samples/WebSampleApplication**

### Step 1: Authorize (client_credential flow)
At the beginning you have to sign in. Authentication is recommended at the beginning of each set of calls. 
You need to have your ClientId and ClientSecret. You can find this credentials in **[IDoklad settings page](https://app.idoklad.cz/Setting/LogonUser)**.
 
	var credentials = new ClientCredentialAuth("client_id", "client_secret");

    var apiContext = new ApiContext(clientCred)
    {
        AppName = "Application name",
        Configuration = {DateFormat = "yyyy-MM-dd HH:mm"}
    };

Authentication using the legacy API 1.0 is not available anymore.

### Step 2: Play

Once you have `ApiContext`, you can create `ApiExplorer` and **start to make various calls to API**.


For example, here is the entire flow of work with contacts.

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

	// get all
	var allContacts = api.Contacts.Contacts(new ApiFilter().WithPaging(1, int.MaxValue));

	// get many
	var contacts = api.Contacts.Contacts(new Paging(1, 20));

	// get many with filter
    var contactFilter = new ContactFilter();
    contactFilter.DateLastChange.IsEqualOrGreatherThan(new DateTime(2016,1,1));

    var contacts = api.Contacts.ContactsExpand(
        new ApiFilter(contactFilter, FilterType.And).AddOrderDesc("Id").WithPaging(1, 5));

## Supported frameworks

We currently support
- .NET 4.5
- .NET 4.5.1
- .NET 4.5.2
- .NET 4.6

## NuGet
You can install **SDK for iDoklad API** using the [NuGet](https://www.nuget.org)

	PM> Install-Package IdokladSdk
