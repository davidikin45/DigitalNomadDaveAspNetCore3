using AspNetCore.Mvc.Extensions.Dtos;
using AspNetCore.Mvc.Extensions.Mapping;
using DND.Domain.Blog.Categories;

namespace DND.Application.Blog.Categories.Dtos
{
    public class CategoryDeleteDto : DtoAggregateRootBase<int>, IMapFrom<Category>, IMapTo<Category>
    {

    }
}
