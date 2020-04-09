using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(DND.Web.StartupIdentity))]
namespace DND.Web
{
    public class StartupIdentity : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                //services.AddDbContext<IdentityContext>(options => options.UseSqlServer(context.Configuration.GetConnectionString("IdentityConnection")));
                //services.AddIdentity<IdentityUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
                //.AddEntityFrameworkStores<IdentityContext>()
                //.AddDefaultUI()
                //.AddDefaultTokenProviders();
            });
        }
    }
}