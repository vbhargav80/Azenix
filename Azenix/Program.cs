using Azenix.Repository;
using Azenix.Services;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Azenix
{
    class Program
    {
        static void Main(string[] args)
        {
            using IHost host = CreateHostBuilder(args).Build();

            var application = host.Services.GetService<IApplication>();
            application.Run();
        }

        static IHostBuilder CreateHostBuilder(string[] args)
        {

            return Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddTransient<IRepository, FlatFileRepository>()
                        .AddTransient<IApplication, Application>()
                        .AddTransient<ILogParsingService, LogParsingService>()
                        .AddTransient<IReportingService, ReportingService>();
                });
        }
    }
}
