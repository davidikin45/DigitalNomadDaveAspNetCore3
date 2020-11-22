using AspNetCore.Mvc.Extensions.Authorization;
using AspNetCore.Mvc.Extensions.Context;
using AspNetCore.Mvc.Extensions.Controllers.Mvc;
using DND.Application;
using DND.Application.Blog.Locations.Dtos;
using DND.Application.Blog.Locations.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DND.Web.Areas.Admin.Controllers.Locations
{
    [Authorize(Roles = "admin")]
    [Area("Admin")]
    [Route("admin/blog/locations")]
    public class LocationsController : MvcControllerEntityAuthorizeBase<LocationDto, LocationDto, LocationDto, LocationDeleteDto, ILocationApplicationService>
    {
        public LocationsController(ControllerServicesContext context, ILocationApplicationService service)
             : base(context, true, service)
        {
        }

    }
}
