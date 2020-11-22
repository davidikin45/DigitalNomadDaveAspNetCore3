using AspNetCore.Mvc.Extensions;
using AspNetCore.Mvc.Extensions.StartupTasks;
using DND.Data.Identity.Initializers;
using DND.Domain.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace DND.Data.Identity
{
    public class IdentityContextInitializer : DbStartupTaskBlocking
    {
        private readonly IHostEnvironment _hostingEnvironment;

        public override int Order => 0;

        public IdentityContextInitializer(IServiceProvider serviceProvider, IHostEnvironment hostingEnvironment)
            :base(serviceProvider)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        protected override async Task ExecuteAsync(IServiceProvider scopedServiceProvider, CancellationToken stoppingToken)
        {
            var context = scopedServiceProvider.GetRequiredService<IdentityContext>();
            if (_hostingEnvironment.IsStaging() || _hostingEnvironment.IsProduction())
            {
                var migrationInitializer = new IdentityContextInitializerMigrate();
                await migrationInitializer.InitializeAsync(context);
            }
            else if (_hostingEnvironment.IsIntegration())
            {
                //Can't have multi provider migrations so best to only use migrations in production.
                //var migrationInitializer = new IdentityContextInitializerDropMigrate();
                var migrationInitializer = new IdentityContextInitializerDropCreate();
                await migrationInitializer.InitializeAsync(context);
            }
            else
            {
                var migrationInitializer = new IdentityContextInitializerDropCreate();
                await migrationInitializer.InitializeAsync(context);
            }
        }
    }
}
