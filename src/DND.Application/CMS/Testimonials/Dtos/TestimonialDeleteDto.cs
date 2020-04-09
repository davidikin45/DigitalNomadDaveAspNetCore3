using AspNetCore.Mvc.Extensions.Dtos;
using AspNetCore.Mvc.Extensions.Mapping;
using DND.Domain.CMS.Testimonials;

namespace DND.Application.CMS.Testimonials.Dtos
{
    public class TestimonialDeleteDto : DtoAggregateRootBase<int>, IMapFrom<Testimonial>, IMapTo<Testimonial>
    {

    }
}
