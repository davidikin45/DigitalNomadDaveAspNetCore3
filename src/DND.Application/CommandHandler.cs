using AspNetCore.Mvc.Extensions.Cqrs.HandlersDynamic;
using AspNetCore.Mvc.Extensions.Validation;
using DND.Domain;
using DND.Domain.Blog.Authors;
using System.Threading;
using System.Threading.Tasks;

namespace DND.Application
{
    public class CommandHandler : AsyncDynamicRequestResponseCommandHandler
    {
        private readonly IAppUnitOfWork _appUnitOfWork;

        public CommandHandler(IAppUnitOfWork appUnitOfWork)
        {
            _appUnitOfWork = appUnitOfWork;
        }


        public async override Task<Result<object>> HandleAsync(string commandName, dynamic command, CancellationToken cancellationToken = default)
        {
            _appUnitOfWork.AuthorRepository.Add(new Author() { Name="David Ikin"}, "");

            await _appUnitOfWork.CompleteAsync();

            return Result.Ok<object>(null);
        }
    }
}
