/*
 * Users Api v1
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Knedlex.Roblox.Users.ApiV1.Client;
using Knedlex.Roblox.Users.ApiV1.Model;

namespace Knedlex.Roblox.Users.ApiV1.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUsernamesApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Retrieves the username history for a particular user.
        /// </summary>
        /// <exception cref="Knedlex.Roblox.Users.ApiV1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="limit">The number of results per request. (optional, default to 10)</param>
        /// <param name="cursor">The paging cursor for the previous or next page. (optional)</param>
        /// <param name="sortOrder">The order the results are sorted in. (optional, default to Asc)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>RobloxWebWebAPIModelsApiPageResponseRobloxUsersApiUsernameHistoryResponse</returns>
        RobloxWebWebAPIModelsApiPageResponseRobloxUsersApiUsernameHistoryResponse V1UsersUserIdUsernameHistoryGet(long userId, int? limit = default(int?), string cursor = default(string), string sortOrder = default(string), int operationIndex = 0);

        /// <summary>
        /// Retrieves the username history for a particular user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Knedlex.Roblox.Users.ApiV1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="limit">The number of results per request. (optional, default to 10)</param>
        /// <param name="cursor">The paging cursor for the previous or next page. (optional)</param>
        /// <param name="sortOrder">The order the results are sorted in. (optional, default to Asc)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of RobloxWebWebAPIModelsApiPageResponseRobloxUsersApiUsernameHistoryResponse</returns>
        ApiResponse<RobloxWebWebAPIModelsApiPageResponseRobloxUsersApiUsernameHistoryResponse> V1UsersUserIdUsernameHistoryGetWithHttpInfo(long userId, int? limit = default(int?), string cursor = default(string), string sortOrder = default(string), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUsernamesApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Retrieves the username history for a particular user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Knedlex.Roblox.Users.ApiV1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="limit">The number of results per request. (optional, default to 10)</param>
        /// <param name="cursor">The paging cursor for the previous or next page. (optional)</param>
        /// <param name="sortOrder">The order the results are sorted in. (optional, default to Asc)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of RobloxWebWebAPIModelsApiPageResponseRobloxUsersApiUsernameHistoryResponse</returns>
        System.Threading.Tasks.Task<RobloxWebWebAPIModelsApiPageResponseRobloxUsersApiUsernameHistoryResponse> V1UsersUserIdUsernameHistoryGetAsync(long userId, int? limit = default(int?), string cursor = default(string), string sortOrder = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Retrieves the username history for a particular user.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Knedlex.Roblox.Users.ApiV1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="limit">The number of results per request. (optional, default to 10)</param>
        /// <param name="cursor">The paging cursor for the previous or next page. (optional)</param>
        /// <param name="sortOrder">The order the results are sorted in. (optional, default to Asc)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (RobloxWebWebAPIModelsApiPageResponseRobloxUsersApiUsernameHistoryResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<RobloxWebWebAPIModelsApiPageResponseRobloxUsersApiUsernameHistoryResponse>> V1UsersUserIdUsernameHistoryGetWithHttpInfoAsync(long userId, int? limit = default(int?), string cursor = default(string), string sortOrder = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUsernamesApi : IUsernamesApiSync, IUsernamesApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class UsernamesApi : IUsernamesApi
    {
        private Knedlex.Roblox.Users.ApiV1.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="UsernamesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UsernamesApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsernamesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UsernamesApi(string basePath)
        {
            this.Configuration = Knedlex.Roblox.Users.ApiV1.Client.Configuration.MergeConfigurations(
                Knedlex.Roblox.Users.ApiV1.Client.GlobalConfiguration.Instance,
                new Knedlex.Roblox.Users.ApiV1.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Knedlex.Roblox.Users.ApiV1.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Knedlex.Roblox.Users.ApiV1.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Knedlex.Roblox.Users.ApiV1.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsernamesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UsernamesApi(Knedlex.Roblox.Users.ApiV1.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Knedlex.Roblox.Users.ApiV1.Client.Configuration.MergeConfigurations(
                Knedlex.Roblox.Users.ApiV1.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Knedlex.Roblox.Users.ApiV1.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Knedlex.Roblox.Users.ApiV1.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Knedlex.Roblox.Users.ApiV1.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsernamesApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public UsernamesApi(Knedlex.Roblox.Users.ApiV1.Client.ISynchronousClient client, Knedlex.Roblox.Users.ApiV1.Client.IAsynchronousClient asyncClient, Knedlex.Roblox.Users.ApiV1.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Knedlex.Roblox.Users.ApiV1.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Knedlex.Roblox.Users.ApiV1.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Knedlex.Roblox.Users.ApiV1.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Knedlex.Roblox.Users.ApiV1.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Knedlex.Roblox.Users.ApiV1.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Retrieves the username history for a particular user. 
        /// </summary>
        /// <exception cref="Knedlex.Roblox.Users.ApiV1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="limit">The number of results per request. (optional, default to 10)</param>
        /// <param name="cursor">The paging cursor for the previous or next page. (optional)</param>
        /// <param name="sortOrder">The order the results are sorted in. (optional, default to Asc)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>RobloxWebWebAPIModelsApiPageResponseRobloxUsersApiUsernameHistoryResponse</returns>
        public RobloxWebWebAPIModelsApiPageResponseRobloxUsersApiUsernameHistoryResponse V1UsersUserIdUsernameHistoryGet(long userId, int? limit = default(int?), string cursor = default(string), string sortOrder = default(string), int operationIndex = 0)
        {
            Knedlex.Roblox.Users.ApiV1.Client.ApiResponse<RobloxWebWebAPIModelsApiPageResponseRobloxUsersApiUsernameHistoryResponse> localVarResponse = V1UsersUserIdUsernameHistoryGetWithHttpInfo(userId, limit, cursor, sortOrder);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves the username history for a particular user. 
        /// </summary>
        /// <exception cref="Knedlex.Roblox.Users.ApiV1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="limit">The number of results per request. (optional, default to 10)</param>
        /// <param name="cursor">The paging cursor for the previous or next page. (optional)</param>
        /// <param name="sortOrder">The order the results are sorted in. (optional, default to Asc)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of RobloxWebWebAPIModelsApiPageResponseRobloxUsersApiUsernameHistoryResponse</returns>
        public Knedlex.Roblox.Users.ApiV1.Client.ApiResponse<RobloxWebWebAPIModelsApiPageResponseRobloxUsersApiUsernameHistoryResponse> V1UsersUserIdUsernameHistoryGetWithHttpInfo(long userId, int? limit = default(int?), string cursor = default(string), string sortOrder = default(string), int operationIndex = 0)
        {
            Knedlex.Roblox.Users.ApiV1.Client.RequestOptions localVarRequestOptions = new Knedlex.Roblox.Users.ApiV1.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json",
                "text/json"
            };

            var localVarContentType = Knedlex.Roblox.Users.ApiV1.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Knedlex.Roblox.Users.ApiV1.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("userId", Knedlex.Roblox.Users.ApiV1.Client.ClientUtils.ParameterToString(userId)); // path parameter
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(Knedlex.Roblox.Users.ApiV1.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
            }
            if (cursor != null)
            {
                localVarRequestOptions.QueryParameters.Add(Knedlex.Roblox.Users.ApiV1.Client.ClientUtils.ParameterToMultiMap("", "cursor", cursor));
            }
            if (sortOrder != null)
            {
                localVarRequestOptions.QueryParameters.Add(Knedlex.Roblox.Users.ApiV1.Client.ClientUtils.ParameterToMultiMap("", "sortOrder", sortOrder));
            }

            localVarRequestOptions.Operation = "UsernamesApi.V1UsersUserIdUsernameHistoryGet";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = this.Client.Get<RobloxWebWebAPIModelsApiPageResponseRobloxUsersApiUsernameHistoryResponse>("/v1/users/{userId}/username-history", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("V1UsersUserIdUsernameHistoryGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retrieves the username history for a particular user. 
        /// </summary>
        /// <exception cref="Knedlex.Roblox.Users.ApiV1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="limit">The number of results per request. (optional, default to 10)</param>
        /// <param name="cursor">The paging cursor for the previous or next page. (optional)</param>
        /// <param name="sortOrder">The order the results are sorted in. (optional, default to Asc)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of RobloxWebWebAPIModelsApiPageResponseRobloxUsersApiUsernameHistoryResponse</returns>
        public async System.Threading.Tasks.Task<RobloxWebWebAPIModelsApiPageResponseRobloxUsersApiUsernameHistoryResponse> V1UsersUserIdUsernameHistoryGetAsync(long userId, int? limit = default(int?), string cursor = default(string), string sortOrder = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Knedlex.Roblox.Users.ApiV1.Client.ApiResponse<RobloxWebWebAPIModelsApiPageResponseRobloxUsersApiUsernameHistoryResponse> localVarResponse = await V1UsersUserIdUsernameHistoryGetWithHttpInfoAsync(userId, limit, cursor, sortOrder, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves the username history for a particular user. 
        /// </summary>
        /// <exception cref="Knedlex.Roblox.Users.ApiV1.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="limit">The number of results per request. (optional, default to 10)</param>
        /// <param name="cursor">The paging cursor for the previous or next page. (optional)</param>
        /// <param name="sortOrder">The order the results are sorted in. (optional, default to Asc)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (RobloxWebWebAPIModelsApiPageResponseRobloxUsersApiUsernameHistoryResponse)</returns>
        public async System.Threading.Tasks.Task<Knedlex.Roblox.Users.ApiV1.Client.ApiResponse<RobloxWebWebAPIModelsApiPageResponseRobloxUsersApiUsernameHistoryResponse>> V1UsersUserIdUsernameHistoryGetWithHttpInfoAsync(long userId, int? limit = default(int?), string cursor = default(string), string sortOrder = default(string), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Knedlex.Roblox.Users.ApiV1.Client.RequestOptions localVarRequestOptions = new Knedlex.Roblox.Users.ApiV1.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json",
                "text/json"
            };

            var localVarContentType = Knedlex.Roblox.Users.ApiV1.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Knedlex.Roblox.Users.ApiV1.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("userId", Knedlex.Roblox.Users.ApiV1.Client.ClientUtils.ParameterToString(userId)); // path parameter
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(Knedlex.Roblox.Users.ApiV1.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
            }
            if (cursor != null)
            {
                localVarRequestOptions.QueryParameters.Add(Knedlex.Roblox.Users.ApiV1.Client.ClientUtils.ParameterToMultiMap("", "cursor", cursor));
            }
            if (sortOrder != null)
            {
                localVarRequestOptions.QueryParameters.Add(Knedlex.Roblox.Users.ApiV1.Client.ClientUtils.ParameterToMultiMap("", "sortOrder", sortOrder));
            }

            localVarRequestOptions.Operation = "UsernamesApi.V1UsersUserIdUsernameHistoryGet";
            localVarRequestOptions.OperationIndex = operationIndex;


            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<RobloxWebWebAPIModelsApiPageResponseRobloxUsersApiUsernameHistoryResponse>("/v1/users/{userId}/username-history", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("V1UsersUserIdUsernameHistoryGet", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}