using AspNetCore.Mvc.Extensions.SignalR;
using DND.Application.CMS.Projects.Dtos;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.SignalR;

namespace DND.Web.Areas.Admin.Controllers.Project.Notifications
{
    public class ProjectsNotifications : ISignalRHubMap
    {
        public void MapHub(IEndpointRouteBuilder routes, string hubPathPrefix)
        {
            routes.MapHub<ApiNotificationHub<ProjectDto>>(hubPathPrefix + "/cms/projects/notifications");
        }
    }
}
