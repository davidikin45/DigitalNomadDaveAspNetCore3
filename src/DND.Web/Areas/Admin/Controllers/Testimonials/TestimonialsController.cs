using AspNetCore.Mvc.Extensions.Authorization;
using AspNetCore.Mvc.Extensions.Context;
using AspNetCore.Mvc.Extensions.Controllers.Mvc;
using AutoMapper;
using DND.Application;
using DND.Application.CMS.Testimonials.Dtos;
using DND.Application.CMS.Testimonials.Services;
using Microsoft.AspNetCore.Mvc;

namespace DND.Web.Areas.Admin.Controllers.Testimonials
{
    [Area("Admin")]
    [ResourceCollection(ResourceCollections.CMS.Testimonials.CollectionId)]
    [Route("admin/cms/testimonials")]
    public class TestimonialsController : MvcControllerEntityAuthorizeBase<TestimonialDto, TestimonialDto, TestimonialDto, TestimonialDeleteDto, ITestimonialApplicationService>
    {
        public TestimonialsController(ControllerServicesContext context, ITestimonialApplicationService service)
             : base(context, true, service)
        {
        }
    }
}
