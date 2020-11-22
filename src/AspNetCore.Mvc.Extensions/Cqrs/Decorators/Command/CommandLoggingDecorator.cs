using AspNetCore.Mvc.Extensions.Validation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace AspNetCore.Mvc.Extensions.Cqrs.Decorators.Command
{
    public sealed class CommandLoggingDecorator<TCommand, TResult> : ICommandHandler<TCommand, TResult>
    {
        private readonly ILogger<TCommand> _logger;
        private readonly ICommandHandler<TCommand, TResult> _handler;
        private readonly JsonOptions _jsonOptions;

        public CommandLoggingDecorator(ICommandHandler<TCommand, TResult> handler, ILogger<TCommand> logger, IOptions<JsonOptions> jsonOptions)
        {
            _logger = logger;
            _handler = handler;
            _jsonOptions = jsonOptions.Value;
        }

        public Task<Result<TResult>> HandleAsync(string commandName, TCommand command, CancellationToken cancellationToken = default)
        {
            string commandJson = JsonSerializer.Serialize(command, _jsonOptions.JsonSerializerOptions);

            // Use proper logging here
            _logger.LogInformation($"Command of type {command.GetType().Name}: {commandJson}");

            return _handler.HandleAsync(commandName, command, cancellationToken);
        }
    }
}
