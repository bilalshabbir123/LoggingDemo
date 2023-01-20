namespace LoggingDemo.Logging
{
    public static class LoggingDemoFileLoggerExtension
    {
        public static ILoggingBuilder LoggingDemoFileLogger(this ILoggingBuilder builder,Action<LoggingDemoFileLoggingOptions> configure)
        {
            builder.Services.AddSingleton<ILoggerProvider,LoggingDemoFileLoggerProvider>();
            builder.Services.Configure(configure);
            return builder;
        }
    }
}
