using AspNetCore.Mvc.Extensions.Dtos;
using AspNetCore.Mvc.Extensions.Mapping;
using DND.Domain.Blog.BlogPosts;

namespace DND.Application.Blog.BlogPosts.Dtos
{
    public class BlogPostDeleteDto : DtoAggregateRootBase<int>,  IMapFrom<BlogPost>, IMapTo<BlogPost>
    {
        public BlogPostDeleteDto()
        {
        }
    }
}
