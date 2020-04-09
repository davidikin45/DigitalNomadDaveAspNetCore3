using AspNetCore.Mvc.Extensions.Dtos;
using AspNetCore.Mvc.Extensions.Mapping;
using DND.Domain.CMS.Projects;

namespace DND.Application.CMS.Projects.Dtos
{
    public class ProjectDeleteDto : DtoAggregateRootBase<int>, IMapFrom<Project>, IMapTo<Project>
    {

    }
}
