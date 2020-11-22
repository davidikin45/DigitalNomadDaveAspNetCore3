using AspNetCore.Mvc.Extensions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Security.Claims;

namespace AspNetCore.Testing.Extensions
{
    public static class WebHostBuilderExtensions
    {
        public static IWebHostBuilder WithUserInRole(this IWebHostBuilder builder, string role, params Claim[] claims)
        {
            return builder.ConfigureTestServices(services =>
            {
                services.AddTestAuthentication(role, claims);
            });
        }

        public static IWebHostBuilder WithDb<TDbContext>(this IWebHostBuilder builder, Action<IServiceProvider, TDbContext> configure)
            where TDbContext : class
        {
            return builder.ConfigureTestServices(services =>
            {
                services.AddDbStartupTask(configure);
            });
        }
    }
}
