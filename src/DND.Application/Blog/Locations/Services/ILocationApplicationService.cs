using AspNetCore.Mvc.Extensions.Application;
using DND.Application.Blog.Locations.Dtos;
using System.Threading;
using System.Threading.Tasks;

namespace DND.Application.Blog.Locations.Services
{
    public interface ILocationApplicationService : IApplicationServiceEntity<LocationDto, LocationDto, LocationDto, LocationDeleteDto>
    {
        Task<LocationDto> GetLocationAsync(string urlSlug, CancellationToken cancellationToken);
    }
}
