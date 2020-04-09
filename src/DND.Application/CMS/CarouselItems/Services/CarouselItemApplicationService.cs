using AspNetCore.Mvc.Extensions.Application;
using AspNetCore.Mvc.Extensions.Authorization;
using AspNetCore.Mvc.Extensions.Context;
using AspNetCore.Mvc.Extensions.SignalR;
using DND.Application.CMS.CarouselItems.Dtos;
using DND.Domain;
using DND.Domain.CMS.CarouselItems;
using Microsoft.AspNetCore.SignalR;

namespace DND.Application.CMS.CarouselItems.Services
{
    [ResourceCollection(ResourceCollections.CMS.CarouselItems.CollectionId)]
    public class CarouselItemApplicationService : ApplicationServiceEntityBase<CarouselItem, CarouselItemDto, CarouselItemDto, CarouselItemDto, CarouselItemDeleteDto, IAppUnitOfWork>, ICarouselItemApplicationService
    {
        public CarouselItemApplicationService(ApplicationervicesContext context, IAppUnitOfWork appUnitOfWork, IHubContext<ApiNotificationHub<CarouselItemDto>> hubContext)
        : base(context, appUnitOfWork, hubContext)
        {

        }

    }
}
