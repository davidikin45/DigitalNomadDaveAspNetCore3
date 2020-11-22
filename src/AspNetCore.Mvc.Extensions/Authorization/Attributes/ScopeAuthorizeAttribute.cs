using IdentityModel;

namespace AspNetCore.Mvc.Extensions.Authorization.Attributes
{
    public class ScopeAuthorizeAttribute : ClaimAuthorizeAttribute
    {
        public ScopeAuthorizeAttribute(params string[] allowedScopes) : base(JwtClaimTypes.Scope, allowedScopes)
        {

        }
    }
}
