using AspNetCore.Mvc.Extensions.Application;
using AspNetCore.Mvc.Extensions.Authorization;
using AspNetCore.Mvc.Extensions.Context;
using AspNetCore.Mvc.Extensions.Helpers;
using AspNetCore.Mvc.Extensions.SignalR;
using AspNetCore.Mvc.Extensions.Validation;
using DND.Application.Blog.Locations.Dtos;
using DND.Domain;
using DND.Domain.Blog.Locations;
using Microsoft.AspNetCore.SignalR;
using System.Threading;
using System.Threading.Tasks;

namespace DND.Application.Blog.Locations.Services
{
    public class LocationApplicationService : ApplicationServiceEntityBase<Location, LocationDto, LocationDto, LocationDto, LocationDeleteDto, IAppUnitOfWork>, ILocationApplicationService
    {
        public LocationApplicationService(ApplicationServiceServicesContext context, IAppUnitOfWork unitOfWork, IHubContext<ApiNotificationHub<LocationDto>> hubContext)
        : base(context, unitOfWork, hubContext)
        {

        }

        public override Task<Result<LocationDto>> CreateAsync(LocationDto dto, string createdBy, CancellationToken cancellationToken)
        {
            if (string.IsNullOrEmpty(dto.UrlSlug))
            {
                dto.UrlSlug = UrlSlugger.ToUrlSlug(dto.Name);
            }

            return base.CreateAsync(dto, createdBy, cancellationToken);
        }

        public async Task<LocationDto> GetLocationAsync(string urlSlug, CancellationToken cancellationToken)
        {
            var bo = await UnitOfWork.LocationRepository.GetFirstAsync(cancellationToken, t => t.UrlSlug.Equals(urlSlug));
            return Mapper.Map<LocationDto>(bo);
        }

        public override Task<Result> UpdateAsync(object id, LocationDto dto, string updatedBy, CancellationToken cancellationToken)
        {
            if (string.IsNullOrEmpty(dto.UrlSlug))
            {
                dto.UrlSlug = UrlSlugger.ToUrlSlug(dto.Name);
            }

            return base.UpdateAsync(id, dto, updatedBy, cancellationToken);
        }
    }
}
