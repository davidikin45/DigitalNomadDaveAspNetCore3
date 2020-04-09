using AspNetCore.Mvc.Extensions.SignalR;
using DND.Application.CMS.ContentTexts.Dtos;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.SignalR;

namespace DND.Web.Areas.Admin.Controllers.ContentText.Notifications
{
    public class ContentTextsNotifications : ISignalRHubMap
    {
        //.NET Core 2.2
        //public void MapHub(HubRouteBuilder routes, string signalRUrlPrefix)
        //{
        //    routes.MapHub<ApiNotificationHub<ContentTextDto>>(signalRUrlPrefix + "/cms/content-texts/notifications");
        //}

        public void MapHub(IEndpointRouteBuilder routes, string hubPathPrefix)
        {
            routes.MapHub<ApiNotificationHub<ContentTextDto>>(hubPathPrefix + "/cms/content-texts/notifications");
        }
    }
}
