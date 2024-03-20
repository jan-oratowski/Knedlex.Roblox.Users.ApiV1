# Knedlex.Roblox.Users.ApiV1.Api.DisplayNamesApi

All URIs are relative to *https://users.roblox.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**V1DisplayNamesValidateGet**](DisplayNamesApi.md#v1displaynamesvalidateget) | **GET** /v1/display-names/validate | Validate a display name for a new user. |
| [**V1UsersUserIdDisplayNamesPatch**](DisplayNamesApi.md#v1usersuseriddisplaynamespatch) | **PATCH** /v1/users/{userId}/display-names | Set the display name for the authorized user. |
| [**V1UsersUserIdDisplayNamesValidateGet**](DisplayNamesApi.md#v1usersuseriddisplaynamesvalidateget) | **GET** /v1/users/{userId}/display-names/validate | Validate a display name for an existing user. |

<a id="v1displaynamesvalidateget"></a>
# **V1DisplayNamesValidateGet**
> Object V1DisplayNamesValidateGet (string displayName, DateTime birthdate)

Validate a display name for a new user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.Roblox.Users.ApiV1.Api;
using Knedlex.Roblox.Users.ApiV1.Client;
using Knedlex.Roblox.Users.ApiV1.Model;

namespace Example
{
    public class V1DisplayNamesValidateGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://users.roblox.com";
            var apiInstance = new DisplayNamesApi(config);
            var displayName = "displayName_example";  // string | The display name.
            var birthdate = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime | The new user's birthdate

            try
            {
                // Validate a display name for a new user.
                Object result = apiInstance.V1DisplayNamesValidateGet(displayName, birthdate);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DisplayNamesApi.V1DisplayNamesValidateGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1DisplayNamesValidateGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Validate a display name for a new user.
    ApiResponse<Object> response = apiInstance.V1DisplayNamesValidateGetWithHttpInfo(displayName, birthdate);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DisplayNamesApi.V1DisplayNamesValidateGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **displayName** | **string** | The display name. |  |
| **birthdate** | **DateTime** | The new user&#39;s birthdate |  |

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | 1: Display name is too short  2: Display name is too long  3: Display name contains invalid characters  4: Display name has been moderated  6: Request must contain a birthdate |  -  |
| **429** | 5: Display name updates for this user have been throttled |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1usersuseriddisplaynamespatch"></a>
# **V1UsersUserIdDisplayNamesPatch**
> Object V1UsersUserIdDisplayNamesPatch (long userId, RobloxUsersApiSetDisplayNameRequest request)

Set the display name for the authorized user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.Roblox.Users.ApiV1.Api;
using Knedlex.Roblox.Users.ApiV1.Client;
using Knedlex.Roblox.Users.ApiV1.Model;

namespace Example
{
    public class V1UsersUserIdDisplayNamesPatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://users.roblox.com";
            var apiInstance = new DisplayNamesApi(config);
            var userId = 789L;  // long | the user id
            var request = new RobloxUsersApiSetDisplayNameRequest(); // RobloxUsersApiSetDisplayNameRequest | Roblox.Users.Api.SetDisplayNameRequest

            try
            {
                // Set the display name for the authorized user.
                Object result = apiInstance.V1UsersUserIdDisplayNamesPatch(userId, request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DisplayNamesApi.V1UsersUserIdDisplayNamesPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1UsersUserIdDisplayNamesPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set the display name for the authorized user.
    ApiResponse<Object> response = apiInstance.V1UsersUserIdDisplayNamesPatchWithHttpInfo(userId, request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DisplayNamesApi.V1UsersUserIdDisplayNamesPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **long** | the user id |  |
| **request** | [**RobloxUsersApiSetDisplayNameRequest**](RobloxUsersApiSetDisplayNameRequest.md) | Roblox.Users.Api.SetDisplayNameRequest |  |

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | 1: Display name is too short  2: Display name is too long  3: Display name contains invalid characters  4: Display name has been moderated |  -  |
| **401** | 0: Authorization has been denied for this request. |  -  |
| **403** | 0: Token Validation Failed  7: The user id is invalid. |  -  |
| **429** | 5: Display name updates for this user have been throttled |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1usersuseriddisplaynamesvalidateget"></a>
# **V1UsersUserIdDisplayNamesValidateGet**
> Object V1UsersUserIdDisplayNamesValidateGet (long userId, string displayName)

Validate a display name for an existing user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.Roblox.Users.ApiV1.Api;
using Knedlex.Roblox.Users.ApiV1.Client;
using Knedlex.Roblox.Users.ApiV1.Model;

namespace Example
{
    public class V1UsersUserIdDisplayNamesValidateGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://users.roblox.com";
            var apiInstance = new DisplayNamesApi(config);
            var userId = 789L;  // long | The user id.
            var displayName = "displayName_example";  // string | The display name.

            try
            {
                // Validate a display name for an existing user.
                Object result = apiInstance.V1UsersUserIdDisplayNamesValidateGet(userId, displayName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DisplayNamesApi.V1UsersUserIdDisplayNamesValidateGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1UsersUserIdDisplayNamesValidateGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Validate a display name for an existing user.
    ApiResponse<Object> response = apiInstance.V1UsersUserIdDisplayNamesValidateGetWithHttpInfo(userId, displayName);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DisplayNamesApi.V1UsersUserIdDisplayNamesValidateGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **long** | The user id. |  |
| **displayName** | **string** | The display name. |  |

### Return type

**Object**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | 1: Display name is too short  2: Display name is too long  3: Display name contains invalid characters  4: Display name has been moderated |  -  |
| **401** | 0: Authorization has been denied for this request. |  -  |
| **403** | 7: The user id is invalid. |  -  |
| **429** | 5: Display name updates for this user have been throttled |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

