# Knedlex.Roblox.Users.ApiV1.Api.AccountInformationApi

All URIs are relative to *https://users.roblox.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**V1BirthdateGet**](AccountInformationApi.md#v1birthdateget) | **GET** /v1/birthdate | Get the user&#39;s birthdate |
| [**V1BirthdatePost**](AccountInformationApi.md#v1birthdatepost) | **POST** /v1/birthdate | Update the user&#39;s birthdate |
| [**V1DescriptionGet**](AccountInformationApi.md#v1descriptionget) | **GET** /v1/description | Get the user&#39;s description |
| [**V1DescriptionPost**](AccountInformationApi.md#v1descriptionpost) | **POST** /v1/description | Update the user&#39;s description |
| [**V1GenderGet**](AccountInformationApi.md#v1genderget) | **GET** /v1/gender | Get the user&#39;s gender |
| [**V1GenderPost**](AccountInformationApi.md#v1genderpost) | **POST** /v1/gender | Update the user&#39;s gender |

<a id="v1birthdateget"></a>
# **V1BirthdateGet**
> RobloxUsersApiBirthdateResponse V1BirthdateGet ()

Get the user's birthdate

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.Roblox.Users.ApiV1.Api;
using Knedlex.Roblox.Users.ApiV1.Client;
using Knedlex.Roblox.Users.ApiV1.Model;

namespace Example
{
    public class V1BirthdateGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://users.roblox.com";
            var apiInstance = new AccountInformationApi(config);

            try
            {
                // Get the user's birthdate
                RobloxUsersApiBirthdateResponse result = apiInstance.V1BirthdateGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountInformationApi.V1BirthdateGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1BirthdateGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the user's birthdate
    ApiResponse<RobloxUsersApiBirthdateResponse> response = apiInstance.V1BirthdateGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountInformationApi.V1BirthdateGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**RobloxUsersApiBirthdateResponse**](RobloxUsersApiBirthdateResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | 1: User not found. |  -  |
| **401** | 0: Authorization has been denied for this request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1birthdatepost"></a>
# **V1BirthdatePost**
> Object V1BirthdatePost (RobloxUsersApiBirthdateRequest request)

Update the user's birthdate

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.Roblox.Users.ApiV1.Api;
using Knedlex.Roblox.Users.ApiV1.Client;
using Knedlex.Roblox.Users.ApiV1.Model;

namespace Example
{
    public class V1BirthdatePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://users.roblox.com";
            var apiInstance = new AccountInformationApi(config);
            var request = new RobloxUsersApiBirthdateRequest(); // RobloxUsersApiBirthdateRequest | The Roblox.Users.Api.BirthdateRequest

            try
            {
                // Update the user's birthdate
                Object result = apiInstance.V1BirthdatePost(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountInformationApi.V1BirthdatePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1BirthdatePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update the user's birthdate
    ApiResponse<Object> response = apiInstance.V1BirthdatePostWithHttpInfo(request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountInformationApi.V1BirthdatePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**RobloxUsersApiBirthdateRequest**](RobloxUsersApiBirthdateRequest.md) | The Roblox.Users.Api.BirthdateRequest |  |

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
| **400** | 1: User not found.  4: The birthdate provided is invalid.  8: Password is incorrect. |  -  |
| **401** | 0: Authorization has been denied for this request. |  -  |
| **403** | 0: Token Validation Failed  2: PIN is locked.  5: Invalid birthdate change. |  -  |
| **500** | 0: An unknown error occured.  5: Invalid birthdate change. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1descriptionget"></a>
# **V1DescriptionGet**
> RobloxUsersApiDescriptionResponse V1DescriptionGet ()

Get the user's description

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.Roblox.Users.ApiV1.Api;
using Knedlex.Roblox.Users.ApiV1.Client;
using Knedlex.Roblox.Users.ApiV1.Model;

namespace Example
{
    public class V1DescriptionGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://users.roblox.com";
            var apiInstance = new AccountInformationApi(config);

            try
            {
                // Get the user's description
                RobloxUsersApiDescriptionResponse result = apiInstance.V1DescriptionGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountInformationApi.V1DescriptionGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1DescriptionGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the user's description
    ApiResponse<RobloxUsersApiDescriptionResponse> response = apiInstance.V1DescriptionGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountInformationApi.V1DescriptionGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**RobloxUsersApiDescriptionResponse**](RobloxUsersApiDescriptionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | 1: User not found. |  -  |
| **401** | 0: Authorization has been denied for this request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1descriptionpost"></a>
# **V1DescriptionPost**
> RobloxUsersApiDescriptionResponse V1DescriptionPost (RobloxUsersApiDescriptionRequest request)

Update the user's description

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.Roblox.Users.ApiV1.Api;
using Knedlex.Roblox.Users.ApiV1.Client;
using Knedlex.Roblox.Users.ApiV1.Model;

namespace Example
{
    public class V1DescriptionPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://users.roblox.com";
            var apiInstance = new AccountInformationApi(config);
            var request = new RobloxUsersApiDescriptionRequest(); // RobloxUsersApiDescriptionRequest | The Roblox.Users.Api.DescriptionRequest

            try
            {
                // Update the user's description
                RobloxUsersApiDescriptionResponse result = apiInstance.V1DescriptionPost(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountInformationApi.V1DescriptionPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1DescriptionPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update the user's description
    ApiResponse<RobloxUsersApiDescriptionResponse> response = apiInstance.V1DescriptionPostWithHttpInfo(request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountInformationApi.V1DescriptionPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**RobloxUsersApiDescriptionRequest**](RobloxUsersApiDescriptionRequest.md) | The Roblox.Users.Api.DescriptionRequest |  |

### Return type

[**RobloxUsersApiDescriptionResponse**](RobloxUsersApiDescriptionResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | 1: User not found. |  -  |
| **401** | 0: Authorization has been denied for this request. |  -  |
| **403** | 0: Token Validation Failed  2: PIN is locked. |  -  |
| **500** | 0: An unknown error occured. |  -  |
| **503** | 3: This feature is currently disabled. Please try again later. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1genderget"></a>
# **V1GenderGet**
> RobloxUsersApiGenderResponse V1GenderGet ()

Get the user's gender

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.Roblox.Users.ApiV1.Api;
using Knedlex.Roblox.Users.ApiV1.Client;
using Knedlex.Roblox.Users.ApiV1.Model;

namespace Example
{
    public class V1GenderGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://users.roblox.com";
            var apiInstance = new AccountInformationApi(config);

            try
            {
                // Get the user's gender
                RobloxUsersApiGenderResponse result = apiInstance.V1GenderGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountInformationApi.V1GenderGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1GenderGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the user's gender
    ApiResponse<RobloxUsersApiGenderResponse> response = apiInstance.V1GenderGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountInformationApi.V1GenderGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**RobloxUsersApiGenderResponse**](RobloxUsersApiGenderResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | 1: User not found. |  -  |
| **401** | 0: Authorization has been denied for this request. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="v1genderpost"></a>
# **V1GenderPost**
> Object V1GenderPost (RobloxUsersApiGenderRequest request)

Update the user's gender

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Knedlex.Roblox.Users.ApiV1.Api;
using Knedlex.Roblox.Users.ApiV1.Client;
using Knedlex.Roblox.Users.ApiV1.Model;

namespace Example
{
    public class V1GenderPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://users.roblox.com";
            var apiInstance = new AccountInformationApi(config);
            var request = new RobloxUsersApiGenderRequest(); // RobloxUsersApiGenderRequest | The Roblox.Users.Api.GenderRequest

            try
            {
                // Update the user's gender
                Object result = apiInstance.V1GenderPost(request);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountInformationApi.V1GenderPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the V1GenderPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update the user's gender
    ApiResponse<Object> response = apiInstance.V1GenderPostWithHttpInfo(request);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AccountInformationApi.V1GenderPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **request** | [**RobloxUsersApiGenderRequest**](RobloxUsersApiGenderRequest.md) | The Roblox.Users.Api.GenderRequest |  |

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
| **400** | 1: User not found.  6: The gender provided is invalid. |  -  |
| **401** | 0: Authorization has been denied for this request. |  -  |
| **403** | 0: Token Validation Failed  2: PIN is locked. |  -  |
| **500** | 0: An unknown error occured. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

