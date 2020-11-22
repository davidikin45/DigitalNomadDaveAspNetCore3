using AspNetCore.Mvc.Extensions.Validation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace AspNetCore.Mvc.Extensions.Cqrs.Decorators.Command
{
    public sealed class QueryLoggingDecorator<TQuery, TResult> : IQueryHandler<TQuery, TResult>
    {
        private readonly ILogger<TQuery> _logger;
        private readonly IQueryHandler<TQuery, TResult> _handler;
        private readonly JsonOptions _jsonOptions;

        public QueryLoggingDecorator(IQueryHandler<TQuery, TResult> handler, ILogger<TQuery> logger, IOptions<JsonOptions> jsonOptions)
        {
            _logger = logger;
            _handler = handler;
            _jsonOptions = jsonOptions.Value;
        }

        public Task<Result<TResult>> HandleAsync(string commandName, TQuery query, CancellationToken cancellationToken = default)
        {
            string queryJson = JsonSerializer.Serialize(query, _jsonOptions.JsonSerializerOptions);

            // Use proper logging here
            _logger.LogInformation($"Query of type {query.GetType().Name}: {queryJson}");

            return _handler.HandleAsync(commandName, query, cancellationToken);
        }
    }
}
