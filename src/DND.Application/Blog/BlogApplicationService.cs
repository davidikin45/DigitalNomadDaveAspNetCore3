using AspNetCore.Mvc.Extensions.Application;
using AspNetCore.Mvc.Extensions.Context;
using DND.Application.Blog.Authors.Services;
using DND.Application.Blog.BlogPosts.Services;
using DND.Application.Blog.Categories.Services;
using DND.Application.Blog.Tags.Services;

namespace DND.Application.Blog
{
    public class BlogApplicationService : ApplicationServiceBase, IBlogApplicationService
    {
        public IBlogPostApplicationService BlogPostApplicationService { get; private set; }
        public ICategoryApplicationService CategoryApplicationService { get; private set; }
        public ITagApplicationService TagApplicationService { get; private set; }
        public IAuthorApplicationService AuthorApplicationService { get; private set; }

        public BlogApplicationService(
            ApplicationervicesContext context,
            IBlogPostApplicationService blogPostApplicationService,
            ICategoryApplicationService categoryApplicationService,
            ITagApplicationService tagApplicationService,
            IAuthorApplicationService authorApplicationService)
            : base(context)
        {
            BlogPostApplicationService = blogPostApplicationService;
            CategoryApplicationService = categoryApplicationService;
            TagApplicationService = tagApplicationService;
            AuthorApplicationService = authorApplicationService;
        }

    }
}
