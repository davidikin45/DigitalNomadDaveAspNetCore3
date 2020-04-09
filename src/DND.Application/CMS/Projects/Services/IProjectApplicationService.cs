using AspNetCore.Mvc.Extensions.Application;
using DND.Application.CMS.Projects.Dtos;

namespace DND.Application.CMS.Projects.Services
{
    public interface IProjectApplicationService : IApplicationServiceEntity<ProjectDto, ProjectDto, ProjectDto, ProjectDeleteDto>
    {
        
    }
}
