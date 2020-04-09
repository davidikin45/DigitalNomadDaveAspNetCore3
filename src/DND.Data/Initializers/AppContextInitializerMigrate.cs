using AspNetCore.Mvc.Extensions.Data.Initializers;

namespace DND.Data.Initializers
{
    public class AppContextInitializerMigrate : ContextInitializerMigrate<AppContext>
    {
        public override void Seed(AppContext context, string tenantId)
        {
            context.Seed();
        }
    }
}
