using AspNetCore.Mvc.Extensions.Data.Repository;
using DND.Domain.CMS.CarouselItems;

namespace DND.Data.Repositories.CMS
{
    public class CarouselItemRepository : GenericRepository<CarouselItem>, ICarouselItemRepository
    {
        public CarouselItemRepository(AppContext context)
            : base(context)
        {

        }
    }
}
