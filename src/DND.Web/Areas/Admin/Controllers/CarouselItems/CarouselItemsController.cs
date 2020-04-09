using AspNetCore.Mvc.Extensions.Authorization;
using AspNetCore.Mvc.Extensions.Context;
using AspNetCore.Mvc.Extensions.Controllers.Mvc;
using DND.Application;
using DND.Application.CMS.CarouselItems.Dtos;
using DND.Application.CMS.CarouselItems.Services;
using Microsoft.AspNetCore.Mvc;

namespace DND.Web.Areas.Admin.Controllers.CarouselItems
{
    [Area("Admin")]
    [ResourceCollection(ResourceCollections.CMS.CarouselItems.CollectionId)]
    [Route("admin/cms/carousel-items")]
    public class CarouselItemsController : MvcControllerEntityAuthorizeBase<CarouselItemDto, CarouselItemDto, CarouselItemDto, CarouselItemDeleteDto, ICarouselItemApplicationService>
    {
        public CarouselItemsController(ControllerServicesContext context, ICarouselItemApplicationService service)
             : base(context, true, service)
        {
        }

    }
}
