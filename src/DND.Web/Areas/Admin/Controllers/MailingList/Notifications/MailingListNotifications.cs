using AspNetCore.Mvc.Extensions.SignalR;
using DND.Application.CMS.MailingLists.Dtos;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.SignalR;

namespace DND.Web.Areas.Admin.Controllers.MailingList.Notifications
{
    public class MailingListNotifications : ISignalRHubMap
    {
        public void MapHub(IEndpointRouteBuilder routes, string hubPathPrefix)
        {
            routes.MapHub<ApiNotificationHub<MailingListDto>>(hubPathPrefix + "/cms/mailing-list/notifications");
        }
    }
}
