using System.Collections.Generic;
using Apteco.ApiRescheduler.ApiClient.Api;
using Apteco.ApiRescheduler.ApiClient.Client;
using Apteco.ApiRescheduler.ApiClient.Model;

namespace Apteco.ApiRescheduler.Core.Services
{
  public class ApiConnectorFactory : IApiConnectorFactory
  {
    #region private fields
    private string baseUrl;
    #endregion

    #region public constructor
    public ApiConnectorFactory(string baseUrl)
    {
      this.baseUrl = baseUrl;
    }
    #endregion

    #region public methods
    public ISessionsApi CreateSessionsApi(SessionDetails sessionDetails)
    {
      return new SessionsApi(CreateConfiguration(sessionDetails));
    }

    public IPeopleStageApi CreatePeopleStageApi(SessionDetails sessionDetails)
    {
      return new PeopleStageApi(CreateConfiguration(sessionDetails));
    }
    #endregion

    #region private methods
    private Configuration CreateConfiguration(SessionDetails sessionDetails)
    {
      Dictionary<string, string> defaultHeaders = new Dictionary<string, string>();
      if (sessionDetails != null)
      {
        defaultHeaders.Add("Authorization", "Bearer " + sessionDetails.AccessToken);
      }

      return new Configuration()
      {
        DefaultHeader = defaultHeaders,
        BasePath = baseUrl
      };
    }
    #endregion
  }
}
