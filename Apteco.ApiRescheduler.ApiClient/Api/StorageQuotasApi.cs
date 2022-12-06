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
        public interface IStorageQuotasApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Returns a list of storage quotas for the system
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="systemName">The name of the FastStats system to act on</param>
        /// <returns>StorageQuotaDetails</returns>
        StorageQuotaDetails StorageQuotasGetSystemStorageQuotas (string dataViewName, string systemName);

        /// <summary>
        /// Returns a list of storage quotas for the system
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="systemName">The name of the FastStats system to act on</param>
        /// <returns>ApiResponse of StorageQuotaDetails</returns>
        ApiResponse<StorageQuotaDetails> StorageQuotasGetSystemStorageQuotasWithHttpInfo (string dataViewName, string systemName);
        /// <summary>
        /// Updates system storage quotas from the given details
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="systemName">The name of the FastStats system to act on</param>
        /// <param name="body">The details of the storage quotas to update (optional)</param>
        /// <returns>List&lt;ModifyStorageQuotaResults&gt;</returns>
        List<ModifyStorageQuotaResults> StorageQuotasModifySystemStorageQuotas (string dataViewName, string systemName, ModifyItemsModifyStorageQuota body = null);

        /// <summary>
        /// Updates system storage quotas from the given details
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="systemName">The name of the FastStats system to act on</param>
        /// <param name="body">The details of the storage quotas to update (optional)</param>
        /// <returns>ApiResponse of List&lt;ModifyStorageQuotaResults&gt;</returns>
        ApiResponse<List<ModifyStorageQuotaResults>> StorageQuotasModifySystemStorageQuotasWithHttpInfo (string dataViewName, string systemName, ModifyItemsModifyStorageQuota body = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Returns a list of storage quotas for the system
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="systemName">The name of the FastStats system to act on</param>
        /// <returns>Task of StorageQuotaDetails</returns>
        System.Threading.Tasks.Task<StorageQuotaDetails> StorageQuotasGetSystemStorageQuotasAsync (string dataViewName, string systemName);

        /// <summary>
        /// Returns a list of storage quotas for the system
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="systemName">The name of the FastStats system to act on</param>
        /// <returns>Task of ApiResponse (StorageQuotaDetails)</returns>
        System.Threading.Tasks.Task<ApiResponse<StorageQuotaDetails>> StorageQuotasGetSystemStorageQuotasAsyncWithHttpInfo (string dataViewName, string systemName);
        /// <summary>
        /// Updates system storage quotas from the given details
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="systemName">The name of the FastStats system to act on</param>
        /// <param name="body">The details of the storage quotas to update (optional)</param>
        /// <returns>Task of List&lt;ModifyStorageQuotaResults&gt;</returns>
        System.Threading.Tasks.Task<List<ModifyStorageQuotaResults>> StorageQuotasModifySystemStorageQuotasAsync (string dataViewName, string systemName, ModifyItemsModifyStorageQuota body = null);

        /// <summary>
        /// Updates system storage quotas from the given details
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="systemName">The name of the FastStats system to act on</param>
        /// <param name="body">The details of the storage quotas to update (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;ModifyStorageQuotaResults&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<ModifyStorageQuotaResults>>> StorageQuotasModifySystemStorageQuotasAsyncWithHttpInfo (string dataViewName, string systemName, ModifyItemsModifyStorageQuota body = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class StorageQuotasApi : IStorageQuotasApi
    {
        private Apteco.ApiRescheduler.ApiClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageQuotasApi"/> class.
        /// </summary>
        /// <returns></returns>
        public StorageQuotasApi(String basePath)
        {
            this.Configuration = new Apteco.ApiRescheduler.ApiClient.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Apteco.ApiRescheduler.ApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageQuotasApi"/> class
        /// </summary>
        /// <returns></returns>
        public StorageQuotasApi()
        {
            this.Configuration = Apteco.ApiRescheduler.ApiClient.Client.Configuration.Default;

            ExceptionFactory = Apteco.ApiRescheduler.ApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageQuotasApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public StorageQuotasApi(Apteco.ApiRescheduler.ApiClient.Client.Configuration configuration = null)
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
        /// Returns a list of storage quotas for the system 
        /// </summary>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="systemName">The name of the FastStats system to act on</param>
        /// <returns>StorageQuotaDetails</returns>
        public StorageQuotaDetails StorageQuotasGetSystemStorageQuotas (string dataViewName, string systemName)
        {
             ApiResponse<StorageQuotaDetails> localVarResponse = StorageQuotasGetSystemStorageQuotasWithHttpInfo(dataViewName, systemName);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Returns a list of storage quotas for the system 
        /// </summary>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="systemName">The name of the FastStats system to act on</param>
        /// <returns>ApiResponse of StorageQuotaDetails</returns>
        public ApiResponse< StorageQuotaDetails > StorageQuotasGetSystemStorageQuotasWithHttpInfo (string dataViewName, string systemName)
        {
            // verify the required parameter 'dataViewName' is set
            if (dataViewName == null)
                throw new ApiException(400, "Missing required parameter 'dataViewName' when calling StorageQuotasApi->StorageQuotasGetSystemStorageQuotas");
            // verify the required parameter 'systemName' is set
            if (systemName == null)
                throw new ApiException(400, "Missing required parameter 'systemName' when calling StorageQuotasApi->StorageQuotasGetSystemStorageQuotas");

            var localVarPath = "./{dataViewName}/StorageQuotas/{systemName}";
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
            if (systemName != null) localVarPathParams.Add("systemName", this.Configuration.ApiClient.ParameterToString(systemName)); // path parameter
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
                Exception exception = ExceptionFactory("StorageQuotasGetSystemStorageQuotas", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<StorageQuotaDetails>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (StorageQuotaDetails) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(StorageQuotaDetails)));
        }

        /// <summary>
        /// Returns a list of storage quotas for the system 
        /// </summary>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="systemName">The name of the FastStats system to act on</param>
        /// <returns>Task of StorageQuotaDetails</returns>
        public async System.Threading.Tasks.Task<StorageQuotaDetails> StorageQuotasGetSystemStorageQuotasAsync (string dataViewName, string systemName)
        {
             ApiResponse<StorageQuotaDetails> localVarResponse = await StorageQuotasGetSystemStorageQuotasAsyncWithHttpInfo(dataViewName, systemName);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Returns a list of storage quotas for the system 
        /// </summary>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="systemName">The name of the FastStats system to act on</param>
        /// <returns>Task of ApiResponse (StorageQuotaDetails)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StorageQuotaDetails>> StorageQuotasGetSystemStorageQuotasAsyncWithHttpInfo (string dataViewName, string systemName)
        {
            // verify the required parameter 'dataViewName' is set
            if (dataViewName == null)
                throw new ApiException(400, "Missing required parameter 'dataViewName' when calling StorageQuotasApi->StorageQuotasGetSystemStorageQuotas");
            // verify the required parameter 'systemName' is set
            if (systemName == null)
                throw new ApiException(400, "Missing required parameter 'systemName' when calling StorageQuotasApi->StorageQuotasGetSystemStorageQuotas");

            var localVarPath = "./{dataViewName}/StorageQuotas/{systemName}";
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
            if (systemName != null) localVarPathParams.Add("systemName", this.Configuration.ApiClient.ParameterToString(systemName)); // path parameter
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
                Exception exception = ExceptionFactory("StorageQuotasGetSystemStorageQuotas", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<StorageQuotaDetails>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (StorageQuotaDetails) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(StorageQuotaDetails)));
        }

        /// <summary>
        /// Updates system storage quotas from the given details 
        /// </summary>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="systemName">The name of the FastStats system to act on</param>
        /// <param name="body">The details of the storage quotas to update (optional)</param>
        /// <returns>List&lt;ModifyStorageQuotaResults&gt;</returns>
        public List<ModifyStorageQuotaResults> StorageQuotasModifySystemStorageQuotas (string dataViewName, string systemName, ModifyItemsModifyStorageQuota body = null)
        {
             ApiResponse<List<ModifyStorageQuotaResults>> localVarResponse = StorageQuotasModifySystemStorageQuotasWithHttpInfo(dataViewName, systemName, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Updates system storage quotas from the given details 
        /// </summary>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="systemName">The name of the FastStats system to act on</param>
        /// <param name="body">The details of the storage quotas to update (optional)</param>
        /// <returns>ApiResponse of List&lt;ModifyStorageQuotaResults&gt;</returns>
        public ApiResponse< List<ModifyStorageQuotaResults> > StorageQuotasModifySystemStorageQuotasWithHttpInfo (string dataViewName, string systemName, ModifyItemsModifyStorageQuota body = null)
        {
            // verify the required parameter 'dataViewName' is set
            if (dataViewName == null)
                throw new ApiException(400, "Missing required parameter 'dataViewName' when calling StorageQuotasApi->StorageQuotasModifySystemStorageQuotas");
            // verify the required parameter 'systemName' is set
            if (systemName == null)
                throw new ApiException(400, "Missing required parameter 'systemName' when calling StorageQuotasApi->StorageQuotasModifySystemStorageQuotas");

            var localVarPath = "./{dataViewName}/StorageQuotas/{systemName}";
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
            if (systemName != null) localVarPathParams.Add("systemName", this.Configuration.ApiClient.ParameterToString(systemName)); // path parameter
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
                Exception exception = ExceptionFactory("StorageQuotasModifySystemStorageQuotas", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<ModifyStorageQuotaResults>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (List<ModifyStorageQuotaResults>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ModifyStorageQuotaResults>)));
        }

        /// <summary>
        /// Updates system storage quotas from the given details 
        /// </summary>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="systemName">The name of the FastStats system to act on</param>
        /// <param name="body">The details of the storage quotas to update (optional)</param>
        /// <returns>Task of List&lt;ModifyStorageQuotaResults&gt;</returns>
        public async System.Threading.Tasks.Task<List<ModifyStorageQuotaResults>> StorageQuotasModifySystemStorageQuotasAsync (string dataViewName, string systemName, ModifyItemsModifyStorageQuota body = null)
        {
             ApiResponse<List<ModifyStorageQuotaResults>> localVarResponse = await StorageQuotasModifySystemStorageQuotasAsyncWithHttpInfo(dataViewName, systemName, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Updates system storage quotas from the given details 
        /// </summary>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="systemName">The name of the FastStats system to act on</param>
        /// <param name="body">The details of the storage quotas to update (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;ModifyStorageQuotaResults&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<ModifyStorageQuotaResults>>> StorageQuotasModifySystemStorageQuotasAsyncWithHttpInfo (string dataViewName, string systemName, ModifyItemsModifyStorageQuota body = null)
        {
            // verify the required parameter 'dataViewName' is set
            if (dataViewName == null)
                throw new ApiException(400, "Missing required parameter 'dataViewName' when calling StorageQuotasApi->StorageQuotasModifySystemStorageQuotas");
            // verify the required parameter 'systemName' is set
            if (systemName == null)
                throw new ApiException(400, "Missing required parameter 'systemName' when calling StorageQuotasApi->StorageQuotasModifySystemStorageQuotas");

            var localVarPath = "./{dataViewName}/StorageQuotas/{systemName}";
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
            if (systemName != null) localVarPathParams.Add("systemName", this.Configuration.ApiClient.ParameterToString(systemName)); // path parameter
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
                Exception exception = ExceptionFactory("StorageQuotasModifySystemStorageQuotas", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<ModifyStorageQuotaResults>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (List<ModifyStorageQuotaResults>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<ModifyStorageQuotaResults>)));
        }

    }
}
