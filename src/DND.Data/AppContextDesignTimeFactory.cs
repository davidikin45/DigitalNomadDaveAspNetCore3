using AspNetCore.Mvc.Extensions.Data;
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
using System.Reflection;

namespace DND.Data
{
    //https://medium.com/oppr/net-core-using-entity-framework-core-in-a-separate-project-e8636f9dc9e5
    public class AppContextDesignTimeFactory : IDesignTimeDbContextFactory<AppContext>
    {
        public AppContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile(@Directory.GetCurrentDirectory() + "/../DND.Web/appsettings.json")
               .AddJsonFile(@Directory.GetCurrentDirectory() + "/../DND.Web/appsettings.Development.json", optional: true).Build();

            var connectionString = configuration.GetConnectionString("DefaultConnection");

            Console.WriteLine("AppContextDesignTimeFactory.Create(string): Connection string: {0}", connectionString);

            var optionsBuilder = new DbContextOptionsBuilder<AppContext>();
            optionsBuilder.SetConnectionString<AppContext>(connectionString);

            var services = new ServiceCollection();
            services.AddSingleton<IDbContextTenantStrategy<AppContext>>(sp => new DifferentConnectionFilterTenantDifferentSchemaDbContext<AppContext>("DefaultConnection"));

            return new AppContext(optionsBuilder.Options, new MultiTenantService(new MultiTenantDbContextStrategyService(services.BuildServiceProvider()), new Tenant(null, configuration)));
        }
    }
}
