using System.Collections.Generic;
using System.Linq;
using Azenix.Model;
using Azenix.Repository;

namespace Azenix.Services
{
    public class ReportingService : IReportingService
    {
        private readonly IRepository _repository;
        private readonly ILogParsingService _logParsingService;
        private List<LogEvent> _logEvents;

        public ReportingService(IRepository repository, ILogParsingService logParsingService)
        {
            _repository = repository;
            _logParsingService = logParsingService;

            GetAndParseLogs();
        }

        public int GetNumUniqueIPAddresses()
        {
            return _logEvents.Select(x => x.ClientIp).Distinct().Count();
        }

        public List<string> GetTopNVisitedUrls(int numToTake)
        {
            var urlGroups = _logEvents.GroupBy(
                x => x.Uri,
                (key, values) => new {Url = key, Count = values.Count()}
            );

            return urlGroups
                .OrderByDescending(x => x.Count)
                .Take(numToTake)
                .Select(x => x.Url)
                .ToList();
        }

        public List<string> GetTopNMostActiveIPs(int numToTake)
        {
            var urlGroups = _logEvents.GroupBy(
                x => x.ClientIp,
                (key, values) => new { ClientIp = key, Visits = values.Count() }
            );

            return urlGroups
                .OrderByDescending(x => x.Visits)
                .Take(numToTake)
                .Select(x => x.ClientIp)
                .ToList();
        }

        private void GetAndParseLogs()
        {
            var logFileEntries = _repository.GetLogFileEntries();
            _logEvents = new List<LogEvent>();

            foreach (var logFileEntry in logFileEntries)
            {
                _logEvents.Add(_logParsingService.ParseLogEntry(logFileEntry));
            }
        }
    }
}
