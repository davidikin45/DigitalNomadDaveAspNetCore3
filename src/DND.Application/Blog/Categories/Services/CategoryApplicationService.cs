using AspNetCore.Mvc.Extensions.Application;
using AspNetCore.Mvc.Extensions.Authorization;
using AspNetCore.Mvc.Extensions.Context;
using AspNetCore.Mvc.Extensions.SignalR;
using DND.Application.Blog.Categories.Dtos;
using DND.Domain;
using DND.Domain.Blog.Categories;
using Microsoft.AspNetCore.SignalR;
using System.Threading;
using System.Threading.Tasks;

namespace DND.Application.Blog.Categories.Services
{
    public class CategoryApplicationService : ApplicationServiceEntityBase<Category, CategoryDto, CategoryDto, CategoryDto, CategoryDeleteDto, IAppUnitOfWork>, ICategoryApplicationService
    {

        public CategoryApplicationService(ApplicationServiceServicesContext context, IAppUnitOfWork unitOfWork, IHubContext<ApiNotificationHub<CategoryDto>> hubContext)
        : base(context, unitOfWork, hubContext)
        {

        }

        public async Task<CategoryDto> GetCategoryAsync(string categorySlug, CancellationToken cancellationToken)
        {
            var bo = await UnitOfWork.CategoryRepository.GetCategoryAsync(categorySlug, cancellationToken);
            return Mapper.Map<CategoryDto>(bo);
        }
    }
}
