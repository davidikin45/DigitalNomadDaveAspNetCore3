using AspNetCore.Mvc.Extensions.Cqrs.HandlersDynamic;
using AspNetCore.Mvc.Extensions.Validation;
using DND.Domain;
using System.Threading;
using System.Threading.Tasks;

namespace DND.Application
{
    public class QueryHandler : AsyncDynamicRequestResponseQueryHandler
    {
        private readonly IAppUnitOfWork _appUnitOfWork;
        public QueryHandler(IAppUnitOfWork appUnitOfWork)
        {
            _appUnitOfWork = appUnitOfWork;
        }

        public override async Task<Result<object>> HandleAsync(string queryName, dynamic query, CancellationToken cancellationToken = default)
        {
            var result = await _appUnitOfWork.AuthorRepository.GetAllAsync(default);

            return Result.Ok<object>(result);
        }

    }
}
