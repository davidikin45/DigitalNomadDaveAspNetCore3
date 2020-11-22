using Microsoft.AspNetCore.Authorization.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCore.Mvc.Extensions.Authorization.Requirements
{
    public class PermissionsAuthorizationRequirement : ClaimsAuthorizationRequirement
    {
        public PermissionsAuthorizationRequirement(IEnumerable<string> allowedPermissions)
            :base("permissions", allowedPermissions)
        {

        }
    }
}
