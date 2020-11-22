using AspNetCore.Mvc.Extensions.Application;
using AspNetCore.Mvc.Extensions.Authorization;
using AspNetCore.Mvc.Extensions.Context;
using AspNetCore.Mvc.Extensions.SignalR;
using DND.Application.CMS.ContentTexts.Dtos;
using DND.Domain;
using DND.Domain.CMS.ContentTexts;
using Microsoft.AspNetCore.SignalR;

namespace DND.Application.CMS.ContentTexts.Services
{
    public class ContentTextApplicationService : ApplicationServiceEntityBase<ContentText, ContentTextDto, ContentTextDto, ContentTextDto, ContentTextDeleteDto, IAppUnitOfWork>, IContentTextApplicationService
    {
        public ContentTextApplicationService(ApplicationServiceServicesContext context, IAppUnitOfWork appUnitOfWork, IHubContext<ApiNotificationHub<ContentTextDto>> hubContext)
        : base(context, appUnitOfWork, hubContext)
        {

        }
    }
}
