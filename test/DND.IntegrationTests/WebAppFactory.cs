using AspNetCore.Testing.TestServer;
using DND.Web;
using Microsoft.Extensions.DependencyInjection;

namespace DND.IntegrationTests
{
    public class WebAppFactory : WebApplicationFactoryBase<Startup>
    {
        public WebAppFactory() : base("Integration")
        {

        }

        //After Startup.ConfigureServices
        //Override ALL services which connect to a DB
        //Need to remove DbContext before readding due to EntityFramework using TryAdd
        public override void ConfigureTestServices(IServiceCollection services)
        {
            //services.RemoveDbContext<AppContext>();
            //services.AddDbContext<AppContext>("DataSource=:memory:");
            //services.AddDbStartupTask<AppContext>((sp, db) =>
            //{
            //    db.Database.Migrate();
            //    //db.Database.EnsureCreated();
            //}, -1);
            //services.RemoveDbContext<IdentityContext>();
            //services.AddDbContext<IdentityContext>("DataSource=:memory:");
            //services.AddDbStartupTask<IdentityContext>((sp, db) =>
            //{
            //     db.Database.Migrate();
            //    //db.Database.EnsureCreated();
            //}, -1);
            //services.RemoveDbContextNoSql<NoSqlContext>();
            //services.AddDbContextNoSql<NoSqlContext>(":memory:");
            //services.AddDbStartupTask<NoSqlContext>((sp, db) =>
            //{

            //});
            //services.AddHangfireInMemoryServer("web-app", options => options.PrepareSchemaIfNecessary = false);

            //services.RemoveAll(typeof(IHostedService));
        }
    }
}
