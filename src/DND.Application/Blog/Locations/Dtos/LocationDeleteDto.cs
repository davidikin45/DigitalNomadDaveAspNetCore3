using AspNetCore.Mvc.Extensions.Dtos;
using AspNetCore.Mvc.Extensions.Mapping;
using DND.Domain.Blog.Locations;

namespace DND.Application.Blog.Locations.Dtos
{
    public class LocationDeleteDto : DtoAggregateRootBase<int>, IMapFrom<Location>, IMapTo<Location>
    {
        public LocationDeleteDto()
        {

        }
    }
}
