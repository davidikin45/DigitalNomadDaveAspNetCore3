using AspNetCore.Mvc.Extensions.Context;
using AspNetCore.Mvc.Extensions.Controllers.Mvc;
using AspNetCore.Mvc.Extensions.Helpers;
using DND.Application.Blog;
using DND.Web.Areas.Frontend.Controllers.Blog.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.FeatureManagement.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
namespace DND.Web.Areas.Frontend.Controllers.Blog
{
    [Area("Frontend")]
    [FeatureGate(FeatureFlags.Blog)]
    [Route("blog")]
    public class BlogController : MvcControllerBase
    {
        private readonly IBlogApplicationService _blogService;

        public BlogController(ControllerServicesContext context, IBlogApplicationService blogService)
            : base(context)
        {
            _blogService = blogService;
        }

        [ResponseCache(CacheProfileName = "Cache24HourParams")]
        [Route("")]
        public async Task<IActionResult> Posts(int p = 1)
        {
            int pageSize = 10;

            var cts = TaskHelper.CreateChildCancellationTokenSource(ClientDisconnectedToken());

            var posts = await _blogService.BlogPostApplicationService.GetPostsAsync(p - 1, pageSize, cts.Token);
            var totalPosts = await _blogService.BlogPostApplicationService.GetTotalPostsAsync(true, cts.Token);

            var blogPostListViewModel = new BlogPostListViewModel
            {
                Page = p,
                PageSize = pageSize,
                Posts = posts.ToList(),
                TotalPosts = totalPosts
            };

            ViewBag.PageTitle = "Latest Posts";
            return View("PostList", blogPostListViewModel);
        }

        [ResponseCache(CacheProfileName = "Cache24HourParams")]
        [Route("archive/{year}/{month}/{title}")]
        public async Task<IActionResult> Post(int year, int month, string title)
        {
            var cts = TaskHelper.CreateChildCancellationTokenSource(ClientDisconnectedToken());

            var post = await _blogService.BlogPostApplicationService.GetPostAsync(year, month, title, cts.Token);

            if (post == null)
                return NotFound();

            if (post.Published == false && User.Identity.IsAuthenticated == false)
                return Unauthorized();

            return View("Post", post);
        }

        [ResponseCache(CacheProfileName = "Cache24HourParams")]
        [Route("author/{authorSlug}")]
        public async Task<IActionResult> Author(string authorSlug, int p = 1)
        {
            int pageSize = 10;

            var cts = TaskHelper.CreateChildCancellationTokenSource(ClientDisconnectedToken());

            var posts = await _blogService.BlogPostApplicationService.GetPostsForAuthorAsync(authorSlug, p - 1, pageSize, cts.Token);
            var totalPosts = await _blogService.BlogPostApplicationService.GetTotalPostsForAuthorAsync(authorSlug, cts.Token);
            var author = await _blogService.AuthorApplicationService.GetAuthorAsync(authorSlug, cts.Token);

            var blogPostListViewModel = new BlogPostListViewModel
            {
                Page = p,
                PageSize = pageSize,
                Posts = posts.ToList(),
                TotalPosts = totalPosts,
                Author = author
            };

            if (blogPostListViewModel.Author == null)
                return NotFound();

            ViewBag.PageTitle = String.Format(@"Latest posts for Author ""{0}""", blogPostListViewModel.Author.Name);

            return View("PostList", blogPostListViewModel);
        }

        [ResponseCache(CacheProfileName = "Cache24HourParams")]
        [Route("category/{categorySlug}")]
        public async Task<IActionResult> Category(string categorySlug, int p = 1)
        {
            int pageSize = 10;

            var cts = TaskHelper.CreateChildCancellationTokenSource(ClientDisconnectedToken());

            var posts = await _blogService.BlogPostApplicationService.GetPostsForCategoryAsync(categorySlug, p - 1, pageSize, cts.Token);
            var totalPosts = await _blogService.BlogPostApplicationService.GetTotalPostsForCategoryAsync(categorySlug, cts.Token);
            var category = await _blogService.CategoryApplicationService.GetCategoryAsync(categorySlug, cts.Token);

            var blogPostListViewModel = new BlogPostListViewModel
            {
                Page = p,
                PageSize = pageSize,
                Posts = posts.ToList(),
                TotalPosts = totalPosts,
                Category = category
            };

            if (blogPostListViewModel.Category == null)
                return NotFound();

            if (blogPostListViewModel.Category.Published == false && User.Identity.IsAuthenticated == false)
                return Unauthorized();

            ViewBag.PageTitle = String.Format(@"Latest posts on category ""{0}""", blogPostListViewModel.Category.Name);

            return View("PostList", blogPostListViewModel);
        }

        [ResponseCache(CacheProfileName = "Cache24HourParams")]
        [Route("tag/{tagSlug}")]
        public async Task<IActionResult> Tag(string tagSlug, int p = 1)
        {
            int pageSize = 10;

            var cts = TaskHelper.CreateChildCancellationTokenSource(ClientDisconnectedToken());

            var posts = await _blogService.BlogPostApplicationService.GetPostsForTagAsync(tagSlug, p - 1, pageSize, cts.Token);
            var totalPosts =await _blogService.BlogPostApplicationService.GetTotalPostsForTagAsync(tagSlug, cts.Token);
            var TagDto = await _blogService.TagApplicationService.GetTagAsync(tagSlug, cts.Token);

            var blogPostListViewModel = new BlogPostListViewModel
            {
                Page = p,
                PageSize = pageSize,
                Posts = posts.ToList(),
                TotalPosts = totalPosts,
                Tag = TagDto
            };

            if (blogPostListViewModel.Tag == null)
                return NotFound();

            ViewBag.PageTitle = String.Format(@"Latest posts tagged on ""{0}""", blogPostListViewModel.Tag.Name);

            return View("PostList", blogPostListViewModel);
        }

        [Route("search")]
        public async Task<ViewResult> Search(string s, int p = 1)
        {
            int pageSize = 10;

            var cts = TaskHelper.CreateChildCancellationTokenSource(ClientDisconnectedToken());

            var posts = await _blogService.BlogPostApplicationService.GetPostsForSearchAsync(s, p - 1, pageSize, cts.Token);
            var totalPosts =await _blogService.BlogPostApplicationService.GetTotalPostsForSearchAsync(s, cts.Token);

            var blogPostListViewModel = new BlogPostListViewModel
            {
                Page = p,
                PageSize = pageSize,
                Posts = posts.ToList(),
                TotalPosts = totalPosts,
                Search = s
            };

            ViewBag.PageTitle = String.Format(@"Lists of posts found for search text ""{0}""", s);

            return View("PostList", blogPostListViewModel);
        }
    }
}
