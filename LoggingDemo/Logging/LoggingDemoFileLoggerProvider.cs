using Microsoft.Extensions.Options;

namespace LoggingDemo.Logging
{
    [ProviderAlias("LoggingDemoCodeFile")]
    public class LoggingDemoFileLoggerProvider:ILoggerProvider
    {
        public readonly LoggingDemoFileLoggingOptions Options;
        public LoggingDemoFileLoggerProvider(IOptions<LoggingDemoFileLoggingOptions> _options)
        {
            Options = _options.Value;
            if(!Directory.Exists(Options.FolderPath))
            {
                Directory.CreateDirectory(Options.FolderPath);
            }
        }

        public ILogger CreateLogger(string categoryName)
        {
            return new LoggingDemoFileLogger(this);
        }

        public void Dispose()
        {
            
        }
    }
}
