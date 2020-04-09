using AspNetCore.Mvc.Extensions.Data;
using Autofac.AspNetCore.Extensions;
using Autofac.AspNetCore.Extensions.Data;
using Autofac.AspNetCore.Extensions.Data.IdentificationStrategies;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace DND.Data
{
    //https://medium.com/oppr/net-core-using-entity-framework-core-in-a-separate-project-e8636f9dc9e5
    public class AppContextDesignTimeFactory : DesignTimeDbContextFactoryBase<AppContext>
    {
        public AppContextDesignTimeFactory()
            : base("DefaultConnection", typeof(AppContext).GetTypeInfo().Assembly.GetName().Name)
        {

        }

        protected override AppContext CreateNewInstance(IConfiguration configuration, DbContextOptions<AppContext> options)
        {
            var services = new ServiceCollection();
            services.AddSingleton<IDbContextTenantStrategy<AppContext>>(sp => new DifferentConnectionFilterTenantDifferentSchemaDbContext<AppContext>(this.ConnectionStringName));
            return new AppContext(options, new MultiTenantService(new MultiTenantDbContextStrategyService(services.BuildServiceProvider()), new Tenant(null, configuration)));
        }
    }
}
