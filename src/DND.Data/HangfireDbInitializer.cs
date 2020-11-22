using AspNetCore.Mvc.Extensions;
using AspNetCore.Mvc.Extensions.Hangfire;
using AspNetCore.Mvc.Extensions.Settings;
using AspNetCore.Mvc.Extensions.StartupTasks;
using Database.Initialization;
using Hangfire;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
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
            var connection = _connectionStrings["HangfireConnection"];

            //Can only be used for SQL Server and SQLite physical databases. No need to initialize for InMemory, SQLite InMemory Initializes automatically.
            if (!string.IsNullOrEmpty(connection) && !ConnectionStringHelper.IsSQLiteInMemory(connection))
            {
                if (_hostingEnvironment.IsStaging() || _hostingEnvironment.IsProduction())
                {
                    var dbInitializer = new HangfireInitializerCreate();
                    await dbInitializer.InitializeAsync(connection);
                }
                else if (_hostingEnvironment.IsIntegration())
                {

                    var dbInitializer = new HangfireInitializerDropCreate();
                    await dbInitializer.InitializeAsync(connection);

                }
                else
                {
                    var dbInitializer = new HangfireInitializerDropCreate();
                    await dbInitializer.InitializeAsync(connection);
                }
            }
        }
    }
}
