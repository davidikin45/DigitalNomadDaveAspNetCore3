using AspNetCore.Mvc.Extensions.Authorization;
using AspNetCore.Mvc.Extensions.Context;
using AspNetCore.Mvc.Extensions.Controllers.Mvc;
using DND.Application;
using DND.Application.Blog.BlogPosts.Dtos;
using DND.Application.Blog.BlogPosts.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DND.Web.Areas.Admin.Controllers.BlogPosts
{
    [Authorize(Roles = "admin")]
    [Area("Admin")]
    [ResourceCollection(ResourceCollections.Blog.BlogPosts.CollectionId)]
    [Route("admin/blog/blog-posts")]
    public class BlogPostsController : MvcControllerEntityAuthorizeBase<BlogPostDto, BlogPostDto, BlogPostDto, BlogPostDeleteDto, IBlogPostApplicationService>
    {
        public BlogPostsController(ControllerServicesContext context, IBlogPostApplicationService service)
             : base(context, true, service)
        {
        }
    }
}
