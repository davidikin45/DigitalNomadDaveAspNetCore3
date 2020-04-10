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
            var passwordHasher = scopedServiceProvider.GetRequiredService<IPasswordHasher<User>>();
            if (_hostingEnvironment.IsStaging() || _hostingEnvironment.IsProduction())
            {
                var migrationInitializer = new IdentityContextInitializerMigrate(passwordHasher);
                await migrationInitializer.InitializeAsync(context);
            }
            else if (_hostingEnvironment.IsIntegration())
            {
                var migrationInitializer = new IdentityContextInitializerDropMigrate(passwordHasher);
                await migrationInitializer.InitializeAsync(context);
            }
            else
            {
                var migrationInitializer = new IdentityContextInitializerDropMigrate(passwordHasher);
                await migrationInitializer.InitializeAsync(context);
            }
        }
    }
}
