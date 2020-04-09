using IdentityServer4.EntityFramework.DbContexts;
using IdentityServer4.EntityFramework.Options;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace DND.IDP.Entities
{
    public class UserContextDesignTimeFactory : DesignTimeDbContextFactoryBase<UserContext>
    {
        public UserContextDesignTimeFactory()
            : base("IDPUserDBConnectionString", typeof(Startup).GetTypeInfo().Assembly.GetName().Name)
        {
        }

        protected override UserContext CreateNewInstance(DbContextOptions<UserContext> options)
        {
            return new UserContext(options);
        }
    }

    public class ConfigurationContextDesignTimeFactory : DesignTimeDbContextFactoryBase<ConfigurationDbContext>
    {
        public ConfigurationContextDesignTimeFactory()
            : base("IDPDataDBConnectionString", typeof(Startup).GetTypeInfo().Assembly.GetName().Name)
        {
        }

        protected override ConfigurationDbContext CreateNewInstance(DbContextOptions<ConfigurationDbContext> options)
        {
            return new ConfigurationDbContext(options, new ConfigurationStoreOptions());
        }
    }

    public class PersistedGrantContextDesignTimeFactory : DesignTimeDbContextFactoryBase<PersistedGrantDbContext>
    {
        public PersistedGrantContextDesignTimeFactory()
            : base("IDPDataDBConnectionString", typeof(Startup).GetTypeInfo().Assembly.GetName().Name)
        {
        }

        protected override PersistedGrantDbContext CreateNewInstance(DbContextOptions<PersistedGrantDbContext> options)
        {
            return new PersistedGrantDbContext(options, new OperationalStoreOptions());
        }
    }
}
