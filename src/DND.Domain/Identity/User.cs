using Autofac.AspNetCore.Extensions.Data;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace DND.Domain.Identity
{
    //[PersonalData]
    //Deleted when the Areas/Identity/Pages/Account/Manage/DeletePersonalData.cshtml Razor Page calls UserManager.Delete.
    //Included in the downloaded data by the Areas/Identity/Pages/Account/Manage/DownloadPersonalData.cshtml Razor Page.
    //https://korzh.com/blog/add-extra-user-claims-aspnet-core-webapp
    //https://github.com/dotnet/aspnetcore/blob/c925f99cddac0df90ed0bc4a07ecda6b054a0b02/src/Identity/Extensions.Core/src/UserClaimsPrincipalFactory.cs
    public class User : IdentityUser, IEntityTenant
    {
        public override string UserName
        {
            get
            {
                return Id;
            }
            set
            {

            }
        }

        private readonly List<Role> _list = new List<Role>();
        public virtual IReadOnlyList<Role> List => _list.AsReadOnly();

        public string Name { get; set; }

        public virtual ICollection<IdentityUserRole<string>> Roles { get; } = new List<IdentityUserRole<string>>();

        public static User CreateUser(IPasswordHasher<User> passwordHasher, string name, string email, string password)
        {
            var user = new User();
            user.Name = name;
            user.Email = email;
            user.EmailConfirmed = true;
            user.LockoutEnabled = true;
            user.SecurityStamp = "InitialSecurityStamp";
            user.NormalizedUserName = user.UserName.ToUpper();
            user.NormalizedEmail = user.Email.ToUpper();
            user.PasswordHash = passwordHasher.HashPassword(user, password);
            return user;
        }
    }
}
