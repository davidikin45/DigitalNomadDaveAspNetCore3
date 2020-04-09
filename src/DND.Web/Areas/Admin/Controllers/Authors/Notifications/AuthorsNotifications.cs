using AspNetCore.Mvc.Extensions.SignalR;
using DND.Application.Blog.Authors.Dtos;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.SignalR;

namespace DND.Web.Areas.Admin.Controllers.Author.Notifications
{
    public class AuthorsNotifications : ISignalRHubMap
    {
        public void MapHub(IEndpointRouteBuilder routes, string hubPathPrefix)
        {
            routes.MapHub<ApiNotificationHub<AuthorDto>>(hubPathPrefix + "/blog/authors/notifications");
        }
    }
}
