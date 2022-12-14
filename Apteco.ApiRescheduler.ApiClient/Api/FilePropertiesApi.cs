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
        public interface IFilePropertiesApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Returns the properties for a file
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="systemName">The name of the FastStats system to act on</param>
        /// <param name="filePath">The path of the file to return the properties for</param>
        /// <param name="timeoutInSeconds">The number of seconds before the request will time out.  Leave unspecified to use the default value given in the file service&#x27;s configuration (optional)</param>
        /// <returns>FilePropertiesDetails</returns>
        FilePropertiesDetails FilePropertiesGetFileProperties (string dataViewName, string systemName, string filePath, int? timeoutInSeconds = null);

        /// <summary>
        /// Returns the properties for a file
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="systemName">The name of the FastStats system to act on</param>
        /// <param name="filePath">The path of the file to return the properties for</param>
        /// <param name="timeoutInSeconds">The number of seconds before the request will time out.  Leave unspecified to use the default value given in the file service&#x27;s configuration (optional)</param>
        /// <returns>ApiResponse of FilePropertiesDetails</returns>
        ApiResponse<FilePropertiesDetails> FilePropertiesGetFilePropertiesWithHttpInfo (string dataViewName, string systemName, string filePath, int? timeoutInSeconds = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Returns the properties for a file
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="systemName">The name of the FastStats system to act on</param>
        /// <param name="filePath">The path of the file to return the properties for</param>
        /// <param name="timeoutInSeconds">The number of seconds before the request will time out.  Leave unspecified to use the default value given in the file service&#x27;s configuration (optional)</param>
        /// <returns>Task of FilePropertiesDetails</returns>
        System.Threading.Tasks.Task<FilePropertiesDetails> FilePropertiesGetFilePropertiesAsync (string dataViewName, string systemName, string filePath, int? timeoutInSeconds = null);

        /// <summary>
        /// Returns the properties for a file
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="systemName">The name of the FastStats system to act on</param>
        /// <param name="filePath">The path of the file to return the properties for</param>
        /// <param name="timeoutInSeconds">The number of seconds before the request will time out.  Leave unspecified to use the default value given in the file service&#x27;s configuration (optional)</param>
        /// <returns>Task of ApiResponse (FilePropertiesDetails)</returns>
        System.Threading.Tasks.Task<ApiResponse<FilePropertiesDetails>> FilePropertiesGetFilePropertiesAsyncWithHttpInfo (string dataViewName, string systemName, string filePath, int? timeoutInSeconds = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class FilePropertiesApi : IFilePropertiesApi
    {
        private Apteco.ApiRescheduler.ApiClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="FilePropertiesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public FilePropertiesApi(String basePath)
        {
            this.Configuration = new Apteco.ApiRescheduler.ApiClient.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Apteco.ApiRescheduler.ApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilePropertiesApi"/> class
        /// </summary>
        /// <returns></returns>
        public FilePropertiesApi()
        {
            this.Configuration = Apteco.ApiRescheduler.ApiClient.Client.Configuration.Default;

            ExceptionFactory = Apteco.ApiRescheduler.ApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilePropertiesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public FilePropertiesApi(Apteco.ApiRescheduler.ApiClient.Client.Configuration configuration = null)
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
        /// Returns the properties for a file 
        /// </summary>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="systemName">The name of the FastStats system to act on</param>
        /// <param name="filePath">The path of the file to return the properties for</param>
        /// <param name="timeoutInSeconds">The number of seconds before the request will time out.  Leave unspecified to use the default value given in the file service&#x27;s configuration (optional)</param>
        /// <returns>FilePropertiesDetails</returns>
        public FilePropertiesDetails FilePropertiesGetFileProperties (string dataViewName, string systemName, string filePath, int? timeoutInSeconds = null)
        {
             ApiResponse<FilePropertiesDetails> localVarResponse = FilePropertiesGetFilePropertiesWithHttpInfo(dataViewName, systemName, filePath, timeoutInSeconds);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Returns the properties for a file 
        /// </summary>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="systemName">The name of the FastStats system to act on</param>
        /// <param name="filePath">The path of the file to return the properties for</param>
        /// <param name="timeoutInSeconds">The number of seconds before the request will time out.  Leave unspecified to use the default value given in the file service&#x27;s configuration (optional)</param>
        /// <returns>ApiResponse of FilePropertiesDetails</returns>
        public ApiResponse< FilePropertiesDetails > FilePropertiesGetFilePropertiesWithHttpInfo (string dataViewName, string systemName, string filePath, int? timeoutInSeconds = null)
        {
            // verify the required parameter 'dataViewName' is set
            if (dataViewName == null)
                throw new ApiException(400, "Missing required parameter 'dataViewName' when calling FilePropertiesApi->FilePropertiesGetFileProperties");
            // verify the required parameter 'systemName' is set
            if (systemName == null)
                throw new ApiException(400, "Missing required parameter 'systemName' when calling FilePropertiesApi->FilePropertiesGetFileProperties");
            // verify the required parameter 'filePath' is set
            if (filePath == null)
                throw new ApiException(400, "Missing required parameter 'filePath' when calling FilePropertiesApi->FilePropertiesGetFileProperties");

            var localVarPath = "./{dataViewName}/FileProperties/{systemName}/{filePath}";
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
            if (filePath != null) localVarPathParams.Add("filePath", this.Configuration.ApiClient.ParameterToString(filePath)); // path parameter
            if (timeoutInSeconds != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "timeoutInSeconds", timeoutInSeconds)); // query parameter
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
                Exception exception = ExceptionFactory("FilePropertiesGetFileProperties", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<FilePropertiesDetails>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (FilePropertiesDetails) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(FilePropertiesDetails)));
        }

        /// <summary>
        /// Returns the properties for a file 
        /// </summary>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="systemName">The name of the FastStats system to act on</param>
        /// <param name="filePath">The path of the file to return the properties for</param>
        /// <param name="timeoutInSeconds">The number of seconds before the request will time out.  Leave unspecified to use the default value given in the file service&#x27;s configuration (optional)</param>
        /// <returns>Task of FilePropertiesDetails</returns>
        public async System.Threading.Tasks.Task<FilePropertiesDetails> FilePropertiesGetFilePropertiesAsync (string dataViewName, string systemName, string filePath, int? timeoutInSeconds = null)
        {
             ApiResponse<FilePropertiesDetails> localVarResponse = await FilePropertiesGetFilePropertiesAsyncWithHttpInfo(dataViewName, systemName, filePath, timeoutInSeconds);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Returns the properties for a file 
        /// </summary>
        /// <exception cref="Apteco.ApiRescheduler.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataViewName">The name of the DataView to act on</param>
        /// <param name="systemName">The name of the FastStats system to act on</param>
        /// <param name="filePath">The path of the file to return the properties for</param>
        /// <param name="timeoutInSeconds">The number of seconds before the request will time out.  Leave unspecified to use the default value given in the file service&#x27;s configuration (optional)</param>
        /// <returns>Task of ApiResponse (FilePropertiesDetails)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FilePropertiesDetails>> FilePropertiesGetFilePropertiesAsyncWithHttpInfo (string dataViewName, string systemName, string filePath, int? timeoutInSeconds = null)
        {
            // verify the required parameter 'dataViewName' is set
            if (dataViewName == null)
                throw new ApiException(400, "Missing required parameter 'dataViewName' when calling FilePropertiesApi->FilePropertiesGetFileProperties");
            // verify the required parameter 'systemName' is set
            if (systemName == null)
                throw new ApiException(400, "Missing required parameter 'systemName' when calling FilePropertiesApi->FilePropertiesGetFileProperties");
            // verify the required parameter 'filePath' is set
            if (filePath == null)
                throw new ApiException(400, "Missing required parameter 'filePath' when calling FilePropertiesApi->FilePropertiesGetFileProperties");

            var localVarPath = "./{dataViewName}/FileProperties/{systemName}/{filePath}";
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
            if (filePath != null) localVarPathParams.Add("filePath", this.Configuration.ApiClient.ParameterToString(filePath)); // path parameter
            if (timeoutInSeconds != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "timeoutInSeconds", timeoutInSeconds)); // query parameter
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
                Exception exception = ExceptionFactory("FilePropertiesGetFileProperties", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<FilePropertiesDetails>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (FilePropertiesDetails) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(FilePropertiesDetails)));
        }

    }
}
