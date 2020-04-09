using AspNetCore.Mvc.Extensions.SignalR;
using DND.Application.Blog.BlogPosts.Dtos;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.SignalR;

namespace DND.Web.Areas.Admin.Controllers.Blog.Notifications
{
    public class BlogPostsNotifications : ISignalRHubMap
    {
        public void MapHub(IEndpointRouteBuilder routes, string hubPathPrefix)
        {
            routes.MapHub<ApiNotificationHub<BlogPostDto>>(hubPathPrefix + "/blog/blog-posts/notifications");
        }
    }
}
