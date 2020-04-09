using AspNetCore.Mvc.Extensions.Authorization;
using AspNetCore.Mvc.Extensions.Context;
using AspNetCore.Mvc.Extensions.Controllers.Api;
using DND.Application;
using DND.Application.Blog.Locations.Dtos;
using DND.Application.Blog.Locations.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace DND.Web.ApiControllers.Blog
{
    [ResourceCollection(ResourceCollections.Blog.Locations.CollectionId)]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/blog/locations")]
    public class LocationsController : ApiControllerEntityAuthorizeBase<LocationDto, LocationDto, LocationDto, LocationDeleteDto, ILocationApplicationService>
    {
        public LocationsController(ControllerServicesContext context, ILocationApplicationService service)
            : base(context, service)
        {

        }
    }
}
