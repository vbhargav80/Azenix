using Azenix.Model;

namespace Azenix.Services
{
    public interface ILogParsingService
    {
        LogEvent ParseLogEntry(string logEntry);
    }
}
