using AspNetCore.Mvc.Extensions;
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
using DND.Application.Blog.Locations.Dtos;
using DND.Application.Blog.Locations.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.FeatureManagement.Mvc;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DND.Web.Areas.Frontend.Controllers.Locations
{
    [Area("Frontend")]
    [FeatureGate(FeatureFlags.Locations)]
    [Route("locations")]
    public class LocationsController : MvcControllerBase
    {
        private readonly ILocationApplicationService _locationService;
        private readonly IFileSystemGenericRepositoryFactory _fileSystemGenericRepositoryFactory;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public LocationsController(ControllerServicesContext context, ILocationApplicationService locationService, IFileSystemGenericRepositoryFactory fileSystemGenericRepositoryFactory)
             : base(context)
        {
            _locationService = locationService;
            _fileSystemGenericRepositoryFactory = fileSystemGenericRepositoryFactory;
            _hostingEnvironment = context.HostingEnvironment;
        }

        [ResponseCache(CacheProfileName = "Cache24HourParams")]
        [Route("")]
        public async Task<ActionResult> Index(int p = 1, int pageSize = 20, string orderBy = nameof(LocationDto.Name) + " asc", string search = "")
        {
            var cts = TaskHelper.CreateChildCancellationTokenSource(ClientDisconnectedToken());

            try
            {
                var dataTask = _locationService.SearchAsync(cts.Token, null, search, l => !string.IsNullOrEmpty(l.Album) && !string.IsNullOrEmpty(l.UrlSlug), orderBy, p, pageSize);

                await TaskHelper.WhenAllOrException(cts, dataTask);

                var data = dataTask.Result;
                var total = data.TotalCount;

                var response = new WebApiPagedResponseDto<LocationDto>
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

        [ResponseCache(CacheProfileName = "Cache24HourParams")]
        // GET: Default/Details/5
        [Route("{urlSlug}")]
        public virtual async Task<ActionResult> Location(string urlSlug)
        {
            var cts = TaskHelper.CreateChildCancellationTokenSource(ClientDisconnectedToken());
            try
            {
                var data = await _locationService.GetLocationAsync(urlSlug, cts.Token);

                if (data == null)
                    return NotFound();

                //TODO: Locations need image paging
                string physicalPath = _hostingEnvironment.MapWwwPath(AppSettings.Folders[Folders.Gallery]) + data.Album;

                return View("Location", data);
            }
            catch (Exception ex)
            {
                if (ex is OperationCanceledException)
                {
                    throw;
                }
                else
                {
                    return HandleReadException();
                }
            }

        }

        private async Task<WebApiPagedResponseDto<FileInfo>> GetLocationViewModel(string physicalPath, int page = 1, int pageSize = 40, string orderBy = nameof(FileInfo.LastWriteTime) + " desc")
        {
            var cts = TaskHelper.CreateChildCancellationTokenSource(ClientDisconnectedToken());

            var repository = _fileSystemGenericRepositoryFactory.CreateFileRepository(cts.Token, physicalPath, true, "*.*", ".jpg", ".jpeg", ".mp4", ".avi", ".txt");

            var data = await repository.GetAllAsync(UIHelper.GetOrderByIQueryableDelegate<FileInfo>(orderBy), (page - 1) * pageSize, pageSize);
            var total =await repository.GetCountAsync(null);

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
