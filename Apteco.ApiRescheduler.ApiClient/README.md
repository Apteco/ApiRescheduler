# Apteco.ApiRescheduler.ApiClient
This is the client code that connects to the Apteco API.  This has been auto-generated from the
Swagger/OpenApi specification using [swagger-codegen](https://github.com/swagger-api/swagger-codegen)

### Getting started
1. Ensure you have Java installed (the time of writing swagger-codegen uses Java 8).
2. Download the latest stable release of the swagger-codegen (see 
[the prerequisites on the swagger-codegen readme](https://github.com/swagger-api/swagger-codegen#prerequisites)
for a link to get the jar file from).
3. There is a [json options file](../Apteco.ApiRescheduler.Resources/apteco-api-codegen-options.json)
in the Apteco.ApiRescheduler.Resources project that contains some settings to use when generating the
API client code.
4. Run the following command to generate the client libraries from the API hosted at the given URL:

```
java -jar swagger-codegen-cli.jar generate -i http://www.tealgreenholidays.co.uk/OrbitAPI/swagger/v2/swagger.json
-l csharp -o GeneratedClient -c .\apteco-api-codegen-options.json
```

If you want to generate the client against your own API then simply change the URL.  If you want the
namespace to be different then modify the options file.

5. This will generate a .Net Standard 1.3 project.  Then simply incorporate the code into your application.

### Usage
To call the API via the client you can then do something like:

```
private async Task LoginAndListCollections()
{
  string dataViewName = "holidays";

  var sessionsApi = new SessionsApi(CreateConfiguration(null));
  var sessionDetails = await sessionsApi.SessionsCreateSessionSimpleAsync(dataViewName, "user", "letmein");

  var usersApi = new UsersApi(CreateConfiguration(sessionDetails));
  var pagedCollections = await usersApi.UsersGetUserCollectionsAsync(dataViewName, "user");
  foreach (var collection in pagedCollections.List)
  {
    Console.WriteLine(collection.Title);
  }

  await sessionsApi.SessionsLogoutSessionAsync(dataViewName, sessionDetails.SessionId);
}

private Configuration CreateConfiguration(SessionDetails sessionDetails)
{
  var defaultHeaders = new Dictionary<string, string>();
  if (sessionDetails != null)
  {
    defaultHeaders.Add("Authorization", "Bearer " + sessionDetails.AccessToken);
  }

  return new Configuration()
  {
    DefaultHeader = defaultHeaders,
    BasePath = baseUrl
  };
}
```

Each part of the API has its own class (i.e. SessionsAPI, UsersAPI, etc).  See the API documentation
(such as at http://www.tealgreenholidays.co.uk/OrbitAPI/swagger/ui/index.html) for details on what each call does.