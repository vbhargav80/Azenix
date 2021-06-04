using System.Text.RegularExpressions;
using Azenix.Model;

namespace Azenix.Services
{
    public class LogParsingService : ILogParsingService
    {
        private const string LogEntryPattern = "^([\\d.]+) (\\S+) (\\S+) \\[([\\w:/]+\\s[+\\-]\\d{4})\\] \"(.+?)\" (\\d{3}) (\\d+) \"([^\"]+)\" \"([^\"]+)\"";

        public LogEvent ParseLogEntry(string logEntry)
        {
            Match regexMatch = Regex.Match(logEntry, LogEntryPattern);

            var logEvent = new LogEvent
            {
                ClientIp = regexMatch.Groups[1].Value,
                Timestamp = regexMatch.Groups[4].Value,
                Uri = regexMatch.Groups[5].Value,
                HttpStatusCode = regexMatch.Groups[6].Value,
                NumBytes = regexMatch.Groups[7].Value,
                UserAgent = regexMatch.Groups[9].Value
            };

            return logEvent;
        }
    }
}
