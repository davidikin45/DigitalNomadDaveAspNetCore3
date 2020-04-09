using AspNetCore.Mvc.Extensions;
using AspNetCore.Mvc.Extensions.Data.RepositoryFileSystem;
using AspNetCore.Mvc.Extensions.Helpers;
using AspNetCore.Mvc.Extensions.Settings;
using AspNetCore.Mvc.Extensions.ViewComponents;
using DND.Application;
using DND.Application.Blog;
using DND.Application.Blog.BlogPosts.Dtos;
using DND.Application.CMS.CarouselItems.Dtos;
using DND.Application.CMS.CarouselItems.Services;
using DND.Web.Areas.Frontend.Controllers.CarouselItem.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DND.Web.Areas.Frontend.Controllers.CarouselItem.ViewComponents
{
    [ViewComponent]
    public class CarouselViewComponent : ViewComponentBase
    {
        private readonly IBlogApplicationService _blogService;
        private readonly ICarouselItemApplicationService _carouselItemService;
        private readonly IFileSystemGenericRepositoryFactory _fileSystemRepository;
        private readonly AppSettings _appSettings;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public CarouselViewComponent(IBlogApplicationService blogService, ICarouselItemApplicationService carouselItemService, IFileSystemGenericRepositoryFactory fileSystemRepository, AppSettings appSettings, IWebHostEnvironment hostingEnvironment)
        {
            _fileSystemRepository = fileSystemRepository;
            _blogService = blogService;
            _carouselItemService = carouselItemService;
            _appSettings = appSettings;
            _hostingEnvironment = hostingEnvironment;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            string orderColumn = nameof(CarouselItemDto.CreatedOn) + " desc";

            var cts = TaskHelper.CreateChildCancellationTokenSource(ClientDisconnectedToken());

            IEnumerable<BlogPostDto> posts = null;
            IList<CarouselItemDto> carouselItemsFinal = new List<CarouselItemDto>();
            IEnumerable<CarouselItemDto> carouselItems = null;

            IList<DirectoryInfo> albums = new List<DirectoryInfo>();
            IList<CarouselItemDto> albumCarouselItems = new List<CarouselItemDto>();

            posts = await _blogService.BlogPostApplicationService.GetPostsForCarouselAsync(0, 3, cts.Token);
            carouselItems = await _carouselItemService.GetAsync(cts.Token, c => c.Published, orderColumn, null, null);

            var repository = _fileSystemRepository.CreateFolderRepositoryReadOnly(cts.Token, _hostingEnvironment.MapWwwPath(_appSettings.Folders[Folders.Gallery]));
            foreach (CarouselItemDto item in carouselItems)
            {
                if (!string.IsNullOrEmpty(item.Album))
                {
                    var album = repository.GetByPath(item.Album);
                    if (album != null)
                    {
                        albums.Add(album);
                        albumCarouselItems.Add(item);
                    }
                }
                else
                {
                    carouselItemsFinal.Add(item);
                }
            }

            var carouselViewModel = new CarouselViewModel
            {
                Posts = posts.ToList(),

                Albums = albums.ToList(),
                AlbumCarouselItems = albumCarouselItems.ToList(),

                CarouselItems = carouselItemsFinal.ToList(),
                ItemCount = posts.Count() + albums.Count() + carouselItemsFinal.Count()
            };

            return View(carouselViewModel);
        }

    }
}
