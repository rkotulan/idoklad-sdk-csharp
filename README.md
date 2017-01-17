# IDoklad SDK for Csharp

**The SDK works directly with IDoklad API service. Below is described communication with the newest version IDoklad API 2.0**

## Quick start

Example of use in the project **samples/ConsoleSampleApplication**

### Step 1: Authorize (client_credential flow)
At the beginning you have to sign in. Authentication is recommended at the beginning of each set of calls. 
You need to have your client_id and client_secret. You can find this credentials in IDoklad settings page.
 
	var credentials = new ClientCredentialAuth("client_id", "client_secret");
	var apiContext = new ApiContext(credentials)
	{
	    AppName = "Application name",
	};

Authentication using the legacy API 1.0 token is still available but not recommended.

### Step 2: Play

Once you have `ApiContext` with valid token, you can create `ApiExplorer` and **start to make various calls to API**.


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
	var contacts = api.Contacts.Contacts(new Paging(int.MaxValue));

	// get many
	var contacts = api.Contacts.Contacts(new Paging(1, 20));

## Supported frameworks

We currently support
- .NET 4.5
- .NET 4.5.1
- .NET 4.5.2
- .NET 4.6

## NuGet
You can install **SDK for iDoklad API** using the [NuGet](https://www.nuget.org)

	PM> Install-Package IdokladSdk
