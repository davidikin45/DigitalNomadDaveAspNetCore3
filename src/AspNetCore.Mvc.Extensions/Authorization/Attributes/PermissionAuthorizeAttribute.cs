namespace AspNetCore.Mvc.Extensions.Authorization.Attributes
{
    public class PermissionAuthorizeAttribute : ClaimAuthorizeAttribute
    {
        public PermissionAuthorizeAttribute(params string[] allowedValues) : base("permission", allowedValues)
        {

        }
    }
}
