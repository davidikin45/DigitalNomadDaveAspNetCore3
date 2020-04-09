using AspNetCore.Mvc.Extensions.Data;
using Autofac.AspNetCore.Extensions;
using Autofac.AspNetCore.Extensions.Data;
using Autofac.AspNetCore.Extensions.Data.IdentificationStrategies;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace DND.Data.Identity
{
    public class IdentityContextContextDesignTimeFactory : DesignTimeDbContextFactoryBase<IdentityContext>
    {
        public IdentityContextContextDesignTimeFactory()
            : base("IdentityConnection", typeof(IdentityContext).GetTypeInfo().Assembly.GetName().Name)
        {
        }

        protected override IdentityContext CreateNewInstance(IConfiguration configuration, DbContextOptions<IdentityContext> options)
        {
            var services = new ServiceCollection();
            services.AddSingleton<IDbContextTenantStrategy<IdentityContext>>(sp => new DifferentConnectionFilterTenantDifferentSchemaDbContext<IdentityContext>(this.ConnectionStringName));
            return new IdentityContext(options, new MultiTenantService(new MultiTenantDbContextStrategyService(services.BuildServiceProvider()), new Tenant(null, configuration)));
        }
    }
}
