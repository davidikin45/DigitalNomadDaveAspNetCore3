using AspNetCore.Mvc.Extensions.Application;
using AspNetCore.Mvc.Extensions.Authorization;
using AspNetCore.Mvc.Extensions.Context;
using AspNetCore.Mvc.Extensions.SignalR;
using DND.Application.CMS.Projects.Dtos;
using DND.Domain;
using DND.Domain.CMS.Projects;
using Microsoft.AspNetCore.SignalR;

namespace DND.Application.CMS.Projects.Services
{
    [ResourceCollection(ResourceCollections.CMS.Projects.CollectionId)]
    public class ProjectApplicationService : ApplicationServiceEntityBase<Project, ProjectDto, ProjectDto, ProjectDto, ProjectDeleteDto, IAppUnitOfWork>, IProjectApplicationService
    {
        public ProjectApplicationService(ApplicationervicesContext context, IAppUnitOfWork appUnitOfWork, IHubContext<ApiNotificationHub<ProjectDto>> hubContext)
        : base(context, appUnitOfWork, hubContext)
        {

        }
    }
}
