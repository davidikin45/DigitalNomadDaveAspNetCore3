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
    public class ApplicationContextInitializer : DbStartupTaskBlocking
    {
        private readonly IHostEnvironment _hostingEnvironment;

        public override int Order => 0;

        public ApplicationContextInitializer(IServiceProvider serviceProvider, IHostEnvironment hostingEnvironment)
            :base(serviceProvider)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        protected override async Task ExecuteAsync(IServiceProvider scopedServiceProvider, CancellationToken stoppingToken)
        {
            var context = scopedServiceProvider.GetRequiredService<AppContext>();
            if (_hostingEnvironment.IsStaging() || _hostingEnvironment.IsProduction())
            {
                var dbInitializer = new AppContextInitializerMigrate();
                await dbInitializer.InitializeAsync(context);
            }
            else if (_hostingEnvironment.IsIntegration())
            {
                //Can't have multi provider migrations so best to only use migrations in production.
                //Can only be used for sqlserver and sqlite. Throws exception for InMemory
                //var dbInitializer = new AppContextInitializerDropMigrate();
                var dbInitializer = new AppContextInitializerDropCreate();
                await dbInitializer.InitializeAsync(context);
            }
            else
            {
                var dbInitializer = new AppContextInitializerDropCreate();
                await dbInitializer.InitializeAsync(context);
            }
        }
    }
}
