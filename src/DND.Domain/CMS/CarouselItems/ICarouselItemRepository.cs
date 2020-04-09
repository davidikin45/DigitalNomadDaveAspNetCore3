using AspNetCore.Mvc.Extensions.Data.Repository;
using DND.Domain.CMS.CarouselItems;

namespace DND.Domain.CMS.CarouselItems
{
    public interface ICarouselItemRepository : IGenericRepository<CarouselItem>
    {
    }
}
