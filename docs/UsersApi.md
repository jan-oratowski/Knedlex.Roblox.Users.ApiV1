# Knedlex.Roblox.Users.ApiV1.Api.UsersApi

All URIs are relative to *https://users.roblox.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**V1UsernamesUsersPost**](UsersApi.md#v1usernamesuserspost) | **POST** /v1/usernames/users | Get users by usernames. |
| [**V1UsersAuthenticatedAgeBracketGet**](UsersApi.md#v1usersauthenticatedagebracketget) | **GET** /v1/users/authenticated/age-bracket | Gets the age bracket of the authenticated user. |
| [**V1UsersAuthenticatedCountryCodeGet**](UsersApi.md#v1usersauthenticatedcountrycodeget) | **GET** /v1/users/authenticated/country-code | Gets the country code of the authenticated user. |
| [**V1UsersAuthenticatedGet**](UsersApi.md#v1usersauthenticatedget) | **GET** /v1/users/authenticated | Gets the minimal authenticated user. |
| [**V1UsersAuthenticatedRolesGet**](UsersApi.md#v1usersauthenticatedrolesget) | **GET** /v1/users/authenticated/roles | Gets the (public) roles of the authenticated user, such as &#x60;\&quot;Soothsayer\&quot;&#x60; and &#x60;\&quot;BetaTester\&quot;&#x60;. |
| [**V1UsersPost**](UsersApi.md#v1userspost) | **POST** /v1/users | Get users by ids. |
| [**V1UsersUserIdGet**](UsersApi.md#v1usersuseridget) | **GET** /v1/users/{userId} | Gets detailed user information by id. |

<a id="v1usernamesuserspost"></a>
# **V1UsernamesUsersPost**
> RobloxWebWebAPIModelsApiArrayResponseRobloxUsersApiMultiGetUserByNameResponse V1UsernamesUsersPost (RobloxUsersApiMultiGetByUsernameRequest request)

Get users by usernames.

This endpoint will also check previous usernames.  Does not require X-CSRF-Token protection because this is essentially a get request but as a POST to avoid URI limits.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.Roblox.Users.ApiV1.Api;
using Knedlex.Roblox.Users.ApiV1.Client;
using Knedlex.Roblox.Users.ApiV1.Model;

namespace Example
{
    public class V1UsernamesUsersPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://users.roblox.com";
            var apiInstance = new UsersApi(config);
            var request = new RobloxUsersApiMultiGetByUsernameRequest(); // RobloxUsersApiMultiGetByUsernameRequest | The Roblox.Users.Api.MultiGetByUsernameRequest.

            try
            {
                // Get users by usernames.
                RobloxWebWebAPIModelsApiArrayResponseRobloxUsersApiMultiGetUserByNameResponse result = apiInstance.V1UsernamesUsersPost(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.V1UsernamesUsersPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1UsernamesUsersPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get users by usernames.
    ApiResponse<RobloxWebWebAPIModelsApiArrayResponseRobloxUsersApiMultiGetUserByNameResponse> response = apiInstance.V1UsernamesUsersPostWithHttpInfo(request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.V1UsernamesUsersPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**RobloxUsersApiMultiGetByUsernameRequest**](RobloxUsersApiMultiGetByUsernameRequest.md) | The Roblox.Users.Api.MultiGetByUsernameRequest. |  |

### Return type

[**RobloxWebWebAPIModelsApiArrayResponseRobloxUsersApiMultiGetUserByNameResponse**](RobloxWebWebAPIModelsApiArrayResponseRobloxUsersApiMultiGetUserByNameResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | 2: Too many usernames. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1usersauthenticatedagebracketget"></a>
# **V1UsersAuthenticatedAgeBracketGet**
> RobloxUsersApiUserAgeBracketResponse V1UsersAuthenticatedAgeBracketGet ()

Gets the age bracket of the authenticated user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.Roblox.Users.ApiV1.Api;
using Knedlex.Roblox.Users.ApiV1.Client;
using Knedlex.Roblox.Users.ApiV1.Model;

namespace Example
{
    public class V1UsersAuthenticatedAgeBracketGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://users.roblox.com";
            var apiInstance = new UsersApi(config);

            try
            {
                // Gets the age bracket of the authenticated user.
                RobloxUsersApiUserAgeBracketResponse result = apiInstance.V1UsersAuthenticatedAgeBracketGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.V1UsersAuthenticatedAgeBracketGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1UsersAuthenticatedAgeBracketGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the age bracket of the authenticated user.
    ApiResponse<RobloxUsersApiUserAgeBracketResponse> response = apiInstance.V1UsersAuthenticatedAgeBracketGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.V1UsersAuthenticatedAgeBracketGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**RobloxUsersApiUserAgeBracketResponse**](RobloxUsersApiUserAgeBracketResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | 0: Authorization has been denied for this request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1usersauthenticatedcountrycodeget"></a>
# **V1UsersAuthenticatedCountryCodeGet**
> RobloxUsersApiUserCountryCodeResponse V1UsersAuthenticatedCountryCodeGet ()

Gets the country code of the authenticated user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.Roblox.Users.ApiV1.Api;
using Knedlex.Roblox.Users.ApiV1.Client;
using Knedlex.Roblox.Users.ApiV1.Model;

namespace Example
{
    public class V1UsersAuthenticatedCountryCodeGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://users.roblox.com";
            var apiInstance = new UsersApi(config);

            try
            {
                // Gets the country code of the authenticated user.
                RobloxUsersApiUserCountryCodeResponse result = apiInstance.V1UsersAuthenticatedCountryCodeGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.V1UsersAuthenticatedCountryCodeGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1UsersAuthenticatedCountryCodeGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the country code of the authenticated user.
    ApiResponse<RobloxUsersApiUserCountryCodeResponse> response = apiInstance.V1UsersAuthenticatedCountryCodeGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.V1UsersAuthenticatedCountryCodeGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**RobloxUsersApiUserCountryCodeResponse**](RobloxUsersApiUserCountryCodeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | 0: Authorization has been denied for this request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1usersauthenticatedget"></a>
# **V1UsersAuthenticatedGet**
> RobloxUsersApiAuthenticatedUserResponse V1UsersAuthenticatedGet ()

Gets the minimal authenticated user.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.Roblox.Users.ApiV1.Api;
using Knedlex.Roblox.Users.ApiV1.Client;
using Knedlex.Roblox.Users.ApiV1.Model;

namespace Example
{
    public class V1UsersAuthenticatedGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://users.roblox.com";
            var apiInstance = new UsersApi(config);

            try
            {
                // Gets the minimal authenticated user.
                RobloxUsersApiAuthenticatedUserResponse result = apiInstance.V1UsersAuthenticatedGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.V1UsersAuthenticatedGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1UsersAuthenticatedGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the minimal authenticated user.
    ApiResponse<RobloxUsersApiAuthenticatedUserResponse> response = apiInstance.V1UsersAuthenticatedGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.V1UsersAuthenticatedGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**RobloxUsersApiAuthenticatedUserResponse**](RobloxUsersApiAuthenticatedUserResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | 0: Authorization has been denied for this request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1usersauthenticatedrolesget"></a>
# **V1UsersAuthenticatedRolesGet**
> RobloxUsersApiUserRolesResponse V1UsersAuthenticatedRolesGet ()

Gets the (public) roles of the authenticated user, such as `\"Soothsayer\"` and `\"BetaTester\"`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.Roblox.Users.ApiV1.Api;
using Knedlex.Roblox.Users.ApiV1.Client;
using Knedlex.Roblox.Users.ApiV1.Model;

namespace Example
{
    public class V1UsersAuthenticatedRolesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://users.roblox.com";
            var apiInstance = new UsersApi(config);

            try
            {
                // Gets the (public) roles of the authenticated user, such as `\"Soothsayer\"` and `\"BetaTester\"`.
                RobloxUsersApiUserRolesResponse result = apiInstance.V1UsersAuthenticatedRolesGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.V1UsersAuthenticatedRolesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1UsersAuthenticatedRolesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets the (public) roles of the authenticated user, such as `\"Soothsayer\"` and `\"BetaTester\"`.
    ApiResponse<RobloxUsersApiUserRolesResponse> response = apiInstance.V1UsersAuthenticatedRolesGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.V1UsersAuthenticatedRolesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**RobloxUsersApiUserRolesResponse**](RobloxUsersApiUserRolesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | 0: Authorization has been denied for this request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1userspost"></a>
# **V1UsersPost**
> RobloxWebWebAPIModelsApiArrayResponseRobloxUsersApiVerifiedBadgeUserResponse V1UsersPost (RobloxUsersApiMultiGetByUserIdRequest request)

Get users by ids.

Does not require X-CSRF-Token protection because this is essentially a get request but as a POST to avoid URI limits.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.Roblox.Users.ApiV1.Api;
using Knedlex.Roblox.Users.ApiV1.Client;
using Knedlex.Roblox.Users.ApiV1.Model;

namespace Example
{
    public class V1UsersPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://users.roblox.com";
            var apiInstance = new UsersApi(config);
            var request = new RobloxUsersApiMultiGetByUserIdRequest(); // RobloxUsersApiMultiGetByUserIdRequest | The Roblox.Users.Api.MultiGetByUserIdRequest.

            try
            {
                // Get users by ids.
                RobloxWebWebAPIModelsApiArrayResponseRobloxUsersApiVerifiedBadgeUserResponse result = apiInstance.V1UsersPost(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.V1UsersPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1UsersPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get users by ids.
    ApiResponse<RobloxWebWebAPIModelsApiArrayResponseRobloxUsersApiVerifiedBadgeUserResponse> response = apiInstance.V1UsersPostWithHttpInfo(request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.V1UsersPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**RobloxUsersApiMultiGetByUserIdRequest**](RobloxUsersApiMultiGetByUserIdRequest.md) | The Roblox.Users.Api.MultiGetByUserIdRequest. |  |

### Return type

[**RobloxWebWebAPIModelsApiArrayResponseRobloxUsersApiVerifiedBadgeUserResponse**](RobloxWebWebAPIModelsApiArrayResponseRobloxUsersApiVerifiedBadgeUserResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | 1: Too many ids. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1usersuseridget"></a>
# **V1UsersUserIdGet**
> RobloxUsersApiGetUserResponse V1UsersUserIdGet (long userId)

Gets detailed user information by id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.Roblox.Users.ApiV1.Api;
using Knedlex.Roblox.Users.ApiV1.Client;
using Knedlex.Roblox.Users.ApiV1.Model;

namespace Example
{
    public class V1UsersUserIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://users.roblox.com";
            var apiInstance = new UsersApi(config);
            var userId = 789L;  // long | The user id.

            try
            {
                // Gets detailed user information by id.
                RobloxUsersApiGetUserResponse result = apiInstance.V1UsersUserIdGet(userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UsersApi.V1UsersUserIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1UsersUserIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Gets detailed user information by id.
    ApiResponse<RobloxUsersApiGetUserResponse> response = apiInstance.V1UsersUserIdGetWithHttpInfo(userId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UsersApi.V1UsersUserIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **long** | The user id. |  |

### Return type

[**RobloxUsersApiGetUserResponse**](RobloxUsersApiGetUserResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | 3: The user id is invalid. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

