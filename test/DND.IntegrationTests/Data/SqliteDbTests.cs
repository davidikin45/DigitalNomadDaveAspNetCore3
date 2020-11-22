using AspNetCore.Mvc.Extensions.Data.Helpers;
using AspNetCore.Mvc.Extensions.Hangfire;
using Autofac.AspNetCore.Extensions;
using Autofac.AspNetCore.Extensions.Data;
using Autofac.AspNetCore.Extensions.Data.IdentificationStrategies;
using Database.Initialization;
using DND.Data;
using DND.Data.Initializers;
using Hangfire.Initialization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MiniProfiler.Initialization;
using System.IO;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace DND.IntegrationTests.Data
{
    public class SqliteDbTests
    {
        private readonly ITestOutputHelper _output;

        public SqliteDbTests(ITestOutputHelper output)
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

            var dbName = "SqliteTest";
            var options = DbContextConnections.DbContextOptionsSqlite<AppContext>(dbName, log => _output.WriteLine(log));

            //using (var context = new AppContext(options, tenantService))
            //{
            //    var dbInitializer = new AppContextInitializerDropMigrate();
            //    await dbInitializer.InitializeAsync(context);
            //}

            using (var context = new AppContext(options, tenantService))
            {
                var dbInitializer = new AppContextInitializerDropCreate();
                await dbInitializer.InitializeAsync(context);
                await context.Database.EnsureDeletedAsync();

                var fullPath = Path.GetFullPath($"{dbName}.db");
                Assert.False(File.Exists(fullPath));
            }
        }

        [Fact]
        public async Task HangfireInitialization()
        {

            var dbName = "HangfireSqliteTest";
            var connectionString = $"Data Source={dbName}.db;";

            var dbInitializer = new HangfireInitializerDropCreate();
            await dbInitializer.InitializeAsync(connectionString);

            Assert.True(await DbInitializer.ExistsAsync(connectionString));
            Assert.Equal(11, await DbInitializer.TableCountAsync(connectionString));

            var fullPath = Path.GetFullPath($"{dbName}.db");
            Assert.True(File.Exists(fullPath));

            await HangfireInitializer.EnsureTablesDeletedAsync(connectionString);


            Assert.Equal(0, await DbInitializer.TableCountAsync(connectionString));

            Assert.True(File.Exists(fullPath));

            Assert.False(await DbInitializer.HasTablesAsync(connectionString));

            await HangfireInitializer.EnsureDbDestroyedAsync(connectionString);

            Assert.False(await DbInitializer.ExistsAsync(connectionString));

            Assert.False(File.Exists(fullPath));
        }

        [Fact]
        public async Task MiniProfilerInitialization()
        {

            var dbName = "MiniProfilerSqliteTest";
            var connectionString = $"Data Source={dbName}.db;";

            await MiniProfilerInitializer.EnsureTablesDeletedAsync(connectionString);
            await MiniProfilerInitializer.EnsureDbAndTablesCreatedAsync(connectionString);

            Assert.True(await DbInitializer.ExistsAsync(connectionString));
            Assert.Equal(3, await DbInitializer.TableCountAsync(connectionString));

            var fullPath = Path.GetFullPath($"{dbName}.db");
            Assert.True(File.Exists(fullPath));

            await MiniProfilerInitializer.EnsureTablesDeletedAsync(connectionString);

            Assert.Equal(0, await DbInitializer.TableCountAsync(connectionString));

            Assert.True(File.Exists(fullPath));

            Assert.False(await DbInitializer.HasTablesAsync(connectionString));

            await MiniProfilerInitializer.EnsureDbDestroyedAsync(connectionString);

            Assert.False(await DbInitializer.ExistsAsync(connectionString));

            Assert.False(File.Exists(fullPath));
        }
    }
}
