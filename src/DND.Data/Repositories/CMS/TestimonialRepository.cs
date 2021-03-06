﻿using AspNetCore.Mvc.Extensions.Data.Repository;
using DND.Domain.CMS.Testimonials;

namespace DND.Data.Repositories.CMS
{
    public class TestimonialRepository : GenericRepository<Testimonial>, ITestimonialRepository
    {
        public TestimonialRepository(AppContext context)
            : base(context)
        {

        }
    }
}
