using AspNetCore.Mvc.Extensions.Data.Repository;
using DND.Domain.Blog.Locations;
using System.Threading;
using System.Threading.Tasks;

namespace DND.Domain.Blog.Locations
{
    public interface ILocationRepository : IGenericRepository<Location>
    {
        Task<Location> GetLocationAsync(string urlSlug, CancellationToken cancellationToken);
    }
}
