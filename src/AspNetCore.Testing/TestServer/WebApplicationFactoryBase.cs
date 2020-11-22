using AngleSharp;
using AngleSharp.Html.Dom;
using AngleSharp.Io;
using AspNetCore.Mvc.Extensions.Routing;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Net.Http.Headers;
using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace AspNetCore.Testing.TestServer
{
    //https://docs.microsoft.com/en-us/aspnet/core/test/middleware?view=aspnetcore-3.1
    //https://docs.microsoft.com/en-us/aspnet/core/test/integration-tests?view=aspnetcore-2.2
    //https://github.com/dotnet/aspnetcore/blob/f7f80fdbaaa0283e8e2e89ceed7abf7fe413b17c/src/Mvc/Mvc.Testing/src/WebApplicationFactory.cs
    public abstract class WebApplicationFactoryBase<TEntryPoint>
    : WebApplicationFactory<TEntryPoint>
        where TEntryPoint : class
    {
        public string Environment { get; }

        public static readonly string AntiForgeryFieldName = "__AFTField";
        public static readonly string AntiForgeryCookieName = "AFTCookie";

        public WebApplicationFactoryBase(string environment = "Development")
        {
            //By default runs on Development environment
            Environment = environment;
        }

        public IFeatureCollection ServerFeatures => Server.Host.ServerFeatures;

        public RouteInfo GetAllRoutes()
        {
            return RouteHelper.GetAllRoutes(Services.GetRequiredService<IActionDescriptorCollectionProvider>());
        }

        protected override IHostBuilder CreateHostBuilder()
        {
            return base.CreateHostBuilder();
            //The default implementation of this method looks for a public static IHostBuilder
            //CreateHostBuilder(string[] args) method defined on the entry point of the
            //assembly of TEntryPoint and invokes it passing an empty string array as arguments.
            //Sets Environment to Development
        }

        //.NET Core 2
        protected override IWebHostBuilder CreateWebHostBuilder()
        {
            return base.CreateWebHostBuilder();
            //The default implementation of this method looks for a public static IWebHostBuilder
            //CreateWebHostBuilder(string[] args) method defined on the entry point of the
            //assembly of TEntryPoint and invokes it passing an empty string array as arguments.
            //Sets Environment to Development
        }

        //Environment has been set to Development
        //ContentRoot set
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.UseEnvironment(Environment);
            //builder.UseContentRoot(GetContentRoot());

            //For Web Host Before Startup.ConfigureServices
            //For Generic Host After Startup.ConfigureServices
            builder
            .ConfigureServices(services =>
             {
                 ConfigureServices(services);
             })
            //After Startup.ConfigureServices
            .ConfigureTestServices(services =>
            {
                ConfigureTestServices(services);
            });
        }

        public virtual void ConfigureServices(IServiceCollection services)
        {
            services.AddAntiforgery(options =>
            {
                options.Cookie.Name = AntiForgeryCookieName;
                options.FormFieldName = AntiForgeryFieldName;
            });
        }

        //Inject mock services
        public abstract void ConfigureTestServices(IServiceCollection services);

        protected override IHost CreateHost(IHostBuilder builder)
        {
            var host = builder.Build();
            InitializeHost(host);
            host.Start();
            return host;
        }

        protected override Microsoft.AspNetCore.TestHost.TestServer CreateServer(IWebHostBuilder builder)
        {
            //new TestServer(builder)
            var server =  base.CreateServer(builder);
            InitializeWebHost(server.Host);
            return server;
        }

        //1. Environment Variable ASPNETCORE_TEST_CONTENTROOT_DND_WEB
        //2. If a direct reference has been added Microsoft.AspNetCore.Mvc.Testing from xUnit Integration Test project
        //3. IntegrationTests > test > Solution > WebApp
        //4. IntegrationTests > test > Solution > src > WebApp
        public virtual string GetContentRoot()
        {
            //1. Environment Variable ASPNETCORE_TEST_CONTENTROOT_DND_WEB
            var contentRoot = GetContentRootFromConfig();
            if (contentRoot != null)
                return contentRoot;

            //2. If a direct reference has been added Microsoft.AspNetCore.Mvc.Testing from xUnit Integration Test project
            contentRoot = GetContentRootFromAttribute();
            if (contentRoot != null && Directory.Exists(contentRoot))
                return contentRoot;

            //3. IntegrationTests > test > Solution > WebApp
            contentRoot = GetSolutionRelativeContentRoot(typeof(TEntryPoint).Assembly.GetName().Name);
            if (contentRoot != null && Directory.Exists(contentRoot))
                return contentRoot;

            //4. IntegrationTests > test > Solution > src > WebApp
            contentRoot = GetSolutionRelativeContentRoot($@"src\{typeof(TEntryPoint).Assembly.GetName().Name}");
            if (contentRoot != null && Directory.Exists(contentRoot))
                return contentRoot;

            return null;
        }

        public string GetBinRelativeContentRoot(string binRelativePath)
        {
            var testProjectPath = AppContext.BaseDirectory;
            var contentRoot = Path.GetFullPath(Path.Combine(testProjectPath, binRelativePath));
            return contentRoot;
        }

        public string GetContentRootFromConfig()
        {
            var config = new ConfigurationBuilder()
                  .AddEnvironmentVariables("ASPNETCORE_");

            var configEnvironment = config.Build();

            var assemblyName = typeof(TEntryPoint).Assembly.GetName().Name;
            var settingSuffix = assemblyName.ToUpperInvariant().Replace(".", "_");
            var settingName = $"TEST_CONTENTROOT_{settingSuffix}";

            return configEnvironment[settingName];
        }

        public string GetContentRootFromAttribute()
        {
            var metadataAttributes = GetContentRootMetadataAttributes();

            string contentRoot = null;
            for (var i = 0; i < metadataAttributes.Length; i++)
            {
                var contentRootAttribute = metadataAttributes[i];
                var contentRootCandidate = Path.Combine(
                    AppContext.BaseDirectory,
                    contentRootAttribute.ContentRootPath);

                var contentRootMarker = Path.Combine(
                    contentRootCandidate,
                    Path.GetFileName(contentRootAttribute.ContentRootTest));

                if (File.Exists(contentRootMarker))
                {
                    contentRoot = contentRootCandidate;
                    break;
                }
            }

            return contentRoot;
        }

        private WebApplicationFactoryContentRootAttribute[] GetContentRootMetadataAttributes()
        {
            return GetContentRootMetadataAttributes(
                 typeof(TEntryPoint).Assembly.FullName,
                typeof(TEntryPoint).Assembly.GetName().Name);
        }

        private WebApplicationFactoryContentRootAttribute[] GetContentRootMetadataAttributes(
            string tEntryPointAssemblyFullName,
            string tEntryPointAssemblyName)
        {
            var testAssembly = GetTestAssemblies();
            var metadataAttributes = testAssembly
                .SelectMany(a => a.GetCustomAttributes(typeof(WebApplicationFactoryContentRootAttribute), true).Select(at => (WebApplicationFactoryContentRootAttribute)at))
                .Where(a => string.Equals(a.Key, tEntryPointAssemblyFullName, StringComparison.OrdinalIgnoreCase) ||
                            string.Equals(a.Key, tEntryPointAssemblyName, StringComparison.OrdinalIgnoreCase))
                .OrderBy(a => a.Priority)
                .ToArray();

            return metadataAttributes;
        }

        public string GetSolutionRelativeContentRoot(
           string solutionRelativePath,
           string solutionName = "*.sln")
        {
            return GetSolutionRelativeContentRoot(solutionRelativePath, AppContext.BaseDirectory, solutionName);
        }

        public string GetSolutionRelativeContentRoot(
            string solutionRelativePath,
            string applicationBasePath,
            string solutionName = "*.sln")
        {
            if (solutionRelativePath == null)
            {
                throw new ArgumentNullException(nameof(solutionRelativePath));
            }

            if (applicationBasePath == null)
            {
                throw new ArgumentNullException(nameof(applicationBasePath));
            }

            var directoryInfo = new DirectoryInfo(applicationBasePath);
            do
            {
                var solutionPath = Directory.EnumerateFiles(directoryInfo.FullName, solutionName).FirstOrDefault();
                if (solutionPath != null)
                {
                    return Path.GetFullPath(Path.Combine(directoryInfo.FullName, solutionRelativePath));
                }

                directoryInfo = directoryInfo.Parent;
            }
            while (directoryInfo.Parent != null);

            return null;
        }

        public virtual void InitializeHost(IHost host)
        {
   
        }

        public virtual void InitializeWebHost(IWebHost host)
        {
            //https://github.com/dotnet/aspnetcore/blob/8a81194f372fa6fe63ded2d932d379955854d080/src/Hosting/TestHost/src/TestServer.cs
            //TestServer constructor calls var host = builder.UseServer(this) which overrides the IServer decorator for TaskExecutingServer

            //Throws original exception rather than AggregateException
            //host.InitAsync().GetAwaiter().GetResult();
        }

        public HttpClient CreateClientToTestSecureEndpoint()
        {
            return CreateClient(new WebApplicationFactoryClientOptions
            {
                AllowAutoRedirect = false
            });
        }

        public async Task<(string fieldValue, string cookieValue)> ExtractAntiForgeryValues(HttpResponseMessage response)
        {
            return (ExtractAntiForgeryToken(await response.Content.ReadAsStringAsync()),
                                            ExtractAntiForgeryCookieValueFrom(response));
        }

        private string ExtractAntiForgeryCookieValueFrom(HttpResponseMessage response)
        {
            string antiForgeryCookie =
                        response.Headers
                                .GetValues("Set-Cookie")
                                .FirstOrDefault(x => x.Contains(AntiForgeryCookieName));

            if (antiForgeryCookie is null)
            {
                throw new ArgumentException(
                    $"Cookie '{AntiForgeryCookieName}' not found in HTTP response",
                    nameof(response));
            }

            string antiForgeryCookieValue =
                SetCookieHeaderValue.Parse(antiForgeryCookie).Value.ToString();

            return antiForgeryCookieValue;
        }

        private string ExtractAntiForgeryToken(string htmlBody)
        {
            var requestVerificationTokenMatch =
                Regex.Match(htmlBody, $@"\<input name=""{AntiForgeryFieldName}"" type=""hidden"" value=""([^""]+)"" \/\>");

            if (requestVerificationTokenMatch.Success)
            {
                return requestVerificationTokenMatch.Groups[1].Captures[0].Value;
            }

            throw new ArgumentException($"Anti forgery token '{AntiForgeryFieldName}' not found in HTML", nameof(htmlBody));
        }

        public static async Task<IHtmlDocument> GetDocumentAsync(HttpResponseMessage response)
        {
            var content = await response.Content.ReadAsStringAsync();
            var document = await BrowsingContext.New()
                .OpenAsync(ResponseFactory, CancellationToken.None);
            return (IHtmlDocument)document;

            void ResponseFactory(VirtualResponse htmlResponse)
            {
                htmlResponse
                    .Address(response.RequestMessage.RequestUri)
                    .Status(response.StatusCode);

                MapHeaders(response.Headers);
                MapHeaders(response.Content.Headers);

                htmlResponse.Content(content);

                void MapHeaders(HttpHeaders headers)
                {
                    foreach (var header in headers)
                    {
                        foreach (var value in header.Value)
                        {
                            htmlResponse.Header(header.Key, value);
                        }
                    }
                }
            }
        }

    }
}
