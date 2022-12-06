using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Apteco.ApiRescheduler.ApiClient.Api;
using Apteco.ApiRescheduler.ApiClient.Model;

namespace Apteco.ApiRescheduler.Core.Services
{
  public class PeopleStageService
  {
    #region private fields
    private IApiConnectorFactory connectorFactory;
    private string dataViewName;
    private string systemName;
    #endregion

    #region public constructor
    public PeopleStageService(IApiConnectorFactory connectorFactory, string dataViewName, string systemName)
    {
      this.connectorFactory = connectorFactory;
      this.dataViewName = dataViewName;
      this.systemName = systemName;
    }
    #endregion

    #region public methods
    public async Task<List<ElementSummary>> GetCapaignIdsForName(SessionDetails sessionDetails, string campaignName)
    {
      IPeopleStageApi peopleStageApi = connectorFactory.CreatePeopleStageApi(sessionDetails);
      var results = await peopleStageApi.PeopleStageGetPeopleStageElementsAsync(dataViewName, systemName,
        $"Type='Campaign' and Description='{campaignName.Replace("'", "\'")}'");

      return results._List;
    }

    public async Task<int> CreateModifyScheduleToRunNowJob(SessionDetails sessionDetails, string campaignId)
    {
      IPeopleStageApi peopleStageApi = connectorFactory.CreatePeopleStageApi(sessionDetails);

      Schedule schedule = new Schedule();
      schedule.ScheduleInSingleInstance = new ScheduleInSingleInstance(
        new DateTimeAndZone(DateTime.Now, TimeZoneInfo.Local.Id));

      var results = await peopleStageApi.PeopleStageCreateModifyCampaignScheduleJobAsync(dataViewName,
        systemName, campaignId, schedule);

      if (!results.Id.HasValue)
        throw new Exception("Didn't get a job id back from creating a modify campaign schedule job");
      return results.Id.Value;
    }

    public async Task<bool> IsModifyScheduleJobComplete(SessionDetails sessionDetails, string campaignId, int jobId)
    {
      IPeopleStageApi peopleStageApi = connectorFactory.CreatePeopleStageApi(sessionDetails);

      var results = await peopleStageApi.PeopleStageModifyCampaignScheduleJobAsync(dataViewName,
        systemName, campaignId, jobId);

      return results.IsComplete.HasValue && results.IsComplete.Value;
    }

    public async Task<int> CreatePublishCampaignJob(SessionDetails sessionDetails, string campaignId)
    {
      IPeopleStageApi peopleStageApi = connectorFactory.CreatePeopleStageApi(sessionDetails);

      var results = await peopleStageApi.PeopleStageCreateElementPublishJobAsync(dataViewName, systemName,
        campaignId);

      if (!results.Id.HasValue)
        throw new Exception("Didn't get a job id back from creating a publish campaign job");
      return results.Id.Value;
    }

    public async Task<bool> IsPublishJobComplete(SessionDetails sessionDetails, string campaignId, int jobId)
    {
      IPeopleStageApi peopleStageApi = connectorFactory.CreatePeopleStageApi(sessionDetails);

      var results = await peopleStageApi.PeopleStageElementPublishJobAsync(dataViewName, systemName,
        campaignId, jobId);

      return results.IsComplete.HasValue && results.IsComplete.Value;
    }
    #endregion
  }
}