# Getting Started
## How to Build

The generated code uses a few NuGet Packages e.g., Newtonsoft.Json, UniRest,
and Microsoft Base Class Library. The reference to these packages is already
added as in the packages.config file. If the automatic NuGet package restore
is enabled, these dependencies will be installed automatically. Therefore,
you will need internet access for build.
     
1. Open the solution (DudeSecurityApi.sln) file.
2. Invoke the build process using `Ctrl+Shift+B` shortcut key or using the `Build` menu as shown below.

![Building SDK using Visual Studio](http://apidocs.io/illustration/cs?step=buildSDK&workspaceFolder=Dude Security Api-CSharp&workspaceName=DudeSecurityApi&projectName=DudeSecurityApi.PCL)

## How to Use

The build process generates a portable class library, which can be used like a normal class library. The generated library is compatible with Windows Forms, Windows RT, Windows Phone 8,
 Silverlight 5, Xamarin iOS, Xamarin Android and Mono. More information on how to use can be found at the following link. 
http://msdn.microsoft.com/en-us/library/vstudio/gg597391(v=vs.100).aspx

The following section explains how to use the DudeSecurityApi library in a new console project.     
    
#### 1. Starting a new project
For starting a new project, right click on the current solution from the *solution explorer* and choose  ``` Add -> New Project ```.

![Add a new project in the existing solution using Visual Studio](http://apidocs.io/illustration/cs?step=addProject&workspaceFolder=Dude Security Api-CSharp&workspaceName=DudeSecurityApi&projectName=DudeSecurityApi.PCL)

Next, choose "Console Application", provide a ``` TestConsoleProject ``` as the project name and click ``` OK ```.

![Create a new console project using Visual Studio](http://apidocs.io/illustration/cs?step=createProject&workspaceFolder=Dude Security Api-CSharp&workspaceName=DudeSecurityApi&projectName=DudeSecurityApi.PCL)


#### 2. Set as startup project
The new console project is the entry point for the eventual execution. This requires us to set the ``` TestConsoleProject ``` as the start-up project. To do this, right-click on the  ``` TestConsoleProject ``` and choose  ``` Set as StartUp Project ``` form the context menu.

![Set the new cosole project as the start up project](http://apidocs.io/illustration/cs?step=setStartup&workspaceFolder=Dude Security Api-CSharp&workspaceName=DudeSecurityApi&projectName=DudeSecurityApi.PCL)


#### 3. Add reference of the library project
In order to use the DudeSecurityApi library in the new project, first we must add a projet reference to the ``` TestConsoleProject ```. First, right click on the ``` References ``` node in the *solution explorer* and click ``` Add Reference... ```.

![Open references of the TestConsoleProject](http://apidocs.io/illustration/cs?step=addReference&workspaceFolder=Dude Security Api-CSharp&workspaceName=DudeSecurityApi&projectName=DudeSecurityApi.PCL)

Next, a window will be displayed where we must set the ``` checkbox ``` on ``` DudeSecurityApi.PCL ``` and click ``` OK ```. By doing this, we have added a reference of the ```DudeSecurityApi.PCL``` project into the new ``` TestConsoleProject ```.

![Add a reference to the TestConsoleProject](http://apidocs.io/illustration/cs?step=createReference&workspaceFolder=Dude Security Api-CSharp&workspaceName=DudeSecurityApi&projectName=DudeSecurityApi.PCL)


#### 4. Write sample code
Once the ``` TestConsoleProject ``` is created, a file named ``` Program.cs ``` will be visible in the *solution explorer* with an empty ``` Main ``` method. This is the entry point for the execution of the entire solution.
Here, you can add code to initialize the client library and acquire the instance of a *Controller* class. Sample code to initialize the client library and using controller methods is given in the subsequent sections.

![Add a reference to the TestConsoleProject](http://apidocs.io/illustration/cs?step=addCode&workspaceFolder=Dude Security Api-CSharp&workspaceName=DudeSecurityApi&projectName=DudeSecurityApi.PCL)

## How to Test

The generated SDK also contain one or more Tests, which are contained in the Tests project.
In order to invoke these test cases, you will need *NUnit 3.0 Test Adapter Extension for Visual Studio*.
Once the SDK is complied, the test cases should appear in the Test Explorer window.
Here, you can click *Run All* to execute these test cases.

## Initialization

#### Authentication and Initialization
In order to setup authentication and initialization of the API client, you need the following information.

| Parameter | Description |
|-----------|-------------|
| oAuthAccessToken | The OAuth 2.0 access token to be set before API calls |



API client can be initialized as following.

```csharp
// Configuration parameters and credentials
string oAuthAccessToken = "oAuthAccessToken"; // The OAuth 2.0 access token to be set before API calls

DudeSecurityApiClient client = new DudeSecurityApiClient(oAuthAccessToken);
```

# Class Reference
## <a name="list_of_controllers"></a>List of Controllers

* [AccountProducts](#account_products)
* [User](#user)
* [Account](#account)
* [Heartbeat](#heartbeat)
* [SystemInformation](#system_information)
* [APIClients](#api_clients)
* [Markets](#markets)
* [MasterData](#master_data)

## <a name="account_products"></a>![Class: ](http://apidocs.io/img/class.png "DSI.SDK.Security.Controllers.AccountProducts") AccountProducts

#### Get singleton instance
The singleton instance of the ``` AccountProducts ``` class can be accessed from the API Client.
```csharp
IAccountProducts accountProducts = client.AccountProducts;
```

### <a name="delete_account_product_detail"></a>![Method: ](http://apidocs.io/img/method.png "DSI.SDK.Security.Controllers.AccountProducts.DeleteAccountProductDetail") DeleteAccountProductDetail

> This endpoint allows existing account product associations to be found and returned or removed.

```csharp
Task DeleteAccountProductDetail(DeleteAccountProductDetailInput input)
```

#### Parameters: 

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountId |  ``` Required ```  | ID of the account in the form of an integer |
| id |  ``` Required ```  | ID of the product in the form of an integer |



#### Example Usage:
```csharp
DeleteAccountProductDetailInput collect = new DeleteAccountProductDetailInput();

double accountId = 0.0348714413283725;
collect.AccountId = accountId;

double id = 0.0348714413283725;
collect.Id = id;


await accountProducts.DeleteAccountProductDetail(collect);

```





### <a name="get_account_product_detail"></a>![Method: ](http://apidocs.io/img/method.png "DSI.SDK.Security.Controllers.AccountProducts.GetAccountProductDetail") GetAccountProductDetail

> This endpoint allows existing account product associations to be found and returned or removed.

```csharp
Task<AccountProductModel> GetAccountProductDetail(GetAccountProductDetailInput input)
```

#### Parameters: 

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountId |  ``` Required ```  | ID of the account in the form of an integer |
| id |  ``` Required ```  | ID of the product in the form of an integer |



#### Example Usage:
```csharp
GetAccountProductDetailInput collect = new GetAccountProductDetailInput();

int accountId = 0;
collect.AccountId = accountId;

int id = 0;
collect.Id = id;


AccountProductModel result = await accountProducts.GetAccountProductDetail(collect);

```





### <a name="get_account_product_collection"></a>![Method: ](http://apidocs.io/img/method.png "DSI.SDK.Security.Controllers.AccountProducts.GetAccountProductCollection") GetAccountProductCollection

> This collection allows new account product associations to be created and for products of existing associations to be returned.

```csharp
Task<GetAccountProductCollectionResponseModel> GetAccountProductCollection(GetAccountProductCollectionInput input)
```

#### Parameters: 

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountId |  ``` Required ```  | ID of the account in the form of an integer |
| page |  ``` Optional ```  | The page to request from the collection. |
| pagesize |  ``` Optional ```  | The number of records to load in a page from the collection. |
| morderby |  ``` Optional ```  | A string describing the ordering to perform on the collection. |
| q |  ``` Optional ```  | Queries product name containing this value |
| includeAudit |  ``` Optional ```  | Flag to return audit information from the api |



#### Example Usage:
```csharp
GetAccountProductCollectionInput collect = new GetAccountProductCollectionInput();

int accountId = 0;
collect.AccountId = accountId;

int? page = 0;
collect.Page = page;

int? pagesize = 0;
collect.Pagesize = pagesize;

string morderby = "orderby";
collect.Morderby = morderby;

string q = "q";
collect.Q = q;

bool? includeAudit = false;
collect.IncludeAudit = includeAudit;


GetAccountProductCollectionResponseModel result = await accountProducts.GetAccountProductCollection(collect);

```





### <a name="post_account_product_create"></a>![Method: ](http://apidocs.io/img/method.png "DSI.SDK.Security.Controllers.AccountProducts.PostAccountProductCreate") PostAccountProductCreate

> This collection allows new account product associations to be created.

```csharp
Task<AccountProductModel> PostAccountProductCreate(PostAccountProductCreateInput input)
```

#### Parameters: 

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountId |  ``` Required ```  | ID of the account in the form of an integer |
| body |  ``` Required ```  | TODO: Add a parameter description |



#### Example Usage:
```csharp
PostAccountProductCreateInput collect = new PostAccountProductCreateInput();

int accountId = 0;
collect.AccountId = accountId;

var body = new BaseAccountProductModel();
collect.Body = body;


AccountProductModel result = await accountProducts.PostAccountProductCreate(collect);

```





[Back to List of Controllers](#list_of_controllers)
## <a name="user"></a>![Class: ](http://apidocs.io/img/class.png "DSI.SDK.Security.Controllers.User") User

#### Get singleton instance
The singleton instance of the ``` User ``` class can be accessed from the API Client.
```csharp
IUser user = client.User;
```

### <a name="get_user_collection"></a>![Method: ](http://apidocs.io/img/method.png "DSI.SDK.Security.Controllers.User.GetUserCollection") GetUserCollection

> This collection returns a list of Dude Platform users for the account.

```csharp
Task<GetUserCollectionResponseModel> GetUserCollection(GetUserCollectionInput input)
```

#### Parameters: 

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountId |  ``` Required ```  | The Dude Platform account the user belongs too. |
| page |  ``` Optional ```  | The page to request from the collection. |
| pagesize |  ``` Optional ```  | The number of records to load in a page from the collection. |
| morderby |  ``` Optional ```  | A string describing the ordering to perform on the collection. |
| includeAudit |  ``` Optional ```  | Flag to return audit information from the api |
| q |  ``` Optional ```  | A free form filter mechanism. |
| email |  ``` Optional ```  | The user's email. |
| firstName |  ``` Optional ```  | The first name of the user. |
| lastName |  ``` Optional ```  | The last name of the user. |
| isActivated |  ``` Optional ```  | If the user has been activated. |
| isEnabled |  ``` Optional ```  | If the user has access to login to the platform. |
| roles |  ``` Optional ```  ``` Collection ```  | A list of roles that the users may have. |



#### Example Usage:
```csharp
GetUserCollectionInput collect = new GetUserCollectionInput();

int accountId = 0;
collect.AccountId = accountId;

int? page = 0;
collect.Page = page;

int? pagesize = 0;
collect.Pagesize = pagesize;

string morderby = "orderby";
collect.Morderby = morderby;

bool? includeAudit = false;
collect.IncludeAudit = includeAudit;

string q = "q";
collect.Q = q;

string email = "email";
collect.Email = email;

string firstName = "firstName";
collect.FirstName = firstName;

string lastName = "lastName";
collect.LastName = lastName;

bool? isActivated = false;
collect.IsActivated = isActivated;

bool? isEnabled = false;
collect.IsEnabled = isEnabled;

List<int> roles = new List<int> { 0 };
collect.Roles = roles;


GetUserCollectionResponseModel result = await user.GetUserCollection(collect);

```





### <a name="put_user_detail"></a>![Method: ](http://apidocs.io/img/method.png "DSI.SDK.Security.Controllers.User.PutUserDetail") PutUserDetail

> This endpoint allows for existing users to be found and updated or returned.

```csharp
Task<UserModel> PutUserDetail(PutUserDetailInput input)
```

#### Parameters: 

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountId |  ``` Required ```  | The Dude Platform account the user belongs too. |
| id |  ``` Required ```  | The Dude Platform User Id that represents the user. |
| body |  ``` Required ```  | TODO: Add a parameter description |
| includeAudit |  ``` Optional ```  | Flag to return audit information from the api |



#### Example Usage:
```csharp
PutUserDetailInput collect = new PutUserDetailInput();

double accountId = 0.0348714413283725;
collect.AccountId = accountId;

double id = 0.0348714413283725;
collect.Id = id;

var body = new UpdateUserModel();
collect.Body = body;

bool? includeAudit = false;
collect.IncludeAudit = includeAudit;


UserModel result = await user.PutUserDetail(collect);

```





### <a name="get_user_detail"></a>![Method: ](http://apidocs.io/img/method.png "DSI.SDK.Security.Controllers.User.GetUserDetail") GetUserDetail

> This endpoint allows for existing users to be found and updated or returned.

```csharp
Task<UserDetailModel> GetUserDetail(GetUserDetailInput input)
```

#### Parameters: 

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountId |  ``` Required ```  | The Dude Platform account the user belongs too. |
| id |  ``` Required ```  | The Dude Platform User Id that represents the user. |
| includeAudit |  ``` Optional ```  | Flag to return audit information from the api |



#### Example Usage:
```csharp
GetUserDetailInput collect = new GetUserDetailInput();

int accountId = 0;
collect.AccountId = accountId;

int id = 0;
collect.Id = id;

bool? includeAudit = false;
collect.IncludeAudit = includeAudit;


UserDetailModel result = await user.GetUserDetail(collect);

```





### <a name="post_user_create"></a>![Method: ](http://apidocs.io/img/method.png "DSI.SDK.Security.Controllers.User.PostUserCreate") PostUserCreate

> This collection returns a list of Dude Platform users for the account.

```csharp
Task<UserActivationModel> PostUserCreate(PostUserCreateInput input)
```

#### Parameters: 

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountId |  ``` Required ```  | The Dude Platform account the user belongs too. |
| body |  ``` Required ```  | TODO: Add a parameter description |
| includeAudit |  ``` Optional ```  | Flag to return audit information from the api |



#### Example Usage:
```csharp
PostUserCreateInput collect = new PostUserCreateInput();

int accountId = 0;
collect.AccountId = accountId;

var body = new UserDetailModel();
collect.Body = body;

bool? includeAudit = false;
collect.IncludeAudit = includeAudit;


UserActivationModel result = await user.PostUserCreate(collect);

```





[Back to List of Controllers](#list_of_controllers)
## <a name="account"></a>![Class: ](http://apidocs.io/img/class.png "DSI.SDK.Security.Controllers.Account") Account

#### Get singleton instance
The singleton instance of the ``` Account ``` class can be accessed from the API Client.
```csharp
IAccount account = client.Account;
```

### <a name="get_account_me_location"></a>![Method: ](http://apidocs.io/img/method.png "DSI.SDK.Security.Controllers.Account.GetAccountMeLocation") GetAccountMeLocation

> Retrieves information about the location for the account the token is bound to.  Client credential grants will not be able to successfully call the endpoint.

```csharp
Task<LocationModel> GetAccountMeLocation()
```

#### Example Usage:
```csharp

LocationModel result = await account.GetAccountMeLocation();

```





### <a name="get_account_me"></a>![Method: ](http://apidocs.io/img/method.png "DSI.SDK.Security.Controllers.Account.GetAccountMe") GetAccountMe

> Retrieves information about the account the token is bound to.  Client credential grants will not be able to successfully call the endpoint.

```csharp
Task<AccountModel> GetAccountMe()
```

#### Example Usage:
```csharp

AccountModel result = await account.GetAccountMe();

```





### <a name="post_account_create"></a>![Method: ](http://apidocs.io/img/method.png "DSI.SDK.Security.Controllers.Account.PostAccountCreate") PostAccountCreate

> This endpoint allow for the creation of accounts.

```csharp
Task<AccountModel> PostAccountCreate(AccountModel body)
```

#### Parameters: 

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | TODO: Add a parameter description |



#### Example Usage:
```csharp
var body = new AccountModel();

AccountModel result = await account.PostAccountCreate(body);

```





### <a name="put_account_detail"></a>![Method: ](http://apidocs.io/img/method.png "DSI.SDK.Security.Controllers.Account.PutAccountDetail") PutAccountDetail

> This endpoint allows for existing accounts to be found by ID and returned.

```csharp
Task<AccountModel> PutAccountDetail(PutAccountDetailInput input)
```

#### Parameters: 

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountId |  ``` Required ```  | The Dude Platform account id. |
| body |  ``` Required ```  | TODO: Add a parameter description |
| includeAudit |  ``` Optional ```  | Flag to return audit information from the api |



#### Example Usage:
```csharp
PutAccountDetailInput collect = new PutAccountDetailInput();

double accountId = 0.0348714413283725;
collect.AccountId = accountId;

var body = new AccountModel();
collect.Body = body;

bool? includeAudit = false;
collect.IncludeAudit = includeAudit;


AccountModel result = await account.PutAccountDetail(collect);

```





### <a name="get_account_detail"></a>![Method: ](http://apidocs.io/img/method.png "DSI.SDK.Security.Controllers.Account.GetAccountDetail") GetAccountDetail

> This endpoint allows for existing accounts to be found by ID and returned.

```csharp
Task<AccountModel> GetAccountDetail(GetAccountDetailInput input)
```

#### Parameters: 

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountId |  ``` Required ```  | The Dude Platform account id. |
| includeAudit |  ``` Optional ```  | Flag to return audit information from the api |



#### Example Usage:
```csharp
GetAccountDetailInput collect = new GetAccountDetailInput();

int accountId = 0;
collect.AccountId = accountId;

bool? includeAudit = false;
collect.IncludeAudit = includeAudit;


AccountModel result = await account.GetAccountDetail(collect);

```





[Back to List of Controllers](#list_of_controllers)
## <a name="heartbeat"></a>![Class: ](http://apidocs.io/img/class.png "DSI.SDK.Security.Controllers.Heartbeat") Heartbeat

#### Get singleton instance
The singleton instance of the ``` Heartbeat ``` class can be accessed from the API Client.
```csharp
IHeartbeat heartbeat = client.Heartbeat;
```

### <a name="get_heartbeat_check"></a>![Method: ](http://apidocs.io/img/method.png "DSI.SDK.Security.Controllers.Heartbeat.GetHeartbeatCheck") GetHeartbeatCheck

> The heartbeat is exposed and provided to check for availability of the service.
> Any response that does not provide a ```200 OK``` response code should be treated as an error.

```csharp
Task<HeartbeatModel> GetHeartbeatCheck()
```

#### Example Usage:
```csharp

HeartbeatModel result = await heartbeat.GetHeartbeatCheck();

```





[Back to List of Controllers](#list_of_controllers)
## <a name="system_information"></a>![Class: ](http://apidocs.io/img/class.png "DSI.SDK.Security.Controllers.SystemInformation") SystemInformation

#### Get singleton instance
The singleton instance of the ``` SystemInformation ``` class can be accessed from the API Client.
```csharp
ISystemInformation systemInformation = client.SystemInformation;
```

### <a name="get_si_check"></a>![Method: ](http://apidocs.io/img/method.png "DSI.SDK.Security.Controllers.SystemInformation.GetSICheck") GetSICheck

> Retrieve api version, vitals, links, etc.

```csharp
Task<SystemInformationModel> GetSICheck()
```

#### Example Usage:
```csharp

SystemInformationModel result = await systemInformation.GetSICheck();

```





[Back to List of Controllers](#list_of_controllers)
## <a name="api_clients"></a>![Class: ](http://apidocs.io/img/class.png "DSI.SDK.Security.Controllers.APIClients") APIClients

#### Get singleton instance
The singleton instance of the ``` APIClients ``` class can be accessed from the API Client.
```csharp
IAPIClients aPIClients = client.APIClients;
```

### <a name="get_system_of_record_api_client"></a>![Method: ](http://apidocs.io/img/method.png "DSI.SDK.Security.Controllers.APIClients.GetSystemOfRecordApiClient") GetSystemOfRecordApiClient

> Gets information about a given API Client and System of Record mapping.
> Any response that does not provide a ```200 OK``` response should be treated as an error.

```csharp
Task<SystemOfRecordApiClientModel> GetSystemOfRecordApiClient(GetSystemOfRecordApiClientInput input)
```

#### Parameters: 

| Parameter | Tags | Description |
|-----------|------|-------------|
| clientIdentifier |  ``` Required ```  | The api client identifier. |
| sourceAbbreviation |  ``` Required ```  | The system of record source abbreviation. |
| includeAudit |  ``` Optional ```  | Flag to return audit information from the api. |



#### Example Usage:
```csharp
GetSystemOfRecordApiClientInput collect = new GetSystemOfRecordApiClientInput();

string clientIdentifier = "clientIdentifier";
collect.ClientIdentifier = clientIdentifier;

string sourceAbbreviation = "sourceAbbreviation";
collect.SourceAbbreviation = sourceAbbreviation;

bool? includeAudit = false;
collect.IncludeAudit = includeAudit;


SystemOfRecordApiClientModel result = await aPIClients.GetSystemOfRecordApiClient(collect);

```





[Back to List of Controllers](#list_of_controllers)
## <a name="markets"></a>![Class: ](http://apidocs.io/img/class.png "DSI.SDK.Security.Controllers.Markets") Markets

#### Get singleton instance
The singleton instance of the ``` Markets ``` class can be accessed from the API Client.
```csharp
IMarkets markets = client.Markets;
```

### <a name="get_market_collection"></a>![Method: ](http://apidocs.io/img/method.png "DSI.SDK.Security.Controllers.Markets.GetMarketCollection") GetMarketCollection

> This collection allows new account product associations to be created and for products of existing associations to be returned.

```csharp
Task<GetMarketCollectionResponseModel> GetMarketCollection(GetMarketCollectionInput input)
```

#### Parameters: 

| Parameter | Tags | Description |
|-----------|------|-------------|
| page |  ``` Optional ```  | The page to request from the collection. |
| pagesize |  ``` Optional ```  | The number of records to load in a page from the collection. |
| morderby |  ``` Optional ```  | A string describing the ordering to perform on the collection. |
| name |  ``` Optional ```  | Queries market name containing this value |
| includeAudit |  ``` Optional ```  | Flag to return audit information from the api |



#### Example Usage:
```csharp
GetMarketCollectionInput collect = new GetMarketCollectionInput();

int? page = 0;
collect.Page = page;

int? pagesize = 0;
collect.Pagesize = pagesize;

string morderby = "orderby";
collect.Morderby = morderby;

string name = "name";
collect.Name = name;

bool? includeAudit = false;
collect.IncludeAudit = includeAudit;


GetMarketCollectionResponseModel result = await markets.GetMarketCollection(collect);

```





[Back to List of Controllers](#list_of_controllers)
## <a name="master_data"></a>![Class: ](http://apidocs.io/img/class.png "DSI.SDK.Security.Controllers.MasterData") MasterData

#### Get singleton instance
The singleton instance of the ``` MasterData ``` class can be accessed from the API Client.
```csharp
IMasterData masterData = client.MasterData;
```

### <a name="post_system_of_record_user_create"></a>![Method: ](http://apidocs.io/img/method.png "DSI.SDK.Security.Controllers.MasterData.PostSystemOfRecordUserCreate") PostSystemOfRecordUserCreate

> The add user system of record map is exposed and provided to create a system of record user map between the Dude Platform user and the system of record user name.
> Any response that does not provide a ```201 Created``` response should be treated as an error.

```csharp
Task<SystemOfRecordUserModel> PostSystemOfRecordUserCreate(PostSystemOfRecordUserCreateInput input)
```

#### Parameters: 

| Parameter | Tags | Description |
|-----------|------|-------------|
| sourceAbbreviation |  ``` Required ```  | The system of record source abbreviation (SD or FD). |
| userName |  ``` Required ```  | The user name from the system of record. |
| userSummaryId |  ``` Required ```  | The Dude Platform user to map too. |



#### Example Usage:
```csharp
PostSystemOfRecordUserCreateInput collect = new PostSystemOfRecordUserCreateInput();

string sourceAbbreviation = "sourceAbbreviation";
collect.SourceAbbreviation = sourceAbbreviation;

string userName = "userName";
collect.UserName = userName;

int userSummaryId = 0;
collect.UserSummaryId = userSummaryId;


SystemOfRecordUserModel result = await masterData.PostSystemOfRecordUserCreate(collect);

```





### <a name="get_product_detail"></a>![Method: ](http://apidocs.io/img/method.png "DSI.SDK.Security.Controllers.MasterData.GetProductDetail") GetProductDetail

> The get product is exposed and provided to return a Dude Platform product from a system of record product id.
> Any response that does not provide a ```200 OK``` response should be treated as an error.

```csharp
Task<ProductModel> GetProductDetail(GetProductDetailInput input)
```

#### Parameters: 

| Parameter | Tags | Description |
|-----------|------|-------------|
| productId |  ``` Required ```  | The product Id from the system of record. |
| sourceAbbreviation |  ``` Required ```  | The system of record source abbreviation (SD or FD). |
| includeAudit |  ``` Optional ```  | Flag to return audit information from the api |



#### Example Usage:
```csharp
GetProductDetailInput collect = new GetProductDetailInput();

string productId = "productId";
collect.ProductId = productId;

string sourceAbbreviation = "sourceAbbreviation";
collect.SourceAbbreviation = sourceAbbreviation;

bool? includeAudit = false;
collect.IncludeAudit = includeAudit;


ProductModel result = await masterData.GetProductDetail(collect);

```





### <a name="get_account_detail"></a>![Method: ](http://apidocs.io/img/method.png "DSI.SDK.Security.Controllers.MasterData.GetAccountDetail") GetAccountDetail

> The get account is exposed and provided to return a Dude Platform account from a system of record account id.
> Any response that does not provide a ```200 OK``` response should be treated as an error.

```csharp
Task<AccountModel> GetAccountDetail(GetAccountDetailInput input)
```

#### Parameters: 

| Parameter | Tags | Description |
|-----------|------|-------------|
| accountNumber |  ``` Required ```  | {INT} The account number for the system of record account. |
| sourceAbbreviation |  ``` Required ```  | The system of record source abbreviation (SD or FD). |
| includeAudit |  ``` Optional ```  | Flag to return audit information from the api |



#### Example Usage:
```csharp
GetAccountDetailInput collect = new GetAccountDetailInput();

string accountNumber = "accountNumber";
collect.AccountNumber = accountNumber;

string sourceAbbreviation = "sourceAbbreviation";
collect.SourceAbbreviation = sourceAbbreviation;

bool? includeAudit = false;
collect.IncludeAudit = includeAudit;


AccountModel result = await masterData.GetAccountDetail(collect);

```





### <a name="get_system_of_record_user"></a>![Method: ](http://apidocs.io/img/method.png "DSI.SDK.Security.Controllers.MasterData.GetSystemOfRecordUser") GetSystemOfRecordUser

> The get system of record user is exposed and provided to return a system of record user from a Dude Platform user.
> Any response that does not provide a ```200 OK``` response should be treated as an error.

```csharp
Task<SystemOfRecordUserModel> GetSystemOfRecordUser(GetSystemOfRecordUserInput input)
```

#### Parameters: 

| Parameter | Tags | Description |
|-----------|------|-------------|
| userId |  ``` Required ```  | The id of the Dude Platform user. |
| includeAudit |  ``` Optional ```  | Flag to return audit information from the api |



#### Example Usage:
```csharp
GetSystemOfRecordUserInput collect = new GetSystemOfRecordUserInput();

int userId = 0;
collect.UserId = userId;

bool? includeAudit = false;
collect.IncludeAudit = includeAudit;


SystemOfRecordUserModel result = await masterData.GetSystemOfRecordUser(collect);

```





### <a name="get_user_detail"></a>![Method: ](http://apidocs.io/img/method.png "DSI.SDK.Security.Controllers.MasterData.GetUserDetail") GetUserDetail

> The get user is exposed and provided to return a Dude Platform user from a system of record user name.
> Any response that does not provide a ```200 OK``` response should be treated as an error.

```csharp
Task<UserModel> GetUserDetail(GetUserDetailInput input)
```

#### Parameters: 

| Parameter | Tags | Description |
|-----------|------|-------------|
| userName |  ``` Required ```  | The name of the user from the system of record. |
| sourceAbbreviation |  ``` Required ```  | The system of record source abbreviation (SD or FD). |
| includeAudit |  ``` Optional ```  | Flag to return audit information from the api |



#### Example Usage:
```csharp
GetUserDetailInput collect = new GetUserDetailInput();

string userName = "userName";
collect.UserName = userName;

string sourceAbbreviation = "sourceAbbreviation";
collect.SourceAbbreviation = sourceAbbreviation;

bool? includeAudit = false;
collect.IncludeAudit = includeAudit;


UserModel result = await masterData.GetUserDetail(collect);

```





[Back to List of Controllers](#list_of_controllers)


