using AspNetCore.Mvc.Extensions.Authorization;
using AspNetCore.Mvc.Extensions.Context;
using AspNetCore.Mvc.Extensions.Controllers.Api;
using DND.Application;
using DND.Application.Blog.BlogPosts.Dtos;
using DND.Application.Blog.BlogPosts.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace DND.Web.ApiControllers.Blog
{
    [Authorize(Roles = "admin")]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/blog/blog-posts")]
    public class BlogPostsController : ApiControllerEntityAuthorizeBase<BlogPostDto, BlogPostDto, BlogPostDto, BlogPostDeleteDto, IBlogPostApplicationService>
    {
        public BlogPostsController(ControllerServicesContext context, IBlogPostApplicationService service)
            : base(context, service)
        {

        }
    }
}
