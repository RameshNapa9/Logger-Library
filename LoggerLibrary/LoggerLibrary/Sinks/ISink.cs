using LoggerLibrary.LoggerLibrary;

namespace LoggerLibrary.Sinks
{
    // ISink interface for different log message destinations
    public interface ISink
    {
        // LogMessage method to log a message to the sink
        void LogMessage(LogMessage message);
    }
}
