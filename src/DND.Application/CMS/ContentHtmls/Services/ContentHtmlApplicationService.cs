using AspNetCore.Mvc.Extensions.Application;
using AspNetCore.Mvc.Extensions.Context;
using AspNetCore.Mvc.Extensions.SignalR;
using AspNetCore.Mvc.Extensions.Validation;
using DND.Application.CMS.ContentHtmls.Dtos;
using DND.Domain.CMS.ContentHtmls;
using Microsoft.AspNetCore.SignalR;
using System.Threading;
using System.Threading.Tasks;

namespace DND.Application.CMS.ContentHtmls.Services
{
    public class ContentHtmlApplicationService : ApplicationServiceEntityBase<ContentHtml, ContentHtmlDto, ContentHtmlDto, ContentHtmlDto, ContentHtmlDeleteDto, IAppUnitOfWork>, IContentHtmlApplicationService
    {
        public ContentHtmlApplicationService(ApplicationServiceServicesContext context, IAppUnitOfWork appUnitOfWork, IHubContext<ApiNotificationHub<ContentHtmlDto>> hubContext)
       : base(context, appUnitOfWork, hubContext)
        {

        }

        public override Task<Result> DeleteAsync(ContentHtmlDeleteDto dto, string deletedBy, CancellationToken cancellationToken)
        {
            return base.DeleteAsync(dto, deletedBy, cancellationToken);
        }
    }
}
