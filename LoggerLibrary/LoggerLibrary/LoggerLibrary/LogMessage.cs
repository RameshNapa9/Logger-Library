namespace LoggerLibrary.LoggerLibrary
{
    // LogMessage class representing a log message with content, level, and namespace
    public class LogMessage
    {
        public string Content { get; set; }
        public LogLevel Level { get; set; }
        public string Namespace { get; set; }
    }
}
