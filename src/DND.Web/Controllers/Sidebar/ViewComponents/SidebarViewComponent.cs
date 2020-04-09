using AspNetCore.Mvc.Extensions;
using AspNetCore.Mvc.Extensions.Data.RepositoryFileSystem;
using AspNetCore.Mvc.Extensions.Helpers;
using AspNetCore.Mvc.Extensions.Settings;
using AspNetCore.Mvc.Extensions.ViewComponents;
using DND.Application;
using DND.Application.Blog;
using DND.Application.Blog.BlogPosts.Dtos;
using DND.Application.Blog.Categories.Dtos;
using DND.Application.Blog.Tags.Dtos;
using DND.Web.Controllers.Sidebar.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DND.Web.Controllers.Sidebar.ViewComponents
{
    public class SidebarViewComponent : ViewComponentBase
    {
        private readonly IBlogApplicationService _blogService;
        private readonly IFileSystemGenericRepositoryFactory FileSystemRepository;
        private readonly AppSettings _appSettings;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public SidebarViewComponent(IBlogApplicationService blogService, IFileSystemGenericRepositoryFactory fileSystemRepository, AppSettings appSettings, IWebHostEnvironment hostingEnvironment)
        {
            FileSystemRepository = fileSystemRepository;
            _blogService = blogService;
            _appSettings = appSettings;
            _hostingEnvironment = hostingEnvironment;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var cts = TaskHelper.CreateChildCancellationTokenSource(ClientDisconnectedToken());

            var repository = FileSystemRepository.CreateFileRepository(cts.Token, _hostingEnvironment.MapWwwPath(_appSettings.Folders[Folders.Gallery]), true, "*.*", ".jpg", ".jpeg");

            IList<CategoryDto> categories = null;
            IEnumerable<TagDto> tags = null;
            IEnumerable<BlogPostDto> posts = null;
            IEnumerable<FileInfo> photos = null;

            List<Task<int>> countTasks = new List<Task<int>>();

            //foreach (TagDto dto in tagsTask.Result)
            //{
            //    tagCountTasks.Add(_blogService.BlogPostService.GetTotalPostsForTagAsync(dto.UrlSlug, cts.Token).ContinueWith(t => dto.Count = t.Result));
            //}
            categories = (await _blogService.CategoryApplicationService.GetAsync(cts.Token, c => c.Published)).ToList();
            foreach (CategoryDto dto in categories)
            {
                dto.Count = await _blogService.BlogPostApplicationService.GetTotalPostsForCategoryAsync(dto.UrlSlug, cts.Token);
            }

            tags = await _blogService.TagApplicationService.GetAllAsync(cts.Token);
            posts = await _blogService.BlogPostApplicationService.GetPostsAsync(0, 10, cts.Token);
            photos = await repository.GetAllAsync(d => d.OrderByDescending(f => f.LastWriteTime), 0, 6);

            var widgetViewModel = new BlogWidgetViewModel
            {
                Categories = categories,
                Tags = tags.ToList(),
                LatestPosts = posts.ToList(),
                LatestPhotos = photos.ToList()
            };

            return View(widgetViewModel);
        }

    }
}
