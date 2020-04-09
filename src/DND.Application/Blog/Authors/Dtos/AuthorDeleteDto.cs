using AspNetCore.Mvc.Extensions.Dtos;
using AspNetCore.Mvc.Extensions.Mapping;
using DND.Domain.Blog.Authors;

namespace DND.Application.Blog.Authors.Dtos
{
    public class AuthorDeleteDto : DtoAggregateRootBase<int> , IMapFrom<Author>, IMapTo<Author>
    {
        public AuthorDeleteDto()
		{

        }
    }
}