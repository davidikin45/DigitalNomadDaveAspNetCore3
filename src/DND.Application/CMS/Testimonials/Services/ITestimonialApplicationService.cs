using AspNetCore.Mvc.Extensions.Application;
using DND.Application.CMS.Testimonials.Dtos;

namespace DND.Application.CMS.Testimonials.Services
{
    public interface ITestimonialApplicationService : IApplicationServiceEntity<TestimonialDto, TestimonialDto, TestimonialDto, TestimonialDeleteDto>
    {
        
    }
}
