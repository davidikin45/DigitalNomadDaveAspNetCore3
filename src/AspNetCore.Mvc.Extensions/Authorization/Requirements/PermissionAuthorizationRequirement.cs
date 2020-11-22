using Microsoft.AspNetCore.Authorization.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCore.Mvc.Extensions.Authorization.Requirements
{
    public class PermissionAuthorizationRequirement : ClaimsAuthorizationRequirement
    {
        public PermissionAuthorizationRequirement(IEnumerable<string> allowedPermissions)
            :base("permission", allowedPermissions)
        {

        }
    }
}
