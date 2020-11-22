using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace AspNetCore.Testing.Helpers
{
    public class TestAuthenticationSchemeOptions : AuthenticationSchemeOptions
    {
        public string Role { get; set; }
        public Claim[] Claims { get; set; }
    }

    public class TestAuthenticationHandler : AuthenticationHandler<TestAuthenticationSchemeOptions>
    {
        public TestAuthenticationHandler(IOptionsMonitor<TestAuthenticationSchemeOptions> options,
            ILoggerFactory logger, UrlEncoder encoder, ISystemClock clock)
            : base(options, logger, encoder, clock)
        {
        }

        protected override Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            var claims = new[]
            {
                new Claim(ClaimTypes.Name, "Test user"),
                new Claim(ClaimTypes.Role, Options.Role),
            };

            var finalClaims = new List<Claim>();
            foreach (var claim in claims)
            {
                finalClaims.Add(claim);
            }

            if(Options.Claims != null)
            {
                foreach (var claim in Options.Claims)
                {
                    finalClaims.Add(claim);
                }
            }

            var identity = new ClaimsIdentity(finalClaims, "Test");
            var principal = new ClaimsPrincipal(identity);
            var ticket = new AuthenticationTicket(principal, "Test");

            var result = AuthenticateResult.Success(ticket);

            return Task.FromResult(result);
        }
    }
}
