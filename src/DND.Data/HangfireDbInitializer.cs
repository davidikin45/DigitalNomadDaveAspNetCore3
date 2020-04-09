using AspNetCore.Mvc.Extensions.Hangfire;
using AspNetCore.Mvc.Extensions.Settings;
using AspNetCore.Mvc.Extensions.StartupTasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace DND.Data
{
    public class HangfireDbInitializer : DbStartupTaskBlocking
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly ConnectionStrings _connectionStrings;

        public override int Order => 1;

        public HangfireDbInitializer(IServiceProvider serviceProvder, ConnectionStrings connectionStrings, IWebHostEnvironment hostingEnvironment)
            :base(serviceProvder)
        {
            _connectionStrings = connectionStrings;
            _hostingEnvironment = hostingEnvironment;
        }

        protected override async Task ExecuteAsync(IServiceProvider scopedServiceProvider, CancellationToken stoppingToken)
        {
            if (_hostingEnvironment.IsStaging() || _hostingEnvironment.IsProduction())
            {
                var dbInitializer = new HangfireInitializerCreate();
                await dbInitializer.InitializeAsync(_connectionStrings["HangfireConnection"]);
            }
            else
            {
                var dbInitializer = new HangfireInitializerDropCreate();
                await dbInitializer.InitializeAsync(_connectionStrings["HangfireConnection"]);
            }
        }
    }
}
