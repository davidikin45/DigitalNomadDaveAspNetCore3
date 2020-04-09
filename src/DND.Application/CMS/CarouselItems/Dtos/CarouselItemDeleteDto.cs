using AspNetCore.Mvc.Extensions.Dtos;
using AspNetCore.Mvc.Extensions.Mapping;
using DND.Domain.CMS.CarouselItems;

namespace DND.Application.CMS.CarouselItems.Dtos
{
    public class CarouselItemDeleteDto : DtoAggregateRootBase<int>, IMapFrom<CarouselItem>, IMapTo<CarouselItem>
    {

        public CarouselItemDeleteDto()
        {

        }
    }
}
