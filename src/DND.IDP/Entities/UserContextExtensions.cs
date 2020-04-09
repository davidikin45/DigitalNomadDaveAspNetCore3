using System.Collections.Generic;
using System.Linq;

namespace DND.IDP.Entities
{
    public static class UserContextExtensions
    {
        public static void EnsureSeedDataForContext(this UserContext context)
        {
            // Add 2 demo users if there aren't any users yet
            if (context.Users.Any())
            {
                return;
            }

            // init users
            var users = new List<User>()
            {
                new User()
                {
                    SubjectId = "d860efca-22d9-47fd-8249-791ba61b07c7",
                    Username = "Frank",
                    Password = "password",
                    IsActive = true,
                    Claims = {
                         new UserClaim("role", "FreeUser"),
                         new UserClaim("given_name", "Frank"),
                         new UserClaim("family_name", "Underwood"),
                         new UserClaim("address", "Main Road 1"),
                         new UserClaim("subscriptionlevel", "FreeUser"),
                         new UserClaim("country", "nl")
                    }
                },
                new User()
                {
                    SubjectId = "b7539694-97e7-4dfe-84da-b4256e1ff5c7",
                    Username = "Claire",
                    Password = "password",
                    IsActive = true,
                    Claims = {
                         new UserClaim("role", "PayingUser"),
                         new UserClaim("given_name", "Claire"),
                         new UserClaim("family_name", "Underwood"),
                         new UserClaim("address", "Big Street 2"),
                         new UserClaim("subscriptionlevel", "PayingUser"),
                         new UserClaim("country", "be")                    
                }
                }
            };

            context.Users.AddRange(users);
            context.SaveChanges();
        }
    }
}
