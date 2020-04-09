using AspNetCore.Mvc.Extensions.Application;
using DND.Application.CMS.Faqs.Dtos;

namespace DND.Application.CMS.Faqs.Services
{
    public interface IFaqApplicationService : IApplicationServiceEntity<FaqDto, FaqDto, FaqDto, FaqDeleteDto>
    {
    }
}
