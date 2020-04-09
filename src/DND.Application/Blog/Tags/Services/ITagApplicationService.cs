using AspNetCore.Mvc.Extensions.Application;
using DND.Application.Blog.Tags.Dtos;
using System.Threading;
using System.Threading.Tasks;

namespace DND.Application.Blog.Tags.Services
{
    public interface ITagApplicationService : IApplicationServiceEntity<TagDto, TagDto, TagDto, TagDeleteDto>
    {
        Task<TagDto> GetTagAsync(string tagSlug, CancellationToken cancellationToken);
    }
}
