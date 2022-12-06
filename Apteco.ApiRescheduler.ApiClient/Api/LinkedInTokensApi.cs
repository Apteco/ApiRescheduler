/* 
 * Apteco API
 *
 * An API to allow access to Apteco Marketing Suite resources
 *
 * OpenAPI spec version: v2
 * Contact: support@apteco.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp.Portable;
using Apteco.ApiRescheduler.ApiClient.Client;
using Apteco.ApiRescheduler.ApiClient.Model;

namespace Apteco.ApiRescheduler.ApiClient.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public interface ILinkedInTokensApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Gets a list of linkedIn tokens for this user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="username">the username who you wish to get the linkedIn tokens from</param>
        /// <param name="systemName">If specified, whether to limit to only users attached to the system name (optional)</param>
        /// <returns>List&lt;LinkedInEntity&gt;</returns>
        List<LinkedInEntity> LinkedInTokensGetLinkedInEntities (string dataViewName, string username, string systemName = null);

        /// <summary>
        /// Gets a list of linkedIn tokens for this user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="username">the username who you wish to get the linkedIn tokens from</param>
        /// <param name="systemName">If specified, whether to limit to only users attached to the system name (optional)</param>
        /// <returns>ApiResponse of List&lt;LinkedInEntity&gt;</returns>
        ApiResponse<List<LinkedInEntity>> LinkedInTokensGetLinkedInEntitiesWithHttpInfo (string dataViewName, string username, string systemName = null);
        /// <summary>
        /// Validates and stores a linkedIn token, generating the appropriate page tokens if required
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="username"></param>
        /// <param name="body">The details of the tokens to validate and store (optional)</param>
        /// <returns>AuthorisedPermissionWithLookups</returns>
        AuthorisedPermissionWithLookups LinkedInTokensValidateAndStoreLinkedInTokens (string dataViewName, string username, ValidateAndStoreLinkedInTokens body = null);

        /// <summary>
        /// Validates and stores a linkedIn token, generating the appropriate page tokens if required
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="username"></param>
        /// <param name="body">The details of the tokens to validate and store (optional)</param>
        /// <returns>ApiResponse of AuthorisedPermissionWithLookups</returns>
        ApiResponse<AuthorisedPermissionWithLookups> LinkedInTokensValidateAndStoreLinkedInTokensWithHttpInfo (string dataViewName, string username, ValidateAndStoreLinkedInTokens body = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Gets a list of linkedIn tokens for this user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="username">the username who you wish to get the linkedIn tokens from</param>
        /// <param name="systemName">If specified, whether to limit to only users attached to the system name (optional)</param>
        /// <returns>Task of List&lt;LinkedInEntity&gt;</returns>
        System.Threading.Tasks.Task<List<LinkedInEntity>> LinkedInTokensGetLinkedInEntitiesAsync (string dataViewName, string username, string systemName = null);

        /// <summary>
        /// Gets a list of linkedIn tokens for this user
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="username">the username who you wish to get the linkedIn tokens from</param>
        /// <param name="systemName">If specified, whether to limit to only users attached to the system name (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;LinkedInEntity&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<LinkedInEntity>>> LinkedInTokensGetLinkedInEntitiesAsyncWithHttpInfo (string dataViewName, string username, string systemName = null);
        /// <summary>
        /// Validates and stores a linkedIn token, generating the appropriate page tokens if required
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="username"></param>
        /// <param name="body">The details of the tokens to validate and store (optional)</param>
        /// <returns>Task of AuthorisedPermissionWithLookups</returns>
        System.Threading.Tasks.Task<AuthorisedPermissionWithLookups> LinkedInTokensValidateAndStoreLinkedInTokensAsync (string dataViewName, string username, ValidateAndStoreLinkedInTokens body = null);

        /// <summary>
        /// Validates and stores a linkedIn token, generating the appropriate page tokens if required
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="username"></param>
        /// <param name="body">The details of the tokens to validate and store (optional)</param>
        /// <returns>Task of ApiResponse (AuthorisedPermissionWithLookups)</returns>
        System.Threading.Tasks.Task<ApiResponse<AuthorisedPermissionWithLookups>> LinkedInTokensValidateAndStoreLinkedInTokensAsyncWithHttpInfo (string dataViewName, string username, ValidateAndStoreLinkedInTokens body = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class LinkedInTokensApi : ILinkedInTokensApi
    {
        private Apteco.ApiRescheduler.ApiClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkedInTokensApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LinkedInTokensApi(String basePath)
        {
            this.Configuration = new Apteco.ApiRescheduler.ApiClient.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Apteco.ApiRescheduler.ApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkedInTokensApi"/> class
        /// </summary>
        /// <returns></returns>
        public LinkedInTokensApi()
        {
            this.Configuration = Apteco.ApiRescheduler.ApiClient.Client.Configuration.Default;

            ExceptionFactory = Apteco.ApiRescheduler.ApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkedInTokensApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public LinkedInTokensApi(Apteco.ApiRescheduler.ApiClient.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Apteco.ApiRescheduler.ApiClient.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Apteco.ApiRescheduler.ApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Apteco.ApiRescheduler.ApiClient.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Apteco.ApiRescheduler.ApiClient.Client.ExceptionFactory ExceptionFactory
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
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Gets a list of linkedIn tokens for this user 
        /// </summary>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="username">the username who you wish to get the linkedIn tokens from</param>
        /// <param name="systemName">If specified, whether to limit to only users attached to the system name (optional)</param>
        /// <returns>List&lt;LinkedInEntity&gt;</returns>
        public List<LinkedInEntity> LinkedInTokensGetLinkedInEntities (string dataViewName, string username, string systemName = null)
        {
             ApiResponse<List<LinkedInEntity>> localVarResponse = LinkedInTokensGetLinkedInEntitiesWithHttpInfo(dataViewName, username, systemName);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets a list of linkedIn tokens for this user 
        /// </summary>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="username">the username who you wish to get the linkedIn tokens from</param>
        /// <param name="systemName">If specified, whether to limit to only users attached to the system name (optional)</param>
        /// <returns>ApiResponse of List&lt;LinkedInEntity&gt;</returns>
        public ApiResponse< List<LinkedInEntity> > LinkedInTokensGetLinkedInEntitiesWithHttpInfo (string dataViewName, string username, string systemName = null)
        {
            // verify the required parameter 'dataViewName' is set
            if (dataViewName == null)
                throw new ApiException(400, "Missing required parameter 'dataViewName' when calling LinkedInTokensApi->LinkedInTokensGetLinkedInEntities");
            // verify the required parameter 'username' is set
            if (username == null)
                throw new ApiException(400, "Missing required parameter 'username' when calling LinkedInTokensApi->LinkedInTokensGetLinkedInEntities");

            var localVarPath = "./{dataViewName}/LinkedInTokens/{username}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (dataViewName != null) localVarPathParams.Add("dataViewName", this.Configuration.ApiClient.ParameterToString(dataViewName)); // path parameter
            if (username != null) localVarPathParams.Add("username", this.Configuration.ApiClient.ParameterToString(username)); // path parameter
            if (systemName != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "systemName", systemName)); // query parameter
            // authentication (faststats_auth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("LinkedInTokensGetLinkedInEntities", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<LinkedInEntity>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (List<LinkedInEntity>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<LinkedInEntity>)));
        }

        /// <summary>
        /// Gets a list of linkedIn tokens for this user 
        /// </summary>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="username">the username who you wish to get the linkedIn tokens from</param>
        /// <param name="systemName">If specified, whether to limit to only users attached to the system name (optional)</param>
        /// <returns>Task of List&lt;LinkedInEntity&gt;</returns>
        public async System.Threading.Tasks.Task<List<LinkedInEntity>> LinkedInTokensGetLinkedInEntitiesAsync (string dataViewName, string username, string systemName = null)
        {
             ApiResponse<List<LinkedInEntity>> localVarResponse = await LinkedInTokensGetLinkedInEntitiesAsyncWithHttpInfo(dataViewName, username, systemName);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets a list of linkedIn tokens for this user 
        /// </summary>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="username">the username who you wish to get the linkedIn tokens from</param>
        /// <param name="systemName">If specified, whether to limit to only users attached to the system name (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;LinkedInEntity&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<LinkedInEntity>>> LinkedInTokensGetLinkedInEntitiesAsyncWithHttpInfo (string dataViewName, string username, string systemName = null)
        {
            // verify the required parameter 'dataViewName' is set
            if (dataViewName == null)
                throw new ApiException(400, "Missing required parameter 'dataViewName' when calling LinkedInTokensApi->LinkedInTokensGetLinkedInEntities");
            // verify the required parameter 'username' is set
            if (username == null)
                throw new ApiException(400, "Missing required parameter 'username' when calling LinkedInTokensApi->LinkedInTokensGetLinkedInEntities");

            var localVarPath = "./{dataViewName}/LinkedInTokens/{username}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (dataViewName != null) localVarPathParams.Add("dataViewName", this.Configuration.ApiClient.ParameterToString(dataViewName)); // path parameter
            if (username != null) localVarPathParams.Add("username", this.Configuration.ApiClient.ParameterToString(username)); // path parameter
            if (systemName != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "systemName", systemName)); // query parameter
            // authentication (faststats_auth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("LinkedInTokensGetLinkedInEntities", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<LinkedInEntity>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (List<LinkedInEntity>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<LinkedInEntity>)));
        }

        /// <summary>
        /// Validates and stores a linkedIn token, generating the appropriate page tokens if required 
        /// </summary>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="username"></param>
        /// <param name="body">The details of the tokens to validate and store (optional)</param>
        /// <returns>AuthorisedPermissionWithLookups</returns>
        public AuthorisedPermissionWithLookups LinkedInTokensValidateAndStoreLinkedInTokens (string dataViewName, string username, ValidateAndStoreLinkedInTokens body = null)
        {
             ApiResponse<AuthorisedPermissionWithLookups> localVarResponse = LinkedInTokensValidateAndStoreLinkedInTokensWithHttpInfo(dataViewName, username, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Validates and stores a linkedIn token, generating the appropriate page tokens if required 
        /// </summary>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="username"></param>
        /// <param name="body">The details of the tokens to validate and store (optional)</param>
        /// <returns>ApiResponse of AuthorisedPermissionWithLookups</returns>
        public ApiResponse< AuthorisedPermissionWithLookups > LinkedInTokensValidateAndStoreLinkedInTokensWithHttpInfo (string dataViewName, string username, ValidateAndStoreLinkedInTokens body = null)
        {
            // verify the required parameter 'dataViewName' is set
            if (dataViewName == null)
                throw new ApiException(400, "Missing required parameter 'dataViewName' when calling LinkedInTokensApi->LinkedInTokensValidateAndStoreLinkedInTokens");
            // verify the required parameter 'username' is set
            if (username == null)
                throw new ApiException(400, "Missing required parameter 'username' when calling LinkedInTokensApi->LinkedInTokensValidateAndStoreLinkedInTokens");

            var localVarPath = "./{dataViewName}/LinkedInTokens/{username}/ValidateAndStore";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (dataViewName != null) localVarPathParams.Add("dataViewName", this.Configuration.ApiClient.ParameterToString(dataViewName)); // path parameter
            if (username != null) localVarPathParams.Add("username", this.Configuration.ApiClient.ParameterToString(username)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
            // authentication (faststats_auth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("LinkedInTokensValidateAndStoreLinkedInTokens", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AuthorisedPermissionWithLookups>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (AuthorisedPermissionWithLookups) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuthorisedPermissionWithLookups)));
        }

        /// <summary>
        /// Validates and stores a linkedIn token, generating the appropriate page tokens if required 
        /// </summary>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="username"></param>
        /// <param name="body">The details of the tokens to validate and store (optional)</param>
        /// <returns>Task of AuthorisedPermissionWithLookups</returns>
        public async System.Threading.Tasks.Task<AuthorisedPermissionWithLookups> LinkedInTokensValidateAndStoreLinkedInTokensAsync (string dataViewName, string username, ValidateAndStoreLinkedInTokens body = null)
        {
             ApiResponse<AuthorisedPermissionWithLookups> localVarResponse = await LinkedInTokensValidateAndStoreLinkedInTokensAsyncWithHttpInfo(dataViewName, username, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Validates and stores a linkedIn token, generating the appropriate page tokens if required 
        /// </summary>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="username"></param>
        /// <param name="body">The details of the tokens to validate and store (optional)</param>
        /// <returns>Task of ApiResponse (AuthorisedPermissionWithLookups)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AuthorisedPermissionWithLookups>> LinkedInTokensValidateAndStoreLinkedInTokensAsyncWithHttpInfo (string dataViewName, string username, ValidateAndStoreLinkedInTokens body = null)
        {
            // verify the required parameter 'dataViewName' is set
            if (dataViewName == null)
                throw new ApiException(400, "Missing required parameter 'dataViewName' when calling LinkedInTokensApi->LinkedInTokensValidateAndStoreLinkedInTokens");
            // verify the required parameter 'username' is set
            if (username == null)
                throw new ApiException(400, "Missing required parameter 'username' when calling LinkedInTokensApi->LinkedInTokensValidateAndStoreLinkedInTokens");

            var localVarPath = "./{dataViewName}/LinkedInTokens/{username}/ValidateAndStore";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (dataViewName != null) localVarPathParams.Add("dataViewName", this.Configuration.ApiClient.ParameterToString(dataViewName)); // path parameter
            if (username != null) localVarPathParams.Add("username", this.Configuration.ApiClient.ParameterToString(username)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
            // authentication (faststats_auth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("LinkedInTokensValidateAndStoreLinkedInTokens", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AuthorisedPermissionWithLookups>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (AuthorisedPermissionWithLookups) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AuthorisedPermissionWithLookups)));
        }

    }
}
