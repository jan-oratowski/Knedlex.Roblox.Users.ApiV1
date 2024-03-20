# Knedlex.Roblox.Users.ApiV1.Api.UserSearchApi

All URIs are relative to *https://users.roblox.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**V1UsersSearchGet**](UserSearchApi.md#v1userssearchget) | **GET** /v1/users/search | Searches for users by keyword. |

<a id="v1userssearchget"></a>
# **V1UsersSearchGet**
> RobloxWebWebAPIModelsApiPageResponseRobloxUsersApiUserSearchResponse V1UsersSearchGet (string keyword, string sessionId = null, int? limit = null, string cursor = null)

Searches for users by keyword.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.Roblox.Users.ApiV1.Api;
using Knedlex.Roblox.Users.ApiV1.Client;
using Knedlex.Roblox.Users.ApiV1.Model;

namespace Example
{
    public class V1UsersSearchGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://users.roblox.com";
            var apiInstance = new UserSearchApi(config);
            var keyword = "keyword_example";  // string | The search keyword.
            var sessionId = "sessionId_example";  // string |  (optional) 
            var limit = 10;  // int? | The number of results per request. (optional)  (default to 10)
            var cursor = "cursor_example";  // string | The paging cursor for the previous or next page. (optional) 

            try
            {
                // Searches for users by keyword.
                RobloxWebWebAPIModelsApiPageResponseRobloxUsersApiUserSearchResponse result = apiInstance.V1UsersSearchGet(keyword, sessionId, limit, cursor);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserSearchApi.V1UsersSearchGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1UsersSearchGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Searches for users by keyword.
    ApiResponse<RobloxWebWebAPIModelsApiPageResponseRobloxUsersApiUserSearchResponse> response = apiInstance.V1UsersSearchGetWithHttpInfo(keyword, sessionId, limit, cursor);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserSearchApi.V1UsersSearchGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **keyword** | **string** | The search keyword. |  |
| **sessionId** | **string** |  | [optional]  |
| **limit** | **int?** | The number of results per request. | [optional] [default to 10] |
| **cursor** | **string** | The paging cursor for the previous or next page. | [optional]  |

### Return type

[**RobloxWebWebAPIModelsApiPageResponseRobloxUsersApiUserSearchResponse**](RobloxWebWebAPIModelsApiPageResponseRobloxUsersApiUserSearchResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | 5: The keyword was filtered.  6: The keyword is too short. |  -  |
| **429** | 4: Too many requests. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

