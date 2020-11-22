using AspNetCore.Mvc.Extensions.Application;
using AspNetCore.Mvc.Extensions.Authorization;
using AspNetCore.Mvc.Extensions.Context;
using AspNetCore.Mvc.Extensions.SignalR;
using DND.Application.CMS.Faqs.Dtos;
using DND.Domain;
using DND.Domain.CMS.Faqs;
using Microsoft.AspNetCore.SignalR;

namespace DND.Application.CMS.Faqs.Services
{
    public class FaqApplicationService : ApplicationServiceEntityBase<Faq, FaqDto, FaqDto, FaqDto, FaqDeleteDto, IAppUnitOfWork>, IFaqApplicationService
    {
        public FaqApplicationService(ApplicationServiceServicesContext context, IAppUnitOfWork appUnitOfWork, IHubContext<ApiNotificationHub<FaqDto>> hubContext)
        : base(context, appUnitOfWork, hubContext)
        {

        }
    }
}
