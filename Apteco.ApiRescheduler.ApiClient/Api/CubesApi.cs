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
        public interface ICubesApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Calculates a cube using the given definition and returns the results.  The data to build the cube from is defined by the base query provided.
        /// </summary>
        /// <remarks>
        /// Requires licence flags [Cube]
        /// </remarks>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="systemName">The name of the FastStats system to act on</param>
        /// <param name="body">The cube definition to use (optional)</param>
        /// <param name="timeoutInSeconds">The number of seconds before the request will time out.  Leave unspecified to use the default value given in the analysis service&#x27;s configuration (optional)</param>
        /// <param name="returnDefinition">Whether to include the cube&#x27;s definition in the results.  Default is false. (optional)</param>
        /// <returns>CubeResult</returns>
        CubeResult CubesCalculateCubeSynchronously (string dataViewName, string systemName, Cube body = null, int? timeoutInSeconds = null, bool? returnDefinition = null);

        /// <summary>
        /// Calculates a cube using the given definition and returns the results.  The data to build the cube from is defined by the base query provided.
        /// </summary>
        /// <remarks>
        /// Requires licence flags [Cube]
        /// </remarks>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="systemName">The name of the FastStats system to act on</param>
        /// <param name="body">The cube definition to use (optional)</param>
        /// <param name="timeoutInSeconds">The number of seconds before the request will time out.  Leave unspecified to use the default value given in the analysis service&#x27;s configuration (optional)</param>
        /// <param name="returnDefinition">Whether to include the cube&#x27;s definition in the results.  Default is false. (optional)</param>
        /// <returns>ApiResponse of CubeResult</returns>
        ApiResponse<CubeResult> CubesCalculateCubeSynchronouslyWithHttpInfo (string dataViewName, string systemName, Cube body = null, int? timeoutInSeconds = null, bool? returnDefinition = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Calculates a cube using the given definition and returns the results.  The data to build the cube from is defined by the base query provided.
        /// </summary>
        /// <remarks>
        /// Requires licence flags [Cube]
        /// </remarks>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="systemName">The name of the FastStats system to act on</param>
        /// <param name="body">The cube definition to use (optional)</param>
        /// <param name="timeoutInSeconds">The number of seconds before the request will time out.  Leave unspecified to use the default value given in the analysis service&#x27;s configuration (optional)</param>
        /// <param name="returnDefinition">Whether to include the cube&#x27;s definition in the results.  Default is false. (optional)</param>
        /// <returns>Task of CubeResult</returns>
        System.Threading.Tasks.Task<CubeResult> CubesCalculateCubeSynchronouslyAsync (string dataViewName, string systemName, Cube body = null, int? timeoutInSeconds = null, bool? returnDefinition = null);

        /// <summary>
        /// Calculates a cube using the given definition and returns the results.  The data to build the cube from is defined by the base query provided.
        /// </summary>
        /// <remarks>
        /// Requires licence flags [Cube]
        /// </remarks>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="systemName">The name of the FastStats system to act on</param>
        /// <param name="body">The cube definition to use (optional)</param>
        /// <param name="timeoutInSeconds">The number of seconds before the request will time out.  Leave unspecified to use the default value given in the analysis service&#x27;s configuration (optional)</param>
        /// <param name="returnDefinition">Whether to include the cube&#x27;s definition in the results.  Default is false. (optional)</param>
        /// <returns>Task of ApiResponse (CubeResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<CubeResult>> CubesCalculateCubeSynchronouslyAsyncWithHttpInfo (string dataViewName, string systemName, Cube body = null, int? timeoutInSeconds = null, bool? returnDefinition = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class CubesApi : ICubesApi
    {
        private Apteco.ApiRescheduler.ApiClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CubesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CubesApi(String basePath)
        {
            this.Configuration = new Apteco.ApiRescheduler.ApiClient.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Apteco.ApiRescheduler.ApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CubesApi"/> class
        /// </summary>
        /// <returns></returns>
        public CubesApi()
        {
            this.Configuration = Apteco.ApiRescheduler.ApiClient.Client.Configuration.Default;

            ExceptionFactory = Apteco.ApiRescheduler.ApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CubesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CubesApi(Apteco.ApiRescheduler.ApiClient.Client.Configuration configuration = null)
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
        /// Calculates a cube using the given definition and returns the results.  The data to build the cube from is defined by the base query provided. Requires licence flags [Cube]
        /// </summary>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="systemName">The name of the FastStats system to act on</param>
        /// <param name="body">The cube definition to use (optional)</param>
        /// <param name="timeoutInSeconds">The number of seconds before the request will time out.  Leave unspecified to use the default value given in the analysis service&#x27;s configuration (optional)</param>
        /// <param name="returnDefinition">Whether to include the cube&#x27;s definition in the results.  Default is false. (optional)</param>
        /// <returns>CubeResult</returns>
        public CubeResult CubesCalculateCubeSynchronously (string dataViewName, string systemName, Cube body = null, int? timeoutInSeconds = null, bool? returnDefinition = null)
        {
             ApiResponse<CubeResult> localVarResponse = CubesCalculateCubeSynchronouslyWithHttpInfo(dataViewName, systemName, body, timeoutInSeconds, returnDefinition);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Calculates a cube using the given definition and returns the results.  The data to build the cube from is defined by the base query provided. Requires licence flags [Cube]
        /// </summary>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="systemName">The name of the FastStats system to act on</param>
        /// <param name="body">The cube definition to use (optional)</param>
        /// <param name="timeoutInSeconds">The number of seconds before the request will time out.  Leave unspecified to use the default value given in the analysis service&#x27;s configuration (optional)</param>
        /// <param name="returnDefinition">Whether to include the cube&#x27;s definition in the results.  Default is false. (optional)</param>
        /// <returns>ApiResponse of CubeResult</returns>
        public ApiResponse< CubeResult > CubesCalculateCubeSynchronouslyWithHttpInfo (string dataViewName, string systemName, Cube body = null, int? timeoutInSeconds = null, bool? returnDefinition = null)
        {
            // verify the required parameter 'dataViewName' is set
            if (dataViewName == null)
                throw new ApiException(400, "Missing required parameter 'dataViewName' when calling CubesApi->CubesCalculateCubeSynchronously");
            // verify the required parameter 'systemName' is set
            if (systemName == null)
                throw new ApiException(400, "Missing required parameter 'systemName' when calling CubesApi->CubesCalculateCubeSynchronously");

            var localVarPath = "./{dataViewName}/Cubes/{systemName}/CalculateSync";
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
            if (timeoutInSeconds != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "timeoutInSeconds", timeoutInSeconds)); // query parameter
            if (returnDefinition != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "returnDefinition", returnDefinition)); // query parameter
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
                Exception exception = ExceptionFactory("CubesCalculateCubeSynchronously", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CubeResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (CubeResult) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CubeResult)));
        }

        /// <summary>
        /// Calculates a cube using the given definition and returns the results.  The data to build the cube from is defined by the base query provided. Requires licence flags [Cube]
        /// </summary>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="systemName">The name of the FastStats system to act on</param>
        /// <param name="body">The cube definition to use (optional)</param>
        /// <param name="timeoutInSeconds">The number of seconds before the request will time out.  Leave unspecified to use the default value given in the analysis service&#x27;s configuration (optional)</param>
        /// <param name="returnDefinition">Whether to include the cube&#x27;s definition in the results.  Default is false. (optional)</param>
        /// <returns>Task of CubeResult</returns>
        public async System.Threading.Tasks.Task<CubeResult> CubesCalculateCubeSynchronouslyAsync (string dataViewName, string systemName, Cube body = null, int? timeoutInSeconds = null, bool? returnDefinition = null)
        {
             ApiResponse<CubeResult> localVarResponse = await CubesCalculateCubeSynchronouslyAsyncWithHttpInfo(dataViewName, systemName, body, timeoutInSeconds, returnDefinition);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Calculates a cube using the given definition and returns the results.  The data to build the cube from is defined by the base query provided. Requires licence flags [Cube]
        /// </summary>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="systemName">The name of the FastStats system to act on</param>
        /// <param name="body">The cube definition to use (optional)</param>
        /// <param name="timeoutInSeconds">The number of seconds before the request will time out.  Leave unspecified to use the default value given in the analysis service&#x27;s configuration (optional)</param>
        /// <param name="returnDefinition">Whether to include the cube&#x27;s definition in the results.  Default is false. (optional)</param>
        /// <returns>Task of ApiResponse (CubeResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CubeResult>> CubesCalculateCubeSynchronouslyAsyncWithHttpInfo (string dataViewName, string systemName, Cube body = null, int? timeoutInSeconds = null, bool? returnDefinition = null)
        {
            // verify the required parameter 'dataViewName' is set
            if (dataViewName == null)
                throw new ApiException(400, "Missing required parameter 'dataViewName' when calling CubesApi->CubesCalculateCubeSynchronously");
            // verify the required parameter 'systemName' is set
            if (systemName == null)
                throw new ApiException(400, "Missing required parameter 'systemName' when calling CubesApi->CubesCalculateCubeSynchronously");

            var localVarPath = "./{dataViewName}/Cubes/{systemName}/CalculateSync";
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
            if (timeoutInSeconds != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "timeoutInSeconds", timeoutInSeconds)); // query parameter
            if (returnDefinition != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "returnDefinition", returnDefinition)); // query parameter
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
                Exception exception = ExceptionFactory("CubesCalculateCubeSynchronously", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CubeResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (CubeResult) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CubeResult)));
        }

    }
}
