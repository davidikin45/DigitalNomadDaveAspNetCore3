using AspNetCore.Mvc.Extensions;
using AspNetCore.Mvc.Extensions.Attributes.Routing;
using AspNetCore.Mvc.Extensions.Context;
using AspNetCore.Mvc.Extensions.Controllers.Mvc;
using AspNetCore.Mvc.Extensions.Data.RepositoryFileSystem;
using AspNetCore.Mvc.Extensions.Dtos;
using AspNetCore.Mvc.Extensions.Features;
using AspNetCore.Mvc.Extensions.Helpers;
using AspNetCore.Mvc.Extensions.Mapping;
using AspNetCore.Mvc.Extensions.Settings;
using AspNetCore.Mvc.Extensions.UI;
using AspNetCore.Specification.UI;
using AutoMapper;
using DND.Application;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.FeatureManagement.Mvc;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DND.Web.Areas.Frontend.Controllers.Videos
{
    [Area("Frontend")]
    [FeatureGate(FeatureFlags.Videos)]
    [Route("videos")]
    public class VideosController : MvcControllerBase
    {
        private readonly IFileSystemGenericRepositoryFactory _fileSystemGenericRepositoryFactory;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public VideosController(ControllerServicesContext context, IFileSystemGenericRepositoryFactory fileSystemGenericRepositoryFactory)
             : base(context)
        {
            _fileSystemGenericRepositoryFactory = fileSystemGenericRepositoryFactory;
            _hostingEnvironment = context.HostingEnvironment;
        }

        [NoAjaxRequest]
        [ResponseCache(CacheProfileName = "Cache24HourParams")]
        [Route("")]
        public virtual async Task<ActionResult> Index(int p = 1, int pageSize = 10, string orderColumn = nameof(FileInfo.LastWriteTime) + " desc")
        {
            try
            {

                string physicalPath = _hostingEnvironment.MapWwwPath(AppSettings.Folders[Folders.Videos]);

                if (!System.IO.Directory.Exists(physicalPath))
                    return HandleReadException();

                var response = await GetVideosViewModel(physicalPath, p, pageSize, orderColumn);

                ViewBag.Album = new DirectoryInfo(_hostingEnvironment.MapWwwPath(AppSettings.Folders[Folders.Videos]));

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
        [ActionName("Index")]
        [ResponseCache(CacheProfileName = "Cache24HourParams")]
        [Route("")]
        public virtual async Task<ActionResult> IndexList(int p = 1, int pageSize = 10, string orderColumn = nameof(FileInfo.LastWriteTime) + " desc")
        {
            try
            {
                string physicalPath = _hostingEnvironment.MapWwwPath(AppSettings.Folders[Folders.Videos]);

                if (!System.IO.Directory.Exists(physicalPath))
                    return HandleReadException();

                var response = await GetVideosViewModel(physicalPath, p, pageSize, orderColumn);

                return PartialView("_VideoAjax", response);
            }
            catch
            {
                return HandleReadException();
            }
        }

        private async Task<WebApiPagedResponseDto<FileInfo>> GetVideosViewModel(string physicalPath, int page = 1, int pageSize = 40, string orderBy = nameof(FileInfo.LastWriteTime) + " desc")
        {
            var cts = TaskHelper.CreateChildCancellationTokenSource(ClientDisconnectedToken());

            var repository = _fileSystemGenericRepositoryFactory.CreateFileRepository(cts.Token, physicalPath, true, "*.*", ".mp4", ".avi", ".txt");

            var data = await repository.GetAllAsync(UIHelper.GetOrderByIQueryableDelegate<FileInfo>(orderBy), (page - 1) * pageSize, pageSize);
            var total = await repository.GetCountAsync(null);

            var response = new WebApiPagedResponseDto<FileInfo>
            {
                Page = page,
                PageSize = pageSize,
                Records = total,
                Rows = data.ToList(),
                OrderBy = orderBy
            };

            return response;
        }

    }
}
