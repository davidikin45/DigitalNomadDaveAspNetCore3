using AspNetCore.Mvc.Extensions.SignalR;
using DND.Application.CMS.ContentHtmls.Dtos;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.SignalR;

namespace DND.Web.Areas.Admin.Controllers.ContentHtml.Notifications
{
    public class ContentHtmlsNotifications : ISignalRHubMap
    {
        public void MapHub(IEndpointRouteBuilder routes, string hubPathPrefix)
        {
            routes.MapHub<ApiNotificationHub<ContentHtmlDto>>(hubPathPrefix + "/cms/content-htmls/notifications");
        }
    }
}
