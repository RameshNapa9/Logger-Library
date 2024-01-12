using LoggerLibrary.Sinks;
using System.Collections.Generic;

namespace LoggerLibrary.LoggerLibrary
{
    // Logger class for handling log messages
    public class Logger
    {
        private readonly List<ISink> sinks;

        // Constructor that initializes the logger with specified sinks
        public Logger(params ISink[] sinks)
        {
            this.sinks = new List<ISink>(sinks);
        }

        // LogMessage method to log a message with content, level, and namespace
        public void LogMessage(string content, LogLevel level, string namespaceName)
        {
            var message = new LogMessage
            {
                Content = content,
                Level = level,
                Namespace = namespaceName
            };

            // Route the message to appropriate sinks
            foreach (var sink in sinks)
            {
                sink.LogMessage(message);
            }
        }
    }
}
