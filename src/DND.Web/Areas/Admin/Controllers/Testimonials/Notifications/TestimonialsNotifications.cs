using AspNetCore.Mvc.Extensions.SignalR;
using DND.Application.CMS.Testimonials.Dtos;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace DND.Web.Areas.Admin.Controllers.Testimonial.Notifications
{
    public class TestimonialsNotifications : ISignalRHubMap
    {
        public void MapHub(IEndpointRouteBuilder routes, string signalRUrlPrefix)
        {
            routes.MapHub<ApiNotificationHub<TestimonialDto>>(signalRUrlPrefix + "/cms/testimonials/notifications");
        }
    }
}
