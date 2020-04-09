using AspNetCore.Mvc.Extensions.Data.Repository;
using DND.Domain.Blog.Categories;
using System.Threading;
using System.Threading.Tasks;

namespace DND.Domain.Blog.Categories
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        Task<Category> GetCategoryAsync(string categorySlug, CancellationToken cancellationToken);
    }
}
