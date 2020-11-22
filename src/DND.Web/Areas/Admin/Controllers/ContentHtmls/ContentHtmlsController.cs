using AspNetCore.Mvc.Extensions.Authorization;
using AspNetCore.Mvc.Extensions.Context;
using AspNetCore.Mvc.Extensions.Controllers.Mvc;
using DND.Application;
using DND.Application.CMS.ContentHtmls.Dtos;
using DND.Application.CMS.ContentHtmls.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DND.Web.Areas.Admin.Controllers.ContentHtmls
{
    [Authorize(Roles = "admin")]
    [Area("Admin")]
    [Route("admin/cms/content-htmls")]
    public class ContentHtmlsController : MvcControllerEntityAuthorizeBase<ContentHtmlDto, ContentHtmlDto, ContentHtmlDto, ContentHtmlDeleteDto, IContentHtmlApplicationService>
    {
        public ContentHtmlsController(ControllerServicesContext context, IContentHtmlApplicationService service)
             : base(context, true, service)
        {
        }

    }
}
