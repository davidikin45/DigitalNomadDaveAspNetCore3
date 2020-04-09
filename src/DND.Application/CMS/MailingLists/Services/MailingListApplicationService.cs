using AspNetCore.Mvc.Extensions.Application;
using AspNetCore.Mvc.Extensions.Authorization;
using AspNetCore.Mvc.Extensions.Context;
using AspNetCore.Mvc.Extensions.SignalR;
using DND.Application.CMS.MailingLists.Dtos;
using DND.Domain;
using DND.Domain.CMS.MailingLists;
using Microsoft.AspNetCore.SignalR;

namespace DND.Application.CMS.MailingLists.Services
{
    [ResourceCollection(ResourceCollections.CMS.MailingList.CollectionId)]
    public class MailingListApplicationService : ApplicationServiceEntityBase<MailingList, MailingListDto, MailingListDto, MailingListDto, MailingListDeleteDto, IAppUnitOfWork>, IMailingListApplicationService
    {
        public MailingListApplicationService(ApplicationervicesContext context, IAppUnitOfWork appUnitOfWork, IHubContext<ApiNotificationHub<MailingListDto>> hubContext)
        : base(context, appUnitOfWork, hubContext)
        {

        }
    }
}
