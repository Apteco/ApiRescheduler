using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using Microsoft.Extensions.Options;

namespace Apteco.ApiRescheduler.Console
{
  public class LoggingHandler : IDisposable
  {
    #region private fields
    private ConsoleLoggerProvider consoleLoggerProvider;
    #endregion

    #region public properties
    public LoggerFactory LoggerFactory { get; private set; }
    #endregion

    #region public constructor
    public LoggingHandler()
    {
      var configureNamedOptions = new ConfigureNamedOptions<ConsoleLoggerOptions>("", null);
      var optionsFactory = new OptionsFactory<ConsoleLoggerOptions>(new[] { configureNamedOptions }, Enumerable.Empty<IPostConfigureOptions<ConsoleLoggerOptions>>());
      var optionsMonitor = new OptionsMonitor<ConsoleLoggerOptions>(optionsFactory, Enumerable.Empty<IOptionsChangeTokenSource<ConsoleLoggerOptions>>(), new OptionsCache<ConsoleLoggerOptions>());

      consoleLoggerProvider = new ConsoleLoggerProvider(optionsMonitor);
      LoggerFactory = new LoggerFactory(new[] { consoleLoggerProvider }, new LoggerFilterOptions { MinLevel = LogLevel.Information });
    }
    #endregion

    #region public methods
    public ILogger<T> CreateLogger<T>()
    {
      return LoggerFactory.CreateLogger<T>();
    }

    public void Dispose()
    {
      LoggerFactory.Dispose();
      consoleLoggerProvider.Dispose();
    }
    #endregion

  }
}
