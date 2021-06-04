using System.Collections.Generic;

namespace Azenix.Services
{
    public interface IReportingService
    {
        int GetNumUniqueIPAddresses();
        List<string> GetTopNVisitedUrls(int numToTake);
        List<string> GetTopNMostActiveIPs(int numToTake);
    }
}
