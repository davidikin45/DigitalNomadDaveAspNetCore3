using AspNetCore.Mvc.Extensions.Context;
using AspNetCore.Mvc.Extensions.Controllers.Mvc;
using AspNetCore.Mvc.Extensions.Data.RepositoryFileSystem;
using AspNetCore.Mvc.Extensions.Dtos;
using AspNetCore.Mvc.Extensions.Features;
using AspNetCore.Mvc.Extensions.Helpers;
using AutoMapper;
using DND.Application.Blog.Locations.Dtos;
using DND.Application.Blog.Locations.Services;
using DND.Domain.Blog.Locations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.FeatureManagement.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace DND.Web.Areas.Frontend.Controllers.Countries
{
    [Area("Frontend")]
    [FeatureGate(FeatureFlags.Countries)]
    [Route("countries")]
    public class CountriesController : MvcControllerBase
    {
        private readonly ILocationApplicationService _locationService;

        public CountriesController(ControllerServicesContext context, ILocationApplicationService locationService)
             : base(context)
        {
            _locationService = locationService;
        }

        [ResponseCache(CacheProfileName = "Cache24HourParams")]
        [Route("")]
        public async Task<ActionResult> Index(int p = 1, int pageSize = 20, string orderBy = nameof(LocationDto.Name) + " asc", string search = "")
        {
            var cts = TaskHelper.CreateChildCancellationTokenSource(ClientDisconnectedToken());

            try
            {
                var dataTask = _locationService.SearchAsync(cts.Token, null, LocationType.Country.ToString() + "&" + search, l => !string.IsNullOrEmpty(l.Album) && !string.IsNullOrEmpty(l.UrlSlug), orderBy, p, pageSize);

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
    }
}
