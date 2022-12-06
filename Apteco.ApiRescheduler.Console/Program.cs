using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Apteco.ApiRescheduler.ApiClient.Model;
using Apteco.ApiRescheduler.Core;
using Apteco.ApiRescheduler.Core.Services;
using Microsoft.Extensions.Logging;

namespace Apteco.ApiRescheduler.Console
{
  class Program
  {
    private static int Main(string[] args)
    {
      if (args == null || args.Length < 1)
      {
        return OutputUsage();
      }

      Task<int> task = Task.Run(() => PerformAction(args));
      task.Wait();
      return task.Result;
    }

    private static async Task<int> PerformAction(string[] args)
    {
      if (args.Length < 6)
        return OutputUsage();

      string baseUrl = args[0];
      string dataViewName = args[1];
      string username = args[2];
      string password = args[3];
      string systemName = args[4];
      string campaignName = args[5];
      if (args[3] == "-i")
      {
        System.Console.WriteLine("Enter password:");
        password = ReadConsoleKeys();
      }

      return await RescheduleCampaign(baseUrl, dataViewName, username, password, systemName, campaignName);
    }

    private static int OutputUsage()
    {
      string usageString =
        "Usage: " + Environment.NewLine +
        "  ApiRescheduler-Console.exe <Orbit API base URL> <DataView name> <username> <password> <system name> <campaign name>" + Environment.NewLine +
        Environment.NewLine +
        "Use -i for password to allow interactive and hidden entry" + Environment.NewLine +
        Environment.NewLine +
        Environment.NewLine +
        "This will trigger a named single-step campaign to run now." + Environment.NewLine;

      System.Console.WriteLine(usageString);
      return 0;
    }

    private static string ReadConsoleKeys()
    {
      string str = "";
      ConsoleKey key;
      do
      {
        var keyInfo = System.Console.ReadKey(intercept: true);
        key = keyInfo.Key;

        if (key == ConsoleKey.Backspace && str.Length > 0)
        {
          System.Console.Write("\b \b");
          str = str[0..^1];
        }
        else if (!char.IsControl(keyInfo.KeyChar))
        {
          System.Console.Write("*");
          str += keyInfo.KeyChar;
        }
      } while (key != ConsoleKey.Enter);
      System.Console.WriteLine();
      return str;
    }

    private static async Task<int> RescheduleCampaign(string baseUrl, string dataViewName, string username, string password, string systemName, string campaignName)
    {
      using (LoggingHandler loggingHandler = new LoggingHandler())
      {
        ILogger<Program> logger = loggingHandler.CreateLogger<Program>();

        ApiConnectorFactory connectorFactory = new ApiConnectorFactory(baseUrl);
        LoginService loginService = new LoginService(connectorFactory, dataViewName);

        SessionDetails sessionDetails = await loginService.Login(username, password);
        if (sessionDetails == null)
        {
          logger.LogError($"Couldn't log in to data view {dataViewName} as user {username}");
          return -1;
        }

        try
        {
          CampaignManager campaignManager = new CampaignManager(connectorFactory, dataViewName, systemName,
            loggingHandler.CreateLogger<CampaignManager>());

          List<string> campaignIds = await campaignManager.GetIdsForName(sessionDetails, campaignName);
          if (campaignIds.Count == 0)
          {
            logger.LogError($"Couldn't find any campaigns with name {campaignName}");
            return -1;
          }
          if (campaignIds.Count > 1)
          {
            logger.LogError($"Found too many campaigns with name {campaignName} (found {campaignIds.Count})");
            return -1;
          }

          bool success = await campaignManager.RescheduleCampaignToRunNow(sessionDetails, campaignIds[0]);
          return success ? 0 : -1;
        }
        finally
        {
          await loginService.Logout(sessionDetails);
        }
      }
    }
  }
}
