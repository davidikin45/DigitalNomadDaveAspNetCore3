using AspNetCore.Mvc.Extensions.Application;
using DND.Application.Blog.Categories.Dtos;
using System.Threading;
using System.Threading.Tasks;

namespace DND.Application.Blog.Categories.Services
{
    public interface ICategoryApplicationService : IApplicationServiceEntity<CategoryDto, CategoryDto, CategoryDto, CategoryDeleteDto>
    {
        Task<CategoryDto> GetCategoryAsync(string categorySlug, CancellationToken cancellationToken);
    }
}
