# Knedlex.Roblox.Users.ApiV1.Api.UsernamesApi

All URIs are relative to *https://users.roblox.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**V1UsersUserIdUsernameHistoryGet**](UsernamesApi.md#v1usersuseridusernamehistoryget) | **GET** /v1/users/{userId}/username-history | Retrieves the username history for a particular user. |

<a id="v1usersuseridusernamehistoryget"></a>
# **V1UsersUserIdUsernameHistoryGet**
> RobloxWebWebAPIModelsApiPageResponseRobloxUsersApiUsernameHistoryResponse V1UsersUserIdUsernameHistoryGet (long userId, int? limit = null, string cursor = null, string sortOrder = null)

Retrieves the username history for a particular user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.Roblox.Users.ApiV1.Api;
using Knedlex.Roblox.Users.ApiV1.Client;
using Knedlex.Roblox.Users.ApiV1.Model;

namespace Example
{
    public class V1UsersUserIdUsernameHistoryGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://users.roblox.com";
            var apiInstance = new UsernamesApi(config);
            var userId = 789L;  // long | 
            var limit = 10;  // int? | The number of results per request. (optional)  (default to 10)
            var cursor = "cursor_example";  // string | The paging cursor for the previous or next page. (optional) 
            var sortOrder = "Asc";  // string | The order the results are sorted in. (optional)  (default to Asc)

            try
            {
                // Retrieves the username history for a particular user.
                RobloxWebWebAPIModelsApiPageResponseRobloxUsersApiUsernameHistoryResponse result = apiInstance.V1UsersUserIdUsernameHistoryGet(userId, limit, cursor, sortOrder);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsernamesApi.V1UsersUserIdUsernameHistoryGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1UsersUserIdUsernameHistoryGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieves the username history for a particular user.
    ApiResponse<RobloxWebWebAPIModelsApiPageResponseRobloxUsersApiUsernameHistoryResponse> response = apiInstance.V1UsersUserIdUsernameHistoryGetWithHttpInfo(userId, limit, cursor, sortOrder);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsernamesApi.V1UsersUserIdUsernameHistoryGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **long** |  |  |
| **limit** | **int?** | The number of results per request. | [optional] [default to 10] |
| **cursor** | **string** | The paging cursor for the previous or next page. | [optional]  |
| **sortOrder** | **string** | The order the results are sorted in. | [optional] [default to Asc] |

### Return type

[**RobloxWebWebAPIModelsApiPageResponseRobloxUsersApiUsernameHistoryResponse**](RobloxWebWebAPIModelsApiPageResponseRobloxUsersApiUsernameHistoryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | 3: The user id is invalid. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

