using AspNetCore.Mvc.Extensions.Data.Repository;
using DND.Domain.Blog.Authors;
using System.Threading;
using System.Threading.Tasks;

namespace DND.Domain.Blog.Authors
{
    public interface IAuthorRepository : IGenericRepository<Author>
    {
        Task<Author> GetAuthorAsync(string authorSlug, CancellationToken cancellationToken);
    }
}
