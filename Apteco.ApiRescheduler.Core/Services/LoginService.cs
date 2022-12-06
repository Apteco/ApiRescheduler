using System;
using System.Threading.Tasks;
using Apteco.ApiRescheduler.ApiClient.Api;
using Apteco.ApiRescheduler.ApiClient.Model;

namespace Apteco.ApiRescheduler.Core.Services
{
  public class LoginService
  {
    #region private fields
    private IApiConnectorFactory connectorFactory;
    private string dataViewName;
    #endregion

    #region public constructor
    public LoginService(IApiConnectorFactory connectorFactory, string dataViewName)
    {
      this.connectorFactory = connectorFactory;
      this.dataViewName = dataViewName;
    }
    #endregion

    #region public methods
    public async Task<SessionDetails> Login(string username, string password)
    {
      ISessionsApi sessionsApi = connectorFactory.CreateSessionsApi(null);
      SessionDetails details = await sessionsApi.SessionsCreateSessionSimpleAsync(username, password, "Orbit", dataViewName);
      if (details?.AccessToken == null)
        return null;

      return details;
    }

    public async Task Logout(SessionDetails sessionDetails)
    {
      if (sessionDetails == null)
        throw new Exception("No session has been created - please log in");

      ISessionsApi sessionsApi = connectorFactory.CreateSessionsApi(sessionDetails);
      await sessionsApi.SessionsLogoutSessionAsync(dataViewName, sessionDetails.SessionId);
    }
    #endregion
  }
}
