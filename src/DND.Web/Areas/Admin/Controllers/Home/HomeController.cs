using AspNetCore.Mvc.Extensions.Context;
using AspNetCore.Mvc.Extensions.Controllers.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace DND.Web.Areas.Admin.Controllers.Home
{
    [Area("Admin")]
    [Route("admin")]
    public class HomeController : MvcControllerAdminAuthorizeBase
    {

        public HomeController(ControllerServicesContext context)
             : base(context)
        {
        }


        public override ActionResult ClearCache()
        {
            return base.ClearCache();
        }

    }
}
