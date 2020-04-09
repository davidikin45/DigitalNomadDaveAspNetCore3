using AspNetCore.Mvc.Extensions.Data.RepositoryFileSystem;
using AspNetCore.Mvc.Extensions.Helpers;
using AspNetCore.Mvc.Extensions.ViewComponents;
using DND.Application.CMS.Testimonials.Dtos;
using DND.Application.CMS.Testimonials.Services;
using DND.Web.Areas.Frontend.Controllers.Testimonial.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DND.Web.Areas.Frontend.Controllers.Testimonial.ViewComponents
{
    public class TestimonialViewComponent : ViewComponentBase
    {
        private readonly ITestimonialApplicationService _testimonialService;
        private readonly IFileSystemGenericRepositoryFactory _fileSystemRepository;

        public TestimonialViewComponent(ITestimonialApplicationService testimonialService, IFileSystemGenericRepositoryFactory fileSystemRepository)
        {
            _fileSystemRepository = fileSystemRepository;
            _testimonialService = testimonialService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            string orderColumn = nameof(TestimonialDto.CreatedOn) + " desc";

            var cts = TaskHelper.CreateChildCancellationTokenSource(ClientDisconnectedToken());

            IEnumerable<TestimonialDto> testimonials = null;

            var testimonialsTask = _testimonialService.GetAllAsync(cts.Token, orderColumn, null, null);

            await TaskHelper.WhenAllOrException(cts, testimonialsTask);

            testimonials = testimonialsTask.Result;


            var viewModel = new TestimonialsViewModel
            {
                Testimonials = testimonials.ToList()
            };

            return View(viewModel);
        }

    }
}
