using AspNetCore.Mvc.Extensions.Authorization.Attributes;
using AspNetCore.Mvc.Extensions.Authorization.Requirements;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using System.Collections.Generic;

namespace AspNetCore.Mvc.Extensions.Authorization
{
    public static class AuthorizationPolicyBuilderExtensions
    {
        public static AuthorizationPolicyBuilder RequireScope(this AuthorizationPolicyBuilder builder, params string[] scopes)
        {
            //https://leastprivilege.com/2020/07/06/flexible-access-token-validation-in-asp-net-core/
            var c = new ClaimsAuthorizationRequirement("scope", scopes); //IdentityModel.AspNetCore.AccessTokenValidation services.AddScopeTransformation()

            builder.Requirements.Add(new ScopeAuthorizationRequirement(scopes));
            return builder;
        }

        public static AuthorizationPolicyBuilder RequireScope(this AuthorizationPolicyBuilder builder, IEnumerable<string> scopes)
        {
            //https://leastprivilege.com/2020/07/06/flexible-access-token-validation-in-asp-net-core/
            var c = new ClaimsAuthorizationRequirement("scope", scopes); //IdentityModel.AspNetCore.AccessTokenValidation services.AddScopeTransformation()

            builder.Requirements.Add(new ScopeAuthorizationRequirement(scopes));
            return builder;
        }

        public static AuthorizationPolicyBuilder RequirePermissions(this AuthorizationPolicyBuilder builder, params string[] permissions)
        {
            builder.Requirements.Add(new PermissionsAuthorizationRequirement(permissions));
            return builder;
        }

        public static AuthorizationPolicyBuilder RequirePermissions(this AuthorizationPolicyBuilder builder, IEnumerable<string> permissions)
        {
            builder.Requirements.Add(new PermissionsAuthorizationRequirement(permissions));
            return builder;
        }

        public static AuthorizationPolicyBuilder AllowAnonymous(this AuthorizationPolicyBuilder builder)
        {
            builder.Requirements.Add(new AnonymousAuthorizationRequirement());
            return builder;
        }
    }
}
