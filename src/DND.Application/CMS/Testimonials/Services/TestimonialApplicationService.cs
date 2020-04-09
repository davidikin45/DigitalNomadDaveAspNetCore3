using AspNetCore.Mvc.Extensions.Application;
using AspNetCore.Mvc.Extensions.Authorization;
using AspNetCore.Mvc.Extensions.Context;
using AspNetCore.Mvc.Extensions.SignalR;
using DND.Application.CMS.Testimonials.Dtos;
using DND.Domain;
using DND.Domain.CMS.Testimonials;
using Microsoft.AspNetCore.SignalR;

namespace DND.Application.CMS.Testimonials.Services
{
    [ResourceCollection(ResourceCollections.CMS.Testimonials.CollectionId)]
    public class TestimonialApplicationService : ApplicationServiceEntityBase<Testimonial, TestimonialDto, TestimonialDto, TestimonialDto, TestimonialDeleteDto, IAppUnitOfWork>, ITestimonialApplicationService
    {
        public TestimonialApplicationService(ApplicationervicesContext context, IAppUnitOfWork appUnitOfWork, IHubContext<ApiNotificationHub<TestimonialDto>> hubContext)
        : base(context, appUnitOfWork, hubContext)
        {

        }

    }
}
