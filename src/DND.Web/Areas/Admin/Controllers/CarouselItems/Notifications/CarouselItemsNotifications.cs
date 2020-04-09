using AspNetCore.Mvc.Extensions.SignalR;
using DND.Application.CMS.CarouselItems.Dtos;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.SignalR;

namespace DND.Web.Areas.Admin.Controllers.CarouselItem.Notifications
{
    public class CarouselItemsNotifications : ISignalRHubMap
    {
        public void MapHub(IEndpointRouteBuilder routes, string signalRUrlPrefix)
        {
            routes.MapHub<ApiNotificationHub<CarouselItemDto>>(signalRUrlPrefix + "/cms/carousel-items/notifications");
        }
    }
}
