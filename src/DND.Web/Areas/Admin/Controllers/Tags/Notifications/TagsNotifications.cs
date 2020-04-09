using AspNetCore.Mvc.Extensions.SignalR;
using DND.Application.Blog.Tags.Dtos;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.SignalR;

namespace DND.Web.Areas.Admin.Controllers.Tag.Notifications
{
    public class TagsNotifications : ISignalRHubMap
    {
        public void MapHub(IEndpointRouteBuilder routes, string hubPathPrefix)
        {
            routes.MapHub<ApiNotificationHub<TagDto>>(hubPathPrefix + "/blog/tags/notifications");
        }
    }
}
