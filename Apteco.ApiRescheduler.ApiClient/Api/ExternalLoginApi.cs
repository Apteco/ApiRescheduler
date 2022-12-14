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

namespace Apteco.ApiRescheduler.ApiClient.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public interface IExternalLoginApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Initiate the next phase of the login process that establishes a session.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns></returns>
        void ExternalLoginAssertionConsumerService ();

        /// <summary>
        /// Initiate the next phase of the login process that establishes a session.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ExternalLoginAssertionConsumerServiceWithHttpInfo ();
        /// <summary>
        /// Initiate the external login process
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="returnUrl">The URL to redirect to after the login process has been successful (optional)</param>
        /// <returns></returns>
        void ExternalLoginLogin (string returnUrl = null);

        /// <summary>
        /// Initiate the external login process
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="returnUrl">The URL to redirect to after the login process has been successful (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ExternalLoginLoginWithHttpInfo (string returnUrl = null);
        /// <summary>
        /// Initiate a logout from the application.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sAMLRequest">The SAML details (optional)</param>
        /// <returns></returns>
        void ExternalLoginSingleLogoutService (string sAMLRequest = null);

        /// <summary>
        /// Initiate a logout from the application.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sAMLRequest">The SAML details (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ExternalLoginSingleLogoutServiceWithHttpInfo (string sAMLRequest = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Initiate the next phase of the login process that establishes a session.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ExternalLoginAssertionConsumerServiceAsync ();

        /// <summary>
        /// Initiate the next phase of the login process that establishes a session.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ExternalLoginAssertionConsumerServiceAsyncWithHttpInfo ();
        /// <summary>
        /// Initiate the external login process
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="returnUrl">The URL to redirect to after the login process has been successful (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ExternalLoginLoginAsync (string returnUrl = null);

        /// <summary>
        /// Initiate the external login process
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="returnUrl">The URL to redirect to after the login process has been successful (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ExternalLoginLoginAsyncWithHttpInfo (string returnUrl = null);
        /// <summary>
        /// Initiate a logout from the application.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sAMLRequest">The SAML details (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ExternalLoginSingleLogoutServiceAsync (string sAMLRequest = null);

        /// <summary>
        /// Initiate a logout from the application.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sAMLRequest">The SAML details (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ExternalLoginSingleLogoutServiceAsyncWithHttpInfo (string sAMLRequest = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class ExternalLoginApi : IExternalLoginApi
    {
        private Apteco.ApiRescheduler.ApiClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalLoginApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ExternalLoginApi(String basePath)
        {
            this.Configuration = new Apteco.ApiRescheduler.ApiClient.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Apteco.ApiRescheduler.ApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalLoginApi"/> class
        /// </summary>
        /// <returns></returns>
        public ExternalLoginApi()
        {
            this.Configuration = Apteco.ApiRescheduler.ApiClient.Client.Configuration.Default;

            ExceptionFactory = Apteco.ApiRescheduler.ApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalLoginApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ExternalLoginApi(Apteco.ApiRescheduler.ApiClient.Client.Configuration configuration = null)
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
        /// Initiate the next phase of the login process that establishes a session. 
        /// </summary>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns></returns>
        public void ExternalLoginAssertionConsumerService ()
        {
             ExternalLoginAssertionConsumerServiceWithHttpInfo();
        }

        /// <summary>
        /// Initiate the next phase of the login process that establishes a session. 
        /// </summary>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ExternalLoginAssertionConsumerServiceWithHttpInfo ()
        {

            var localVarPath = "./ExternalLogin/AssertionConsumerService";
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
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ExternalLoginAssertionConsumerService", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Initiate the next phase of the login process that establishes a session. 
        /// </summary>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ExternalLoginAssertionConsumerServiceAsync ()
        {
             await ExternalLoginAssertionConsumerServiceAsyncWithHttpInfo();

        }

        /// <summary>
        /// Initiate the next phase of the login process that establishes a session. 
        /// </summary>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ExternalLoginAssertionConsumerServiceAsyncWithHttpInfo ()
        {

            var localVarPath = "./ExternalLogin/AssertionConsumerService";
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
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ExternalLoginAssertionConsumerService", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Initiate the external login process 
        /// </summary>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="returnUrl">The URL to redirect to after the login process has been successful (optional)</param>
        /// <returns></returns>
        public void ExternalLoginLogin (string returnUrl = null)
        {
             ExternalLoginLoginWithHttpInfo(returnUrl);
        }

        /// <summary>
        /// Initiate the external login process 
        /// </summary>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="returnUrl">The URL to redirect to after the login process has been successful (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ExternalLoginLoginWithHttpInfo (string returnUrl = null)
        {

            var localVarPath = "./ExternalLogin/Login";
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
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (returnUrl != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "returnUrl", returnUrl)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ExternalLoginLogin", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Initiate the external login process 
        /// </summary>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="returnUrl">The URL to redirect to after the login process has been successful (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ExternalLoginLoginAsync (string returnUrl = null)
        {
             await ExternalLoginLoginAsyncWithHttpInfo(returnUrl);

        }

        /// <summary>
        /// Initiate the external login process 
        /// </summary>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="returnUrl">The URL to redirect to after the login process has been successful (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ExternalLoginLoginAsyncWithHttpInfo (string returnUrl = null)
        {

            var localVarPath = "./ExternalLogin/Login";
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
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (returnUrl != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "returnUrl", returnUrl)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ExternalLoginLogin", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Initiate a logout from the application. 
        /// </summary>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sAMLRequest">The SAML details (optional)</param>
        /// <returns></returns>
        public void ExternalLoginSingleLogoutService (string sAMLRequest = null)
        {
             ExternalLoginSingleLogoutServiceWithHttpInfo(sAMLRequest);
        }

        /// <summary>
        /// Initiate a logout from the application. 
        /// </summary>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sAMLRequest">The SAML details (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ExternalLoginSingleLogoutServiceWithHttpInfo (string sAMLRequest = null)
        {

            var localVarPath = "./ExternalLogin/SingleLogoutService";
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
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (sAMLRequest != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "SAMLRequest", sAMLRequest)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ExternalLoginSingleLogoutService", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Initiate a logout from the application. 
        /// </summary>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sAMLRequest">The SAML details (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ExternalLoginSingleLogoutServiceAsync (string sAMLRequest = null)
        {
             await ExternalLoginSingleLogoutServiceAsyncWithHttpInfo(sAMLRequest);

        }

        /// <summary>
        /// Initiate a logout from the application. 
        /// </summary>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="sAMLRequest">The SAML details (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ExternalLoginSingleLogoutServiceAsyncWithHttpInfo (string sAMLRequest = null)
        {

            var localVarPath = "./ExternalLogin/SingleLogoutService";
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
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (sAMLRequest != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "SAMLRequest", sAMLRequest)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ExternalLoginSingleLogoutService", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                null);
        }

    }
}
