using AspNetCore.Mvc.Extensions.Authorization;
using AspNetCore.Mvc.Extensions.Context;
using AspNetCore.Mvc.Extensions.Controllers.Api;
using DND.Application;
using DND.Application.CMS.MailingLists.Dtos;
using DND.Application.CMS.MailingLists.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace DND.Web.ApiControllers.CMS
{
    [ResourceCollection(ResourceCollections.CMS.MailingList.CollectionId)]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/cms/mailing-list")]
    public class MailingListController : ApiControllerEntityAuthorizeBase<MailingListDto, MailingListDto, MailingListDto, MailingListDeleteDto, IMailingListApplicationService>
    {
        public MailingListController(ControllerServicesContext context, IMailingListApplicationService service)
            : base(context, service)
        {

        }
    }
}
