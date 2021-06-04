using System;
using Azenix.Services;

namespace Azenix
{
    public class Application : IApplication
    {
        private readonly IReportingService _reportingService;

        public Application(IReportingService reportingService)
        {
            _reportingService = reportingService;
        }

        public void Run()
        {
            Console.WriteLine("The number of unique IP addresses: {0}", _reportingService.GetNumUniqueIPAddresses());
            Console.WriteLine("");

            Console.WriteLine("The top 3 most visited URLs:");
            foreach (var url in _reportingService.GetTopNVisitedUrls(3))
            {
                Console.WriteLine(url);
            }
            Console.WriteLine("");

            Console.WriteLine("The top 3 most active IP addresses:");
            foreach (var ipAddress in _reportingService.GetTopNMostActiveIPs(3))
            {
                Console.WriteLine(ipAddress);
            }
        }
    }
}
