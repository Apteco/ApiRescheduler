using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Apteco.ApiRescheduler.ApiClient.Model;
using Apteco.ApiRescheduler.Core.Services;
using Microsoft.Extensions.Logging;

namespace Apteco.ApiRescheduler.Core
{
  public class CampaignManager
  {
    #region private fields
    private IApiConnectorFactory connectorFactory;
    private string dataViewName;
    private string systemName;
    private ILogger<CampaignManager> logger;
    #endregion

    #region public constructor
    public CampaignManager(IApiConnectorFactory connectorFactory, string dataViewName, string systemName, ILogger<CampaignManager> logger)
    {
      this.dataViewName = dataViewName;
      this.systemName = systemName;
      this.connectorFactory = connectorFactory;
      this.logger = logger;
    }
    #endregion

    #region public methods
    public async Task<List<string>> GetIdsForName(SessionDetails sessionDetails, string campaignName)
    {
      PeopleStageService peopleStageService = new PeopleStageService(connectorFactory, dataViewName, systemName);
      List<ElementSummary> campaigns = await peopleStageService.GetCapaignIdsForName(sessionDetails, campaignName);
      return campaigns.Select(c => c.Id).ToList();
    }

    public async Task<bool> RescheduleCampaignToRunNow(SessionDetails sessionDetails, string campaignId)
    {
      PeopleStageService peopleStageService = new PeopleStageService(connectorFactory, dataViewName, systemName);

      logger.LogInformation($"About to update schedule for campaign id {campaignId} to run now");
      int modifyScheduleJobId = await peopleStageService.CreateModifyScheduleToRunNowJob(sessionDetails, campaignId);
      while (!await peopleStageService.IsModifyScheduleJobComplete(sessionDetails, campaignId, modifyScheduleJobId))
      {
        Thread.Sleep(1000);
        logger.LogInformation($"Updating...");
      }
      logger.LogInformation($"Updated schedule");

      logger.LogInformation($"About to republish campaign id {campaignId} to apply changes");
      int publishJobId = await peopleStageService.CreatePublishCampaignJob(sessionDetails, campaignId);
      while (!await peopleStageService.IsPublishJobComplete(sessionDetails, campaignId, publishJobId))
      {
        Thread.Sleep(1000);
        logger.LogInformation($"Republishing...");
      }
      logger.LogInformation($"Republished campaign");

      return true;
    }
    #endregion
  }
}
