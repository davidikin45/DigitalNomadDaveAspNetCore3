using AspNetCore.Mvc.Extensions.Data.Helpers;
using AspNetCore.Mvc.Extensions.Hangfire;
using Autofac.AspNetCore.Extensions;
using Autofac.AspNetCore.Extensions.Data;
using Autofac.AspNetCore.Extensions.Data.IdentificationStrategies;
using Database.Initialization;
using DND.Data;
using DND.Data.Initializers;
using Hangfire.Initialization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MiniProfiler.Initialization;
using System.Data.SqlClient;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace DND.IntegrationTests.Data
{
    public class SqlServerDbTests
    {
        private readonly ITestOutputHelper _output;

        public SqlServerDbTests(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public async Task Initialization()
        {
            var services = new ServiceCollection();
            services.AddSingleton<IDbContextTenantStrategy<AppContext>>(sp => new DummyTenantDbContext<AppContext>());
            var tenant = new Tenant("", new ConfigurationBuilder().Build());
            ITenantService tenantService = new MultiTenantService(new MultiTenantDbContextStrategyService(services.BuildServiceProvider()), tenant);

            //db location = C:\Users\{user}
            var options = DbContextConnections.DbContextOptionsSqlLocalDB<AppContext>("SqlTest", log => _output.WriteLine(log));

            var connectionString = new SqlConnectionStringBuilder()
            {
                DataSource = @"(LocalDB)\MSSQLLocalDB",
                InitialCatalog = "SqlTest",
                IntegratedSecurity = true,
                MultipleActiveResultSets = true
            }.ConnectionString;

            await HangfireInitializer.EnsureDbDestroyedAsync(connectionString);

            using (var context = new AppContext(options, tenantService))
            {
                var dbInitializer = new AppContextInitializerDropMigrate();
                await dbInitializer.InitializeAsync(context);
            }

            using (var context = new AppContext(options, tenantService))
            {
                var dbInitializer = new AppContextInitializerDropCreate();
                var sql = context.GenerateCreateTablesScript();
                await dbInitializer.InitializeAsync(context);
                await context.Database.EnsureDeletedAsync();
            }
        }

        [Fact]
        public async Task HangfireInitialization()
        {
            var dbName = "HangfireSqlTest";
            var connectionString = new SqlConnectionStringBuilder()
            {
                DataSource = @"(LocalDB)\MSSQLLocalDB",
                InitialCatalog = dbName,
                IntegratedSecurity = true,
                MultipleActiveResultSets = true
            }.ConnectionString;

            await HangfireInitializer.EnsureDbDestroyedAsync(connectionString);
            Assert.False(await DbInitializer.ExistsAsync(connectionString));

            var dbInitializer = new HangfireInitializerDropCreate();
            await dbInitializer.InitializeAsync(connectionString);

            await DbInitializer.TestConnectionAsync(connectionString);

            Assert.True(await DbInitializer.ExistsAsync(connectionString));
            Assert.Equal(11, await DbInitializer.TableCountAsync(connectionString));

            await HangfireInitializer.EnsureTablesDeletedAsync(connectionString);
            Assert.True(await DbInitializer.ExistsAsync(connectionString));
            Assert.Equal(0, await DbInitializer.TableCountAsync(connectionString));

            await HangfireInitializer.EnsureDbDestroyedAsync(connectionString);
            Assert.False(await DbInitializer.ExistsAsync(connectionString));
        }

        [Fact]
        public async Task MiniProfilerInitialization()
        {
            var dbName = " MiniProfilerSqlTest";
            var connectionString = new SqlConnectionStringBuilder()
            {
                DataSource = @"(LocalDB)\MSSQLLocalDB",
                InitialCatalog = dbName,
                IntegratedSecurity = true,
                MultipleActiveResultSets = true
            }.ConnectionString;

            await MiniProfilerInitializer.EnsureDbDestroyedAsync(connectionString);
            Assert.False(await DbInitializer.ExistsAsync(connectionString));

            await MiniProfilerInitializer.EnsureTablesDeletedAsync(connectionString);
            await MiniProfilerInitializer.EnsureDbAndTablesCreatedAsync(connectionString);

            await DbInitializer.TestConnectionAsync(connectionString);

            Assert.True(await DbInitializer.ExistsAsync(connectionString));
            Assert.Equal(3, await DbInitializer.TableCountAsync(connectionString));

            await MiniProfilerInitializer.EnsureTablesDeletedAsync(connectionString);
            Assert.Equal(0, await DbInitializer.TableCountAsync(connectionString));

            await MiniProfilerInitializer.EnsureDbDestroyedAsync(connectionString);
            Assert.False(await DbInitializer.ExistsAsync(connectionString));
        }
    }
}
