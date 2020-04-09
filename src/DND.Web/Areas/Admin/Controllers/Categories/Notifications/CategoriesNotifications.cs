using AspNetCore.Mvc.Extensions.SignalR;
using DND.Application.Blog.Categories.Dtos;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.SignalR;

namespace DND.Web.Areas.Admin.Controllers.Category.Notifications
{
    public class CategoriesNotifications : ISignalRHubMap
    {
        public void MapHub(IEndpointRouteBuilder routes, string hubPathPrefix)
        {
            routes.MapHub<ApiNotificationHub<CategoryDto>>(hubPathPrefix + "/blog/categories/notifications");
        }
    }
}
