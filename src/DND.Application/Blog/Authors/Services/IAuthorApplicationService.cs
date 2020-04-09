using AspNetCore.Mvc.Extensions.Application;
using DND.Application.Blog.Authors.Dtos;
using System.Threading;
using System.Threading.Tasks;

namespace DND.Application.Blog.Authors.Services
{
    public interface IAuthorApplicationService : IApplicationServiceEntity<AuthorDto, AuthorDto, AuthorDto, AuthorDeleteDto>
    {
        Task<AuthorDto> GetAuthorAsync(string authorSlug, CancellationToken cancellationToken);
    }
}
