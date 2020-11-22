using AspNetCore.Testing.Helpers;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Reflection;
using EntityFrameworkCore.Initialization;
using EntityFrameworkCore.Initialization.NoSql;
using AspNetCore.Mvc.Extensions;
using System.Security.Claims;

namespace AspNetCore.Testing.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection ConfigureRazorViewEngineForTestServer(this IServiceCollection services, Assembly assembly, string netVersion)
        {
            return services;

            //https://github.com/aspnet/Hosting/issues/954
            //.NET Core 2.2
            //return services.Configure<RazorViewEngineOptions>(options =>
            //{
            //    var previous = options.CompilationCallback;
            //    options.CompilationCallback = (context) =>
            //    {
            //        previous?.Invoke(context);

            //        var assemblies = new List<PortableExecutableReference>();
            //        foreach (var x in assembly.GetReferencedAssemblies())
            //        {
            //            var path = Assembly.Load(x).Location;
            //            var refAssembly = MetadataReference.CreateFromFile(path);
            //            assemblies.Add(refAssembly);
            //        }

            //        assemblies.Add(MetadataReference.CreateFromFile(Assembly.Load(new AssemblyName("Microsoft.AspNetCore.Html.Abstractions")).Location));
            //        assemblies.Add(MetadataReference.CreateFromFile(Assembly.Load(new AssemblyName("Microsoft.AspNetCore.Http.Features")).Location));
            //        assemblies.Add(MetadataReference.CreateFromFile(Assembly.Load(new AssemblyName("Microsoft.Extensions.Primitives")).Location));
            //        assemblies.Add(MetadataReference.CreateFromFile(Assembly.LoadFrom(@"C:\Program Files (x86)\Reference Assemblies\Microsoft\Framework\.NETFramework\" + netVersion + @"\Facades\netstandard.dll").Location));

            //        context.Compilation = context.Compilation.AddReferences(assemblies);
            //    };
            //});
        }

        public static IServiceCollection RemoveDbContext<TDbContext>(this IServiceCollection services)
            where TDbContext : DbContext
        {
            var descriptor = services.SingleOrDefault(d => d.ServiceType == typeof(DbContextOptions<TDbContext>));

            if (descriptor != null)
            {
                services.Remove(descriptor);
            }

            return services;
        }

        public static IServiceCollection RemoveDbContextNoSql<TContext>(this IServiceCollection services)
        where TContext : DbContextNoSql
        {
            var descriptor = services.SingleOrDefault(d => d.ServiceType == typeof(TContext));

            if (descriptor != null)
            {
                services.Remove(descriptor);
            }

            return services;
        }

        public static IServiceCollection AddTestAuthentication(this IServiceCollection services, string role, params Claim[] claims)
        {
            services.AddAuthentication(options => {
                options.DefaultScheme = "Test";
                options.DefaultAuthenticateScheme = "Test";
                options.DefaultChallengeScheme = "Test";
                options.DefaultForbidScheme = "Test";
            })
                   .AddScheme<TestAuthenticationSchemeOptions, TestAuthenticationHandler>(
                       "Test", options => {
                           options.Role = role;
                           options.Claims = claims;
                       });

            return services;
        }
    }
}
