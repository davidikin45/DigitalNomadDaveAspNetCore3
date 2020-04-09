using AspNetCore.Testing.TestServer;
using DND.Web;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DND.IntegrationTests
{
    public class WebAppFactory : WebApplicationFactoryBase<Startup>
    {
        protected override IHostBuilder CreateHostBuilder()
        {
            var args = new string[] { };
            var contentRoot = GetContentRoot();
            var config = Program.BuildWebHostConfiguration("Integration", contentRoot);

            Program.Configuration = config;
            var builder = Program.CreateHostBuilder(args);

            return builder;
        }

        public override void ConfigureTestServices(IServiceCollection services)
        {

        }
    }
}
