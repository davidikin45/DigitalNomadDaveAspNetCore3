using AspNetCore.Mvc.Extensions;
using AspNetCore.Mvc.Extensions.Attributes.Routing;
using AspNetCore.Mvc.Extensions.Context;
using AspNetCore.Mvc.Extensions.Controllers.Mvc;
using AspNetCore.Mvc.Extensions.Data.RepositoryFileSystem;
using AspNetCore.Mvc.Extensions.Dtos;
using AspNetCore.Mvc.Extensions.Features;
using AspNetCore.Mvc.Extensions.Helpers;
using AspNetCore.Mvc.Extensions.Mapping;
using AspNetCore.Mvc.Extensions.UI;
using AspNetCore.Specification.UI;
using AutoMapper;
using DND.Application;
using DND.Application.Blog;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DND.Web.Areas.Frontend.Controllers.Gallery
{
    [Area("Frontend")]
    [Feature("Gallery")]
    [Route("gallery")]
    public class GalleryController : MvcControllerBase
    {
        private readonly IBlogApplicationService _blogService;
        private readonly IFileSystemGenericRepositoryFactory _fileSystemGenericRepositoryFactory;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public GalleryController(ControllerServicesContext context, IBlogApplicationService blogService, IFileSystemGenericRepositoryFactory fileSystemGenericRepositoryFactory)
             : base(context)
        {
            _blogService = blogService;
            _fileSystemGenericRepositoryFactory = fileSystemGenericRepositoryFactory;
            _hostingEnvironment = context.HostingEnvironment;
        }

        [ResponseCache(CacheProfileName = "Cache24HourParams")]
        [Route("")]
        public async Task<ActionResult> Index(int p = 1, int pageSize = 20, string orderBy = nameof(DirectoryInfo.LastWriteTime)+ " desc", string search = "")
        {
            var cts = TaskHelper.CreateChildCancellationTokenSource(ClientDisconnectedToken());

            try
            {
                var repository = _fileSystemGenericRepositoryFactory.CreateFolderRepository(cts.Token, _hostingEnvironment.MapWwwPath(AppSettings.Folders[Folders.Gallery]));

                var data = await repository.SearchAsync(search, null, UIHelper.GetOrderByIQueryableDelegate<DirectoryInfo>(orderBy), (p - 1) * pageSize, pageSize);
                var total = await repository.GetSearchCountAsync(search, null);

                var response = new WebApiPagedResponseDto<DirectoryInfo>
                {
                    Page = p,
                    PageSize = pageSize,
                    Records = total,
                    Rows = data.ToList(),
                    OrderBy = orderBy,
                    Search = search
                };

                ViewBag.Search = search;
                ViewBag.Page = p;
                ViewBag.PageSize = pageSize;
                ViewBag.OrderBy = orderBy;

                return View(response);
            }
            catch
            {
                return HandleReadException();
            }
        }

        [NoAjaxRequest]
        [ResponseCache(CacheProfileName = "Cache24HourParams")]
        [Route("{name}")]
        public virtual async Task<ActionResult> Gallery(string name, int p = 1, int pageSize = 24, string orderColumn = nameof(FileInfo.LastWriteTime) + " desc")
        {
            try
            {
                if (name == "instagram")
                    return View("Instagram");

                string physicalPath = _hostingEnvironment.MapWwwPath(AppSettings.Folders[Folders.Gallery]) + name;

                if (!System.IO.Directory.Exists(physicalPath))
                {
                    name = name.ToLower().Replace("-", " ");
                    physicalPath = _hostingEnvironment.MapWwwPath(AppSettings.Folders[Folders.Gallery]) + name;
                }

                if (!System.IO.Directory.Exists(physicalPath))
                    return HandleReadException();

                var response = await GetGalleryViewModel(physicalPath, p, pageSize, orderColumn);

                ViewBag.Album = new DirectoryInfo(_hostingEnvironment.MapWwwPath(AppSettings.Folders[Folders.Gallery]) + name);

                ViewBag.Page = p;
                ViewBag.PageSize = pageSize;
                ViewBag.OrderColumn = orderColumn;

                return View(response);
            }
            catch
            {
                return HandleReadException();
            }
        }

        [AjaxRequest]
        [ActionName("Gallery")]
        [ResponseCache(CacheProfileName = "Cache24HourParams")]
        [Route("{name}")]
        public virtual async Task<ActionResult> GalleryList(string name, int p = 1, int pageSize = 24, string orderColumn = nameof(FileInfo.LastWriteTime) + " desc")
        {
            try
            {
                string physicalPath = _hostingEnvironment.MapWwwPath(AppSettings.Folders[Folders.Gallery]) + name;

                if (!System.IO.Directory.Exists(physicalPath))
                {
                    name = name.ToLower().Replace("-", " ");
                    physicalPath = _hostingEnvironment.MapWwwPath(AppSettings.Folders[Folders.Gallery]) + name;
                }

                if (!System.IO.Directory.Exists(physicalPath))
                    return HandleReadException();

                var response = await GetGalleryViewModel(physicalPath, p, pageSize, orderColumn);

                return PartialView("_GalleryAjax", response);
            }
            catch
            {
                return HandleReadException();
            }
        }

        private async Task<WebApiPagedResponseDto<FileInfo>> GetGalleryViewModel(string physicalPath, int p = 1, int pageSize = 40, string orderBy = nameof(FileInfo.LastWriteTime) + " desc")
        {
            var cts = TaskHelper.CreateChildCancellationTokenSource(ClientDisconnectedToken());

            var repository = _fileSystemGenericRepositoryFactory.CreateFileRepository(cts.Token, physicalPath, true, "*.*", ".jpg", ".jpeg", ".mp4", ".avi", ".txt");

            var data = await repository.GetAllAsync(UIHelper.GetOrderByIQueryableDelegate<FileInfo>(orderBy), (p - 1) * pageSize, pageSize);
            var total = await repository.GetCountAsync(null);

            var response = new WebApiPagedResponseDto<FileInfo>
            {
                Page = p,
                PageSize = pageSize,
                Records = total,
                Rows = data.ToList(),
                OrderBy = orderBy
            };

            return response;
        }

    }
}
