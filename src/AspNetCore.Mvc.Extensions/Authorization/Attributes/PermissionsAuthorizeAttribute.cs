﻿namespace AspNetCore.Mvc.Extensions.Authorization.Attributes
{
    public class PermissionsAuthorizeAttribute : ClaimAuthorizeAttribute
    {
        public PermissionsAuthorizeAttribute(params string[] allowedPermissions) : base("permissions", allowedPermissions)
        {

        }
    }
}
