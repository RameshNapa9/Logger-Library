using LoggerLibrary.Sinks;
using System.Collections.Generic;

namespace LoggerLibrary.LoggerLibrary
{
    // LoggerConfiguration class to configure logger with sinks
    public class LoggerConfiguration
    {
        public List<ISink> Sinks { get; }

        // Constructor that initializes the list of sinks
        public LoggerConfiguration()
        {
            Sinks = new List<ISink>();
        }

        // AddSink method to add a sink to the configuration
        public void AddSink(ISink sink)
        {
            Sinks.Add(sink);
        }
    }
}
