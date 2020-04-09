using AspNetCore.Mvc.Extensions.Controllers.Mvc;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace DND.Web.Areas.Admin.Controllers.Home
{
    [Area("Admin")]
    public class FileManagerController : MvcControllerAdminFileManagerAuthorizeBase
    {
        public FileManagerController(IWebHostEnvironment hostingEnvironment)
            :base(hostingEnvironment)
        {

        }

    }
}
