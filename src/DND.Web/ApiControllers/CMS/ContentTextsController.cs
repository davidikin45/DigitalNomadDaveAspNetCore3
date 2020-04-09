using AspNetCore.Mvc.Extensions.Authorization;
using AspNetCore.Mvc.Extensions.Context;
using AspNetCore.Mvc.Extensions.Controllers.Api;
using DND.Application;
using DND.Application.CMS.ContentTexts.Dtos;
using DND.Application.CMS.ContentTexts.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace DND.Web.ApiControllers.CMS
{
    [ResourceCollection(ResourceCollections.CMS.ContentTexts.CollectionId)]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/cms/content-texts")]
    public class ContentTextsController : ApiControllerEntityAuthorizeBase<ContentTextDto, ContentTextDto, ContentTextDto, ContentTextDeleteDto, IContentTextApplicationService>
    {
        public ContentTextsController(ControllerServicesContext context, IContentTextApplicationService service)
            : base(context, service)
        {

        }
    }
}
