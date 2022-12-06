using Apteco.ApiRescheduler.ApiClient.Api;
using Apteco.ApiRescheduler.ApiClient.Model;

namespace Apteco.ApiRescheduler.Core.Services
{
  public interface IApiConnectorFactory
  {
    #region public methods
    ISessionsApi CreateSessionsApi(SessionDetails sessionDetails);
    IPeopleStageApi CreatePeopleStageApi(SessionDetails sessionDetails);
    #endregion
  }
}
