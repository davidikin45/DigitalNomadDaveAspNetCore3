using AspNetCore.Mvc.Extensions.Authorization;
using AspNetCore.Mvc.Extensions.Context;
using AspNetCore.Mvc.Extensions.Controllers.Mvc;
using AutoMapper;
using DND.Application;
using DND.Application.CMS.ContentTexts.Dtos;
using DND.Application.CMS.ContentTexts.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DND.Web.Areas.Admin.Controllers.ContentTexts
{
    [Authorize(Roles = "admin")]
    [Area("Admin")]
    [Route("admin/cms/content-texts")]
    public class ContentTextsController : MvcControllerEntityAuthorizeBase<ContentTextDto, ContentTextDto, ContentTextDto, ContentTextDeleteDto, IContentTextApplicationService>
    {
        public ContentTextsController(ControllerServicesContext context, IContentTextApplicationService service)
             : base(context, true, service)
        {
        }


    }
}
