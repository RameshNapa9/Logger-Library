using LoggerLibrary.LoggerLibrary;
using System;
using System.Collections.Generic;

namespace LoggerLibrary.Sinks
{
    public class ConsoleSink : ISink
    {
        private readonly HashSet<LogLevel> supportedLevels;

        public ConsoleSink(params LogLevel[] levels)
        {
            supportedLevels = new HashSet<LogLevel>(levels);
        }

        public void LogMessage(LogMessage message)
        {
            if (supportedLevels.Contains(message.Level))
            {
                Console.WriteLine($"[{message.Level}] [{message.Namespace}] {message.Content}");
            }
        }
    }

}
