using AspNetCore.Mvc.Extensions.SignalR;
using DND.Application.Blog.Locations.Dtos;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.SignalR;

namespace DND.Web.Areas.Admin.Controllers.Locations.Notifications
{
    public class LocationsNotifications : ISignalRHubMap
    {
        public void MapHub(IEndpointRouteBuilder routes, string hubPathPrefix)
        {
            routes.MapHub<ApiNotificationHub<LocationDto>>(hubPathPrefix + "/blog/locations/notifications");
        }
    }
}
