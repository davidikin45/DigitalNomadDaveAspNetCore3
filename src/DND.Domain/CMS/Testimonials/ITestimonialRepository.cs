using AspNetCore.Mvc.Extensions.Data.Repository;
using DND.Domain.CMS.Testimonials;

namespace DND.Domain.CMS.Testimonials
{
    public interface ITestimonialRepository : IGenericRepository<Testimonial>
    {
    }
}
