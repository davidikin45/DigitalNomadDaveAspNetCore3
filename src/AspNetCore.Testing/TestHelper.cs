﻿using AspNetCore.Mvc.Extensions.Data.Repository;
using AspNetCore.Mvc.Extensions.Logging;
using EntityFrameworkCore.Initialization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using System.Security.Claims;
using Xunit.Abstractions;

namespace AspNetCore.Testing
{
    public static class TestHelper
    {
        public static ILoggerFactory XunitCommandLoggerFactory(ITestOutputHelper output)
        => new ServiceCollection().AddLogging(builder =>
        {
            builder.AddAction(log => output.WriteLine(log))
            .AddFilter(DbLoggerCategory.Database.Command.Name, LogLevel.Information);
        }).BuildServiceProvider()
        .GetService<ILoggerFactory>();

        public static void MockCurrentUser(this Controller controller, string userId, string username, string authenticationType)
        {
            controller.MockHttpContext(userId, username, authenticationType);
        }

        private static ClaimsPrincipal CreateClaimsPrincipal(string userId, string username, string authenticationType)
        {
            var user = new ClaimsPrincipal(new ClaimsIdentity(new Claim[]
           {
                new Claim(ClaimTypes.Name, username),
                new Claim(ClaimTypes.NameIdentifier, userId),
            }, authenticationType));

            return user;
        }

        public static void MockHttpContext(this Controller controller, string userId, string username, string authenticationType)
        {
            var httpContext = FakeAuthenticatedHttpContext(userId, username, authenticationType);
            controller.ControllerContext = new ControllerContext
            {
                HttpContext = httpContext
            };
        }

        private static HttpContext FakeAuthenticatedHttpContext(string userId, string username, string authenticationType)
        {
            var context = new DefaultHttpContext
            {
                User = CreateClaimsPrincipal(userId, username, authenticationType)
            };

            return context;
        }

        private static readonly Dictionary<string, IConfigurationRoot> _configs = new Dictionary<string, IConfigurationRoot>();
        public static IConfigurationRoot GetConfiguration(string environmentName = "Development")
        {
            var basePath = Directory.GetCurrentDirectory();

            if(!_configs.ContainsKey(environmentName))
            {
                _configs.Add(environmentName, new ConfigurationBuilder()
                .SetBasePath(basePath)
                .AddJsonFile($"appsettings.json", false)
                .AddJsonFile($"appsettings.{environmentName}.json", false)
                .AddEnvironmentVariables()
                .Build());
            }

            return _configs[environmentName];
        }

        public static GenericRepository<TEntity> GetRepository<TContext, TEntity>(string connectionString, bool beginTransaction)
            where TContext : DbContext
            where TEntity : class
        {
            var context = GetContext<TContext>(connectionString, beginTransaction);
            return new GenericRepository<TEntity>(context);
        }

        public static TContext GetContext<TContext>(string connectionString, bool beginTransaction)
          where TContext : DbContext
        {

            DbContextOptions options;
            var builder = new DbContextOptionsBuilder();
            builder.SetConnectionString<TContext>(connectionString);
            builder.EnableSensitiveDataLogging();
            options = builder.Options;

            Type type = typeof(TContext);
            ConstructorInfo ctor = type.GetConstructor(new[] { typeof(DbContextOptions) });

            TContext context = (TContext)ctor.Invoke(new object[] { options });

            if (beginTransaction)
            {
                context.Database.BeginTransaction();
            }

            return context;
        }

        public static DbContextOptions<TContext> DbContextOptionsSqlite<TContext>(string dbName)
          where TContext : DbContext
        {

            var connectionString = $"Data Source={dbName}.db;";

            var builder = new DbContextOptionsBuilder<TContext>();
            builder.UseSqlite(connectionString);
            builder.EnableSensitiveDataLogging();
            return builder.Options;
        }

        public static DbContextOptions<TContext> DbContextOptionsSqliteInMemory<TContext>()
         where TContext : DbContext
        {

            var connectionString = "DataSource=:memory:";

            var builder = new DbContextOptionsBuilder<TContext>();
            builder.UseSqlite(connectionString);
            builder.EnableSensitiveDataLogging();
            return builder.Options;
        }

        public static DbContextOptions<TContext> DbContextOptionsInMemory<TContext>(string dbName = "")
             where TContext : DbContext
        {
            if (string.IsNullOrEmpty(dbName))
            {
                dbName = Guid.NewGuid().ToString();
            }

            var builder = new DbContextOptionsBuilder<TContext>();
            builder.UseInMemoryDatabase(dbName);
            builder.EnableSensitiveDataLogging();
            return builder.Options;
        }

        public static DbContextOptions<TContext> DbContextOptionsSqlLocalDb<TContext>(string dbName)
             where TContext : DbContext
        {
            var connectionString = new SqlConnectionStringBuilder() {
                DataSource = @"(LocalDB)\MSSQLLocalDB",
                InitialCatalog = dbName,
                IntegratedSecurity = true,
                MultipleActiveResultSets = true
            }.ConnectionString;

            var builder = new DbContextOptionsBuilder<TContext>();
            builder.UseSqlServer(connectionString);
            builder.EnableSensitiveDataLogging();
            return builder.Options;
        }
    }
}
