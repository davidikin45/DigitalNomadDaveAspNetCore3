using DND.IDP.Entities;
using DND.IDP.Extensions;
using IdentityServer4;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace DND.IDP
{
    public class Startup
    {
        private bool InMemory = false;

        public IHostingEnvironment HostingEnvironment { get; }
        public IConfiguration Configuration { get; }
        public ILoggerFactory LoggerFactory { get; }

        public Startup(IConfiguration configuration, IHostingEnvironment hostingEnvironment, ILoggerFactory loggerFactory)
        {
            Configuration = configuration;
            HostingEnvironment = hostingEnvironment;
            LoggerFactory = loggerFactory;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            var builder = services.AddIdentityServer();

            string privateSigningKeyPath = HostingEnvironment.MapContentPath("~/SigningKeys/private.rsa.pem");
            builder.AddSigningCredential(LoadSigningCredential(privateSigningKeyPath));

            //builder.AddDeveloperSigningCredential(); //Adds kid so is unique each time it starts

            //Windows Authentication
            //https://stackoverflow.com/questions/36946304/using-windows-authentication-in-asp-net
            //Ensure windows authentication is enabled in Solution\.vs\config\applicationhost.config
            //Windows 10 Home
            //dism /online /norestart /add-package:%SystemRoot%\servicing\Packages\Microsoft-Windows-IIS-WebServer-AddOn-2-Package~31bf3856ad364e35~amd64~~10.0.17134.1.mum
            //Turn Windows features on or off > Internet Information Services > World Wide Web Services > Security > Windows Authentication
            services.Configure<IISOptions>(iis =>
            {
                iis.AuthenticationDisplayName = "Windows";
                iis.AutomaticAuthentication = true;
            });

            if (InMemory)
            {
                builder.AddTestUsers(Config.GetUsers());
                builder.AddInMemoryIdentityResources(Config.GetIdentityResources());
                builder.AddInMemoryApiResources(Config.GetApiResources());
                builder.AddInMemoryClients(Config.GetClients());
                builder.AddInMemoryPersistedGrants();
            }
            else
            {
                var connectionString = Configuration["connectionStrings:IDPUserDBConnectionString"];
                services.AddDbContext<UserContext>(o => o.UseSqlServer(connectionString));

                var idpDataDBConnectionString = Configuration["connectionStrings:IDPDataDBConnectionString"];

                var migrationsAssembly = typeof(Startup).GetTypeInfo().Assembly.GetName().Name;

                builder.AddUserStore()
                .AddConfigurationStore(options =>
                {
                    options.ConfigureDbContext = dbContextBuilder =>
                    {
                        dbContextBuilder.UseSqlServer(idpDataDBConnectionString, sqlServerOptions => sqlServerOptions.MigrationsAssembly(migrationsAssembly));
                    };
                })
                .AddOperationalStore(options =>
                {
                    options.ConfigureDbContext = dbContextBuilder =>
                    {
                        dbContextBuilder.UseSqlServer(idpDataDBConnectionString, sqlServerOptions => sqlServerOptions.MigrationsAssembly(migrationsAssembly));
                    };
                });
            }

            services.AddAuthentication(options =>
            {
                options.DefaultScheme = IdentityServerConstants.DefaultCookieAuthenticationScheme;
                options.DefaultChallengeScheme = IdentityServerConstants.DefaultCookieAuthenticationScheme;
            }
            ).AddCookie(IdentityServerConstants.DefaultCookieAuthenticationScheme + ".2FA", options =>
              {

              });

            services.AddAuthentication().AddFacebook(options =>
            {
                options.SignInScheme = IdentityServerConstants.ExternalCookieAuthenticationScheme;
                options.AppId = "1570475679676847";
                options.AppSecret = "5b9f4bca5da29e234b706040aca883d3";
            });
        }

        public RsaSecurityKey LoadSigningCredential(string privateSigningKeyPath)
        {
            return SigningKey.LoadPrivateRsaSigningKey(privateSigningKeyPath);
        }

        //Load from here to prevent load balancer issues
        public X509Certificate2 LoadCertificateFromStore()
        {

            string thumbPrint = "AD4AD167DE7171FAA3185480C088C877CD702562";

            using (var store = new X509Store(StoreName.My, StoreLocation.LocalMachine))
            {
                store.Open(OpenFlags.ReadOnly);
                var certCollection = store.Certificates.Find(X509FindType.FindByThumbprint,
                    thumbPrint, true);
                if (certCollection.Count == 0)
                {
                    throw new Exception("The specified certificate wasn't found.");
                }
                return certCollection[0];
            }
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseIdentityServer();

            app.UseMvcWithDefaultRoute();
        }
    }
}
