using AspNetCore.Mvc.Extensions.Application;
using AspNetCore.Mvc.Extensions.Authorization;
using AspNetCore.Mvc.Extensions.Context;
using AspNetCore.Mvc.Extensions.SignalR;
using DND.Application.Blog.Authors.Dtos;
using DND.Domain;
using DND.Domain.Blog.Authors;
using Microsoft.AspNetCore.SignalR;
using System.Threading;
using System.Threading.Tasks;

namespace DND.Application.Blog.Authors.Services
{
    [ResourceCollection(ResourceCollections.Blog.Authors.CollectionId)]
    public class AuthorApplicationService : ApplicationServiceEntityBase<Author, AuthorDto, AuthorDto, AuthorDto, AuthorDeleteDto, IAppUnitOfWork>, IAuthorApplicationService
    {
        public AuthorApplicationService(ApplicationervicesContext context, IAppUnitOfWork unitOfWork, IHubContext<ApiNotificationHub<AuthorDto>> hubContext)
        : base(context, unitOfWork, hubContext)
        {

        }

        public async Task<AuthorDto> GetAuthorAsync(string authorSlug, CancellationToken cancellationToken)
        {
            var bo = await UnitOfWork.AuthorRepository.GetAuthorAsync(authorSlug, cancellationToken);
            return Mapper.Map<AuthorDto>(bo);
        }

    }
}
