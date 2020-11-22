using AspNetCore.Mvc.Extensions.Authorization;
using AspNetCore.Mvc.Extensions.Context;
using AspNetCore.Mvc.Extensions.Controllers.Api;
using DND.Application;
using DND.Application.CMS.ContentHtmls.Dtos;
using DND.Application.CMS.ContentHtmls.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace DND.Web.ApiControllers.CMS
{
    [Authorize(Roles = "admin")]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/cms/content-htmls")]
    public class ContentHtmlsController : ApiControllerEntityAuthorizeBase<ContentHtmlDto, ContentHtmlDto, ContentHtmlDto, ContentHtmlDeleteDto, IContentHtmlApplicationService>
    {
        public ContentHtmlsController(ControllerServicesContext context, IContentHtmlApplicationService service)
            : base(context, service)
        {

        }
    }
}
