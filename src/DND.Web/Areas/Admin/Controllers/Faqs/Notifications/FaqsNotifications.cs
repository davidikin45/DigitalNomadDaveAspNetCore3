using AspNetCore.Mvc.Extensions.SignalR;
using DND.Application.CMS.Faqs.Dtos;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.SignalR;

namespace DND.Web.Areas.Admin.Controllers.Faq.Notifications
{
    public class FaqsNotifications : ISignalRHubMap
    {
        public void MapHub(IEndpointRouteBuilder routes, string hubPathPrefix)
        {
            routes.MapHub<ApiNotificationHub<FaqDto>>(hubPathPrefix + "/cms/faqs/notifications");
        }
    }
}
