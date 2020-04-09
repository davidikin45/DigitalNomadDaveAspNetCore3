using AspNetCore.Mvc.Extensions.Application;
using DND.Application.CMS.CarouselItems.Dtos;

namespace DND.Application.CMS.CarouselItems.Services
{
    public interface ICarouselItemApplicationService : IApplicationServiceEntity<CarouselItemDto, CarouselItemDto, CarouselItemDto, CarouselItemDeleteDto>
    {

    }
}
