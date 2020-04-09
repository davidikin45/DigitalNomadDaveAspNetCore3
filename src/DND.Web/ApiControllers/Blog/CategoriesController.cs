using AspNetCore.Mvc.Extensions.Authorization;
using AspNetCore.Mvc.Extensions.Context;
using AspNetCore.Mvc.Extensions.Controllers.Api;
using DND.Application;
using DND.Application.Blog.Categories.Dtos;
using DND.Application.Blog.Categories.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace DND.Web.ApiControllers.Blog
{
    [ResourceCollection(ResourceCollections.Blog.Categories.CollectionId)]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/blog/categories")]
    public class CategoriesController : ApiControllerEntityAuthorizeBase<CategoryDto, CategoryDto, CategoryDto, CategoryDeleteDto, ICategoryApplicationService>
    {
        public CategoriesController(ControllerServicesContext context, ICategoryApplicationService service)
            : base(context, service)
        {

        }
    }
}
