using AspNetCore.Mvc.Extensions.Authorization;
using AspNetCore.Mvc.Extensions.Context;
using AspNetCore.Mvc.Extensions.Controllers.Mvc;
using DND.Application;
using DND.Application.CMS.Faqs.Dtos;
using DND.Application.CMS.Faqs.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DND.Web.Areas.Admin.Controllers.Faqs
{
    [Authorize(Roles = "admin")]
    [Area("Admin")]
    [Route("admin/cms/faqs")]
    public class FaqsController : MvcControllerEntityAuthorizeBase<FaqDto, FaqDto, FaqDto, FaqDeleteDto, IFaqApplicationService>
    {
        public FaqsController(ControllerServicesContext context, IFaqApplicationService service)
             : base(context, true, service)
        {
        }
    }
}
