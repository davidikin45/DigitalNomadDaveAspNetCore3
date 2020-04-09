using AspNetCore.Mvc.Extensions.Data.Repository;
using DND.Domain.Blog.Tags;
using System.Threading;
using System.Threading.Tasks;

namespace DND.Domain.Blog.Tags
{
    public interface ITagRepository : IGenericRepository<Tag>
    {
        Task<Tag> GetTagAsync(string tagSlug, CancellationToken cancellationToken);
    }
}
