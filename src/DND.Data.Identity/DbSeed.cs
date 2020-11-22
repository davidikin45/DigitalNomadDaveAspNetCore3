using AspNetCore.Mvc.Extensions.Data;
using DND.Domain.Identity;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace DND.Data.Identity
{
    public class DbSeed : DbSeedIdentity<User>
    {
        private readonly IPasswordHasher<User> _passwordHasher;
        public DbSeed(IPasswordHasher<User> passwordHasher)
        {
            _passwordHasher = passwordHasher;
        }

        public override IEnumerable<SeedRole> GetRolePermissions(DbContextIdentityBase<User> context)
        {
            return new List<SeedRole>()
            {
               new SeedRole(Role.admin.ToString(), "permission1", "permission2")
            };
        }

        public override IEnumerable<SeedUser> GetUserRoles(DbContextIdentityBase<User> context)
        {
            return new List<SeedUser>()
            {
                 new SeedUser(User.CreateUser(_passwordHasher, "admin", "admin@admin.com", "password"), true, Role.admin.ToString())
            };
        }
    }
}
