# IDoklad SDK for Csharp

**The SDK works directly with idoklad API service.**

## Quick start

Example of use in the project **samples/ConsoleSampleApplication**

### Step 1: Authorize
At the beginning you have to sign in. Authentication is recommended at the beginning of each set of calls. IDoklad currently provides **token with unexpected life length**.

	var authClient = new OAuthClient("your@email.tld", "password");
	var apiContext = new ApiContext(authClient.GetSecureToken())
	{
	    AppName = "Application name",
	};

Of course you can skip authentication an create `ApiContext` directly using your token. This approach is on your own risk.

### Step 2: Play

Once you have `ApiContext` with valid token, you can create `ApiExplorer` and **start to make various calls to API**.


For example, here is the entire flow of work with contacts.

    // get template for new contact
    var template = api.Contacts.Default();

    // cast to insert model
    var contact = (ContactPost)template;

    // fill new contact
    contact.CompanyName = "New Company";

    // insert
    var addedContact = api.Contacts.Create(contact);

    // delete
    bool isDeleted = api.Contacts.Delete(addedContact.Id);

**Happy accounting!**