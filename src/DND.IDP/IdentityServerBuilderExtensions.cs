using DND.IDP.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DND.IDP
{
    public static class IdentityServerBuilderExtensions
    {
        public static IIdentityServerBuilder AddUserStore(this IIdentityServerBuilder builder)
        {
            builder.Services.AddScoped<IUserRepository, UserRepository>();
            builder.AddProfileService<UserProfileService>();
            return builder;
        }
    }
}
