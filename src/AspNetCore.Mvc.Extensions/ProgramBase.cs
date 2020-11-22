using Autofac.AspNetCore.Extensions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Events;
using Serilog.Exceptions;
using Serilog.Formatting.Compact;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.Mvc.Extensions
{
    //Class library is shared compiled code.
    //Shared project is shared source code.
    public abstract class ProgramBase<TStartup> where TStartup : class
    {
        public static async Task<int> RunApp(string[] args)
        {
            
            Activity.DefaultIdFormat = ActivityIdFormat.W3C; //traceId for logging, gets forwarded automatically when using httpclient/gRPC.

            //Serilog will use Log.Logger by default when using UseSerilog()
            //var name = Assembly.GetExecutingAssembly().GetName();
            var name = typeof(TStartup).Assembly.GetName();
            Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Information()
            .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
            .MinimumLevel.Override("Microsoft.Hosting.Lifetime", LogEventLevel.Information)
            .Enrich.FromLogContext() //using (LogContext.PushProperty("A", 1))
            .Enrich.WithExceptionDetails() //logger.Error incudes Include exception.data for saving exception extra data.
            .Enrich.WithMachineName() //Environment.MachineName
            .Enrich.WithProperty("Assembly", $"{name.Name}")
            .Enrich.WithProperty("Version", $"{name.Version}")
            //.ReadFrom.Configuration(
            //    new ConfigurationBuilder()
            //    .SetBasePath(Directory.GetCurrentDirectory())
            //    .AddJsonFile("hostsettings.json", optional: true)
            //    .AddEnvironmentVariables()
            //    .AddCommandLine(args ?? new string[0])
            //    .Build()
            // )
            .WriteTo.Console(outputTemplate: "[{Timestamp:HH:mm:ss.fff}] {Level:u3} - {Message:lj}{NewLine}{Exception}")
            .WriteTo.Debug(outputTemplate: "[{Timestamp:HH:mm:ss.fff}] {Level:u3} - {Message:lj}{NewLine}{Exception}")
            //.WriteTo.File(@"logs\log.txt", rollingInterval: RollingInterval.Day, outputTemplate: "[{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz}] {Level:u3} - {Message:lj}{NewLine}{Exception}")
            .WriteTo.File(new CompactJsonFormatter(), @"logs\log.txt", rollingInterval: RollingInterval.Day) // json message template 31 days
            .CreateLogger();

            try
            {
                Log.Information("Getting the motors running...");

                var host = CreateHostBuilder(args).Build();

                //.NET Core 2.2 
                //var host = CreateWebHostBuilder(args).Build();

                //https://andrewlock.net/running-async-tasks-on-app-startup-in-asp-net-core-part-2/
                //Even though the tasks run after the IConfiguration and DI container configuration has completed, they run before the IStartupFilters have run and the middleware pipeline has been configured.
                //await host.InitAsync();

                //AppStartup.Configure will be called here
                await host.RunAsync();

                return 0;
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Host terminated unexpectedly");
                return 1;
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }

        //.NET Core 3.0
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureHostConfiguration(config =>
                {
                    config.Sources.Skip(2).ToList().ForEach(x => config.Sources.Remove(x));
                    config
                    .AddInMemoryCollection(new Dictionary<string, string> { { HostDefaults.EnvironmentKey, Environments.Development } })
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("hostsettings.json", optional: true)
                    .AddEnvironmentVariables(prefix: "DOTNET_")
                    .AddCommandLine(args ?? new string[0]);
                    // config.AddEnvironmentVariables(prefix: "ASPNETCORE_");
                })
                .ConfigureAppConfiguration((context, config) =>
                {
                    // JSON files, User secrets, environment variables and command line arguments
                })
                .ConfigureServices((hostContext, services) =>
                {
                    //services.AddHostedService<ServiceA>();
                })
               //https://nblumhardt.com/2019/10/serilog-in-aspnetcore-3/?fbclid=IwAR2SZoIsGjtTfwCd5bEG9n0mpnbo-3ERVCYZk6snBDnbIHwKC5dYbIoj_vY
               .UseSerilog()
               .UseAutofacMultitenant((context, options) =>
               {
                   options.ValidateOnBuild = false;
                   options.MapDefaultTenantToAllRootAndSubDomains();
                   options.AddTenantsFromConfig(context.Configuration);
                   options.ConfigureTenants(builder =>
                   {
                       builder.MapToTenantIdSubDomain();
                   });
               })
               //.UseDefaultServiceProvider((context, options) => {
               //    options.ValidateScopes = context.HostingEnvironment.IsDevelopment();
               //    options.ValidateOnBuild = context.HostingEnvironment.IsDevelopment();
               //})
               //https://www.hanselman.com/blog/dotnetNewWorkerWindowsServicesOrLinuxSystemdServicesInNETCore.aspx?fbclid=IwAR0ldO7MnDkgjK-dajY-dSEGt8aHvS70EC8Rvbl8RkPMXC1cJLIdbthQIME
               .UseWindowsService()
               //Only required if the service responds to requests.
               .ConfigureWebHostDefaults(webBuilder =>
               {
                   webBuilder.ConfigureWebHost((webBuilder) => ConfigureWebHost(webBuilder, args));
               });

        //.NET Core 2.2 
        //public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
        //    WebHost.CreateDefaultBuilder(args)
        //    .UseAutofacMultitenant((context,options) => {
        //        options.MapDefaultTenantToAllRootDomains();
        //        options.AddTenantsFromConfig(context.Configuration);
        //        options.ConfigureTenants(builder => {
        //            builder.MapToTenantIdSubDomain();
        //        });
        //    })

        //    /.UseDefaultServiceProvider((context, options) => {
        //    //    options.ValidateScopes = context.HostingEnvironment.IsDevelopment();
        //    //    options.ValidateOnBuild = context.HostingEnvironment.IsDevelopment();
        //    //})

        //    .ConfigureAppConfiguration((context, config) =>
        //        {

        //            // JSON files, User secrets, environment variables and command line arguments
        //        })
        //    .ConfigureServices((hostContext, services) =>
        //    {
        //        //services.AddHostedService<ServiceA>();
        //    })
        //    .ConfigureWebHost(ConfigureWebHost);

        private static void ConfigureWebHost(IWebHostBuilder webBuilder, string[] args)
        {
            webBuilder
            .CaptureStartupErrors(true) // These two settings allow an error page to be shown rather than throwing exception on startup in kestral. IIS has a StartupHook file which enables detailed errors in Development regardless of these settings. Hosted Services still execute when an exception is thrown!
            .UseSetting(WebHostDefaults.DetailedErrorsKey, new ConfigurationBuilder().AddInMemoryCollection(new Dictionary<string, string> { { HostDefaults.EnvironmentKey, Environments.Development } }).AddEnvironmentVariables("ASPNETCORE_").AddCommandLine(args ?? new string[0]).Build()["Environment"].Equals("Development", StringComparison.OrdinalIgnoreCase) ? "true" : "false")
            .UseShutdownTimeout(TimeSpan.FromSeconds(20))
            .ConfigureKestrel((context, options) =>
            {
                options.AllowSynchronousIO = true;
                options.AddServerHeader = false;
            })
            //https://docs.microsoft.com/en-us/aspnet/core/fundamentals/host/generic-host?view=aspnetcore-3.1
            //.UseConfiguration( //Host Config
            //new ConfigurationBuilder()
            //.AddInMemoryCollection(new Dictionary<string, string> { { HostDefaults.EnvironmentKey, Environments.Development } })
            //.SetBasePath(Directory.GetCurrentDirectory())
            //.AddJsonFile("hostsettings.json", optional: true)
            //.AddEnvironmentVariables(prefix: "ASPNETCORE_")
            //.AddCommandLine(args ?? new string[0])
            //.Build()
            //)
            .UseIISIntegration()
            .UseAzureKeyVault()
            .ConfigureAppConfiguration((hostingContext, config) =>
            {

            })
            .ConfigureServices(services =>
            {
                services.AddHttpContextAccessor();
            })
            .LogApplicationParts()
            .LogViewLocations()
            .UseStartupTasks(false)
            //https://docs.microsoft.com/en-us/aspnet/core/razor-pages/ui-class?view=aspnetcore-3.0&tabs=visual-studio
            //When the app is published, the companion assets from all referenced projects and packages are copied into the wwwroot folder of the published app under _content/{LIBRARY NAME}/.
            //When running the consuming app from build output (dotnet run), static web assets are enabled by default in the Development environment. To support assets in other environments when running from build output, call UseStaticWebAssets on the host builder in Program.cs:
            //calling UseStaticWebAssets isn't required when running an app from published output (dotnet publish).
            .UseStaticWebAssets() //wwwroot from class library https://docs.microsoft.com/en-us/aspnet/core/razor-pages/ui-class?view=aspnetcore-3.0&tabs=visual-studio

            //.NET Core 2.2 
            //https://nblumhardt.com/2019/10/serilog-in-aspnetcore-3/?fbclid=IwAR2SZoIsGjtTfwCd5bEG9n0mpnbo-3ERVCYZk6snBDnbIHwKC5dYbIoj_vY
            //.UseSerilog()
            //UseAzureAppServices() Azure Logging
            .UseStartup<TStartup>();
        }
    }
}
