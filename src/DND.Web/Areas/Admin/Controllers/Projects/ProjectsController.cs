using AspNetCore.Mvc.Extensions.Authorization;
using AspNetCore.Mvc.Extensions.Context;
using AspNetCore.Mvc.Extensions.Controllers.Mvc;
using DND.Application;
using DND.Application.CMS.Projects.Dtos;
using DND.Application.CMS.Projects.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DND.Web.Areas.Admin.Controllers.Projects
{
    [Authorize(Roles = "admin")]
    [Area("Admin")]
    [ResourceCollection(ResourceCollections.CMS.Projects.CollectionId)]
    [Route("admin/cms/projects")]
    public class ProjectsController : MvcControllerEntityAuthorizeBase<ProjectDto, ProjectDto, ProjectDto, ProjectDeleteDto, IProjectApplicationService>
    {
        public ProjectsController(ControllerServicesContext context, IProjectApplicationService service)
             : base(context, true, service)
        {
        }
    }
}
