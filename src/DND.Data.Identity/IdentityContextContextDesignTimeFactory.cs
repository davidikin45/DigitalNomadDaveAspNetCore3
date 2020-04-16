using Autofac.AspNetCore.Extensions;
using Autofac.AspNetCore.Extensions.Data;
using Autofac.AspNetCore.Extensions.Data.IdentificationStrategies;
using EntityFrameworkCore.Initialization;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;

namespace DND.Data.Identity
{
    //https://medium.com/oppr/net-core-using-entity-framework-core-in-a-separate-project-e8636f9dc9e5
    public class IdentityContextContextDesignTimeFactory : IDesignTimeDbContextFactory<IdentityContext>
    {
        public IdentityContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile(@Directory.GetCurrentDirectory() + "/../DND.Web/appsettings.json")
                .AddJsonFile(@Directory.GetCurrentDirectory() + "/../DND.Web/appsettings.Development.json", optional: true).Build();

            var connectionString = configuration.GetConnectionString("DefaultConnection");

            Console.WriteLine("AppContextDesignTimeFactory.Create(string): Connection string: {0}", connectionString);

            var optionsBuilder = new DbContextOptionsBuilder<IdentityContext>();
            optionsBuilder.SetConnectionString<IdentityContext>(connectionString);

            var services = new ServiceCollection();
            services.AddSingleton<IDbContextTenantStrategy<IdentityContext>>(sp => new DifferentConnectionFilterTenantDifferentSchemaDbContext<IdentityContext>("DefaultConnection"));

            return new IdentityContext(optionsBuilder.Options, new MultiTenantService(new MultiTenantDbContextStrategyService(services.BuildServiceProvider()), new Tenant(null, configuration)));
        }
    }
}
