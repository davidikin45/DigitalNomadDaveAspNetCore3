using AspNetCore.Mvc.Extensions.Validation.Settings;
using System.Security.Claims;

namespace AspNetCore.Mvc.Extensions.Settings
{
    public class TokenSettings : IValidateSettings
    {
        //OpenID Connect
        public string Authority { get; set; }
        public string ApiName { get; set; }
        public string ApiSecret { get; set; } //Reference Tokens only

        public string LocalIssuer { get; set; }
        public string ExternalIssuers { get; set; }
        public string Audiences { get; set; }

        public int ExpiryMinutes { get; set; } = 60;

        public string Key { get; set; }

        public string PublicCertificatePath { get; set; }
        public string PrivateCertificatePath { get; set; }
        public string PrivateCertificatePasword { get; set; }

        public string PublicKeyPath { get; set; }
        public string PrivateKeyPath { get; set; }

        public string NameClaimType = ClaimTypes.Name;
        public string RoleClaimType = ClaimTypes.Role;
    }
}
