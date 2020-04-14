using AspNetCore.Mvc.Extensions.Authorization;
using AspNetCore.Mvc.Extensions.Context;
using AspNetCore.Mvc.Extensions.Controllers.Mvc;
using DND.Application;
using DND.Application.Blog.Categories.Dtos;
using DND.Application.Blog.Categories.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DND.Web.Areas.Admin.Controllers.Categories
{
    [Authorize(Roles = "admin")]
    [Area("Admin")]
    [ResourceCollection(ResourceCollections.Blog.Categories.CollectionId)]
    [Route("admin/blog/categories")]
    public class CategoriesController : MvcControllerEntityAuthorizeBase<CategoryDto, CategoryDto, CategoryDto, CategoryDeleteDto, ICategoryApplicationService>
    {
        public CategoriesController(ControllerServicesContext context, ICategoryApplicationService service)
             : base(context, true, service)
        {
        }
    }
}
