using AspNetCore.Mvc.Extensions;
using AspNetCore.Mvc.Extensions.StartupTasks;
using DND.Data.Identity.Initializers;
using DND.Domain.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace DND.Data.Identity
{
    public class IdentityContextInitializer : DbStartupTaskBlocking
    {
        private readonly IHostEnvironment _hostingEnvironment;
        private readonly IdentityContext _context;
        private readonly IPasswordHasher<User> _passwordHasher;

        public override int Order => 0;

        public IdentityContextInitializer(IServiceProvider serviceProvider, IdentityContext context, IPasswordHasher<User> passwordHasher, IHostEnvironment hostingEnvironment)
            :base(serviceProvider)
        {
            _context = context;
            _passwordHasher = passwordHasher;
            _hostingEnvironment = hostingEnvironment;
        }

        protected override async Task ExecuteAsync(IServiceProvider scopedServiceProvider, CancellationToken stoppingToken)
        {
            if (_hostingEnvironment.IsStaging() || _hostingEnvironment.IsProduction())
            {
                var migrationInitializer = new IdentityContextInitializerMigrate(_passwordHasher);
                await migrationInitializer.InitializeAsync(_context);
            }
            else if (_hostingEnvironment.IsIntegration())
            {
                var migrationInitializer = new IdentityContextInitializerDropMigrate(_passwordHasher);
                await migrationInitializer.InitializeAsync(_context);
            }
            else
            {
                var migrationInitializer = new IdentityContextInitializerDropMigrate(_passwordHasher);
                await migrationInitializer.InitializeAsync(_context);
            }
        }
    }
}
