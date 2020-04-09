using AspNetCore.Mvc.Extensions.Dtos;
using AspNetCore.Mvc.Extensions.Mapping;
using DND.Domain.Blog.Tags;

namespace DND.Application.Blog.Tags.Dtos
{
    public class TagDeleteDto : DtoAggregateRootBase<int>, IMapFrom<Tag>, IMapTo<Tag>
    {

    }
}
