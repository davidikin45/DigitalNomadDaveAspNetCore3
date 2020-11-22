using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.Mvc.Extensions.Authorization.Requirements
{
    //https://auth0.com/docs/quickstart/backend/aspnet-core-webapi/01-authorization
    //https://stackoverflow.com/questions/54852094/asp-net-core-requireclaim-scope-with-multiple-scopes
    public class ScopeAuthorizationRequirement : IAuthorizationRequirement
    {
        public IEnumerable<string> AllowedScopes { get; }

        public ScopeAuthorizationRequirement(IEnumerable<string> allowedScopes)
        {
            AllowedScopes = allowedScopes;
        }

        public override string ToString()
        {
            var value = (AllowedScopes == null || !AllowedScopes.Any())
                ? string.Empty
                : $" and Claim.Value is one of the following values: ({string.Join("|", AllowedScopes)})";

            return $"{nameof(ScopeAuthorizationRequirement)}:Claim.Type=scope{value}";
        }
    }

    public class ScopeAuthorizationHandler : AuthorizationHandler<ScopeAuthorizationRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, ScopeAuthorizationRequirement requirement)
        {
            if (context.User != null && context.User.Claims.Any(c => string.Equals(c.Type, "scope", StringComparison.OrdinalIgnoreCase)))
            {
                var found = false;
                if (requirement.AllowedScopes == null || !requirement.AllowedScopes.Any())
                {
                    found = context.User.Claims.Any(c => string.Equals(c.Type, "scope", StringComparison.OrdinalIgnoreCase));
                }
                else
                {
                    found = context.User.Claims.Where(c => string.Equals(c.Type, "scope", StringComparison.OrdinalIgnoreCase)).SelectMany(c => c.Value.Split(' ')).Any(s => requirement.AllowedScopes.Contains(s, StringComparer.Ordinal));
                }

                if (found)
                {
                    context.Succeed(requirement);
                }
            }
            return Task.CompletedTask;
        }
    }
}
