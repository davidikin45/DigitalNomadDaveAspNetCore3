using AspNetCore.Mvc.Extensions.Data.Repository;
using DND.Domain.CMS.Projects;

namespace DND.Data.Repositories.CMS
{
    public class ProjectRepository : GenericRepository<Project>, IProjectRepository
    {
        public ProjectRepository(AppContext context)
            : base(context)
        {

        }
    }
}
