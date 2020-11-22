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
using DND.Application;
using DND.Application.Blog;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.FeatureManagement.Mvc;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DND.Web.Areas.Frontend.Controllers.BucketList
{
    [Area("Frontend")]
    [FeatureGate(FeatureFlags.BucketList)]
    [Route("bucket-list")]
    public class BucketListController : MvcControllerBase
    {
        private readonly IBlogApplicationService _blogService;
        private readonly IFileSystemGenericRepositoryFactory _fileSystemGenericRepositoryFactory;
        private readonly IWebHostEnvironment _hostingEnvironment;


        public BucketListController(ControllerServicesContext context, IBlogApplicationService blogService, IFileSystemGenericRepositoryFactory fileSystemGenericRepositoryFactory)
             : base(context)
        {
            _blogService = blogService;
            _fileSystemGenericRepositoryFactory = fileSystemGenericRepositoryFactory;
            _hostingEnvironment = context.HostingEnvironment;
        }

        [ResponseCache(CacheProfileName = "Cache24HourParams")]
        [Route("")]
        public async Task<ActionResult> Index(int p = 1, int pageSize = 100, string orderBy = nameof(FileInfo.LastWriteTime) + " desc")
        {
            var cts = TaskHelper.CreateChildCancellationTokenSource(ClientDisconnectedToken());

            try
            {
                var repository = _fileSystemGenericRepositoryFactory.CreateFileRepository(cts.Token, _hostingEnvironment.MapWwwPath(AppSettings.Folders[Folders.BucketList]), true, "*.*", ".jpg", ".jpeg", ".txt", ".mp4", ".avi");

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

    }
}
