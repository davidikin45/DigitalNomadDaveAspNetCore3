using AspNetCore.Mvc.Extensions.Data.Repository;
using DND.Domain.CMS.Projects;

namespace DND.Domain.CMS.Projects
{
    public interface IProjectRepository : IGenericRepository<Project>
    {
    }
}
