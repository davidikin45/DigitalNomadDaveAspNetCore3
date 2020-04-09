using AspNetCore.Mvc.Extensions.Application;
using DND.Application.Blog.Authors.Services;
using DND.Application.Blog.BlogPosts.Services;
using DND.Application.Blog.Categories.Services;
using DND.Application.Blog.Tags.Services;

namespace DND.Application.Blog
{
    public interface IBlogApplicationService : IApplicationService
    {
        IBlogPostApplicationService BlogPostApplicationService { get; }
        ICategoryApplicationService CategoryApplicationService { get; }
        ITagApplicationService TagApplicationService { get; }
        IAuthorApplicationService AuthorApplicationService { get; }
    }
}
