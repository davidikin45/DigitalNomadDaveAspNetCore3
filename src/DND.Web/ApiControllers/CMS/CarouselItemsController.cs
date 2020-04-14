using AspNetCore.Mvc.Extensions.Authorization;
using AspNetCore.Mvc.Extensions.Context;
using AspNetCore.Mvc.Extensions.Controllers.Api;
using AutoMapper;
using DND.Application;
using DND.Application.CMS.CarouselItems.Dtos;
using DND.Application.CMS.CarouselItems.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace DND.Web.ApiControllers.CMS
{
    [Authorize(Roles = "admin")]
    [ResourceCollection(ResourceCollections.CMS.CarouselItems.CollectionId)]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/cms/carousel-items")]
    public class CarouselItemsController : ApiControllerEntityAuthorizeBase<CarouselItemDto, CarouselItemDto, CarouselItemDto, CarouselItemDeleteDto, ICarouselItemApplicationService>
    {
        public CarouselItemsController(ControllerServicesContext context, ICarouselItemApplicationService service)
            : base(context, service)
        {

        }
    }
}
