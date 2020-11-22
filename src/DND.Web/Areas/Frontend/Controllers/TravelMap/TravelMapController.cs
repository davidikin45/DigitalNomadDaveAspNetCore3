using AspNetCore.Mvc.Extensions.Context;
using AspNetCore.Mvc.Extensions.Controllers.Mvc;
using AspNetCore.Mvc.Extensions.Dtos;
using AspNetCore.Mvc.Extensions.Helpers;
using DND.Application.Blog.Locations.Dtos;
using DND.Application.Blog.Locations.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.FeatureManagement.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace DND.Web.Areas.Frontend.Controllers.TravelMap
{
    [Area("Frontend")]
    [FeatureGate(FeatureFlags.TravelMap)]
    [Route("travel-map")]
    public class TravelMapController : MvcControllerBase
    {
        private readonly ILocationApplicationService Service;

        public TravelMapController(ControllerServicesContext context, ILocationApplicationService service)
            : base(context)
        {
            Service = service;
        }

        [ResponseCache(CacheProfileName = "Cache24HourNoParams")]
        [Route("")]
        public async Task<ActionResult> Index()
        {
            var cts = TaskHelper.CreateChildCancellationTokenSource(ClientDisconnectedToken());

            try
            {

                var data = await Service.GetAsync(cts.Token, l => l.ShowOnTravelMap == true, null, null, null);
                var total = await Service.GetCountAsync(cts.Token, l => l.ShowOnTravelMap);

                var response = new WebApiPagedResponseDto<LocationDto>
                {
                    Page = 1,
                    PageSize = total,
                    Records = total,
                    Rows = data.ToList(),
                    OrderBy = ""
                };

                ViewBag.Page = 1;
                ViewBag.PageSize = total;

                return View(response);
            }
            catch
            {
                return HandleReadException();
            }
        }

    }
}
