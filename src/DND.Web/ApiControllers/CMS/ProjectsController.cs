using AspNetCore.Mvc.Extensions.Authorization;
using AspNetCore.Mvc.Extensions.Context;
using AspNetCore.Mvc.Extensions.Controllers.Api;
using DND.Application;
using DND.Application.CMS.Projects.Dtos;
using DND.Application.CMS.Projects.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace DND.Web.ApiControllers.CMS
{
    [Authorize(Roles = "admin")]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/cms/projects")]
    public class ProjectsController : ApiControllerEntityAuthorizeBase<ProjectDto, ProjectDto, ProjectDto, ProjectDeleteDto, IProjectApplicationService>
    {
        public ProjectsController(ControllerServicesContext context, IProjectApplicationService service)
            : base(context, service)
        {

        }
    }
}
