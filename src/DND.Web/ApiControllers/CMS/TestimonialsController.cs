using AspNetCore.Mvc.Extensions.Authorization;
using AspNetCore.Mvc.Extensions.Context;
using AspNetCore.Mvc.Extensions.Controllers.Api;
using DND.Application;
using DND.Application.CMS.Testimonials.Dtos;
using DND.Application.CMS.Testimonials.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace DND.Web.ApiControllers.CMS
{
    [ResourceCollection(ResourceCollections.CMS.Testimonials.CollectionId)]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/cms/testimonials")]
    public class TestimonialsController : ApiControllerEntityAuthorizeBase<TestimonialDto, TestimonialDto, TestimonialDto, TestimonialDeleteDto, ITestimonialApplicationService>
    {
        public TestimonialsController(ControllerServicesContext context, ITestimonialApplicationService service)
            : base(context, service)
        {

        }
    }
}
