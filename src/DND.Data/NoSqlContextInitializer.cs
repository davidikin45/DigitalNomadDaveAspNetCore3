using AspNetCore.Mvc.Extensions;
using AspNetCore.Mvc.Extensions.StartupTasks;
using DND.Data.Initializers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace DND.Data
{
    public class NoSqlContextInitializer : DbStartupTaskBlocking
    {
        private readonly IHostEnvironment _hostingEnvironment;

        public override int Order => 0;

        public NoSqlContextInitializer(IServiceProvider serviceProvider, IHostEnvironment hostingEnvironment)
            :base(serviceProvider)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        protected override async Task ExecuteAsync(IServiceProvider scopedServiceProvider, CancellationToken stoppingToken)
        {
            var context = scopedServiceProvider.GetRequiredService<NoSqlContext>();

            if (_hostingEnvironment.IsStaging() || _hostingEnvironment.IsProduction())
            {
                var dbInitializer = new NoSqlContextInitializerMigrate();
                await dbInitializer.InitializeAsync(context);
            }
            else if (_hostingEnvironment.IsIntegration())
            {
                var dbInitializer = new NoSqlContextInitializerDropCreate();
                await dbInitializer.InitializeAsync(context);
            }
            else
            {
                var dbInitializer = new NoSqlContextInitializerDropCreate();
                await dbInitializer.InitializeAsync(context);
            }
        }
    }
}
