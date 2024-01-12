using LoggerLibrary.LoggerLibrary;
using LoggerLibrary.Sinks;

namespace ExampleApp
{
    class Program
    {
        static void Main()
        {
            // Setup logger configuration
            var loggerConfig = new LoggerConfiguration();
            loggerConfig.AddSink(new ConsoleSink(LogLevel.ERROR, LogLevel.WARN, LogLevel.INFO));

            // Create logger instance with the configured sinks
            var logger = new Logger(loggerConfig.Sinks.ToArray());

            // Send messages using the logger
            logger.LogMessage("This is an error message", LogLevel.ERROR, "NamespaceA");
            logger.LogMessage("This is a warning message", LogLevel.WARN, "NamespaceB");
            logger.LogMessage("This is an info message", LogLevel.INFO, "NamespaceC");
            logger.LogMessage("This is a debug message", LogLevel.DEBUG, "NamespaceD"); // Will not be logged in the console sink
        }
    }
}
