using AspNetCore.Mvc.Extensions.Validation.Settings;
using System.Security.Claims;

namespace AspNetCore.Mvc.Extensions.Settings
{
    public class OpenIdConnectSettings : IValidateSettings
    {
        //OpenID Connect
        public string Authority { get; set; }
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }

        public string[] IdentityScopes { get; set; } = { };
        public string[] ApiScopes { get; set; } = { };
        public string[] ClaimMappings { get; set; } = { };

        public bool RefreshTokens { get; set; }

        public string NameClaimType = ClaimTypes.Name;
        public string RoleClaimType = ClaimTypes.Role;
    }
}
