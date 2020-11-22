using AspNetCore.Mvc.Extensions.Application;
using AspNetCore.Mvc.Extensions.Authorization;
using AspNetCore.Mvc.Extensions.Context;
using AspNetCore.Mvc.Extensions.SignalR;
using DND.Application.Blog.Tags.Dtos;
using DND.Domain;
using DND.Domain.Blog.Tags;
using Microsoft.AspNetCore.SignalR;
using System.Threading;
using System.Threading.Tasks;

namespace DND.Application.Blog.Tags.Services
{
    public class TagApplicationService : ApplicationServiceEntityBase<Tag, TagDto, TagDto, TagDto, TagDeleteDto, IAppUnitOfWork>, ITagApplicationService
    {
        public TagApplicationService(ApplicationServiceServicesContext context, IAppUnitOfWork appUnitOfWork, IHubContext<ApiNotificationHub<TagDto>> hubContext)
        : base(context, appUnitOfWork, hubContext)
        {

        }

        public async Task<TagDto> GetTagAsync(string tagSlug, CancellationToken cancellationToken)
        {
            var bo = await UnitOfWork.TagRepository.GetTagAsync(tagSlug, cancellationToken);
            return Mapper.Map<TagDto>(bo);
        }
    }
}
