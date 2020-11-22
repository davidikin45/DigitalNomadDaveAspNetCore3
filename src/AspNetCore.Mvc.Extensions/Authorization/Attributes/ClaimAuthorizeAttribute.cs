using Microsoft.AspNetCore.Authorization;
using System;

namespace AspNetCore.Mvc.Extensions.Authorization.Attributes
{
    public class ClaimAuthorizeAttribute : AuthorizeAttribute
    {
        public ClaimAuthorizeAttribute(string claimType, params string[] allowedValues)
        {
            Policy = $"{claimType}${string.Join(",", allowedValues ?? Array.Empty<string>())}";
        }
    }
}
