using System;
using Microsoft.Extensions.Logging;

namespace store_scrapper_2.DAL.Db
{
  internal class DataContextLoggerProvider : ILoggerProvider
  {
    private static readonly log4net.ILog Logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

    public static ILoggerFactory CreateFactory()
    {
      var loggerFactory = new LoggerFactory();
      loggerFactory.AddProvider(new DataContextLoggerProvider());
      return loggerFactory;
    }
    
    public void Dispose() { }

    public ILogger CreateLogger(string categoryName) => new DataContextLogger();

    private class DataContextLogger : ILogger
    {
      public void Log<TState>(
        LogLevel logLevel,
        EventId eventId, 
        TState state, 
        Exception exception,
        Func<TState, Exception, string> formatter)
      { 
        switch (logLevel)
        {
            case LogLevel.Critical:
              Logger.Fatal(formatter(state, exception));
              break;
            case LogLevel.Error:
              Logger.Error(formatter(state, exception));
              break;
            case LogLevel.Trace:
            case LogLevel.Debug:
              Logger.Debug(formatter(state, exception));
              break;
            case LogLevel.Information:
              Logger.Info(formatter(state, exception));
              break;
            case LogLevel.Warning:
              Logger.Warn(formatter(state, exception));
              break;
        }
      }

      public bool IsEnabled(LogLevel logLevel) => true;

      public IDisposable BeginScope<TState>(TState state) => null;
    }
  }
}