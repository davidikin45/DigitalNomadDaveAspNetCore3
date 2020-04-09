using AspNetCore.Mvc.Extensions.Dtos;
using AspNetCore.Mvc.Extensions.Helpers;
using AspNetCore.Mvc.Extensions.ViewComponents;
using DND.Application.CMS.Faqs.Dtos;
using DND.Application.CMS.Faqs.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DND.Web.Areas.Frontend.Controllers.Faq.ViewComponents
{
    public class FaqViewComponent : ViewComponentBase
    {
        private readonly IFaqApplicationService Service;

        public FaqViewComponent(IFaqApplicationService service)
        {
            Service = service;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var cts = TaskHelper.CreateChildCancellationTokenSource(ClientDisconnectedToken());

            IEnumerable<FaqDto> data = null;
            int total = 0;

            data = await Service.GetAllAsync(cts.Token, nameof(FaqDto.CreatedOn) + " asc", null, null, false, null);
            total = await Service.GetCountAsync(cts.Token);


            var response = new WebApiPagedResponseDto<FaqDto>
            {
                Page = 1,
                PageSize = total,
                Records = total,
                Rows = data.ToList()
            };

            ViewBag.Page = 1;
            ViewBag.PageSize = total;

            return View(response);
        }
    }
}
