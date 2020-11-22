using AspNetCore.Mvc.Extensions.DomainEvents.Subscriptions;
using AspNetCore.Mvc.Extensions.Json;
using AspNetCore.Mvc.Extensions.Validation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace AspNetCore.Mvc.Extensions.Cqrs
{
    //No service scopes required.
    //When triggered from a Controller the ASP.NET Core Request Scope will be used. Each Dispatch = Unit of Work.
    //when triggered from a Pre Commit Domain Event Handler the Parent Scope (Request, Domain Event Mediator or Integration Event Mediator) will be used. Parent Unit of Work = Unit of Work.
    //when triggered from a Post Commit Domain Event Handler the Domain Event Mediator Scope will be used. Domain Event Handle = Unit of Work.
    //When triggered from an Integration Event Handler the Integration Event Mediator Scope will be used. Integration Event = Unit of Work.

    public sealed class CqrsMediator : ICqrsMediator
    {
        private readonly IServiceProvider _provider;
        private readonly JsonOptions _jsonOptions;

        public ICqrsCommandSubscriptionsManager CqrsCommandSubscriptionManager { get; }
        public ICqrsQuerySubscriptionsManager CqrsQuerySubscriptionManager { get; }

        public CqrsMediator(IServiceProvider provider, ICqrsCommandSubscriptionsManager cqrsCommandSubscriptionManager, ICqrsQuerySubscriptionsManager cqrsQuerySubscriptionManager, IOptions<JsonOptions> jsonOptions)
        {
            _provider = provider;
            CqrsCommandSubscriptionManager = cqrsCommandSubscriptionManager;
            CqrsQuerySubscriptionManager = cqrsQuerySubscriptionManager;
            _jsonOptions = jsonOptions.Value;
        }

        public async Task<Result<dynamic>> DispatchCommandAsync(string commandName, object command, CancellationToken cancellationToken = default)
        {
            var payload = JsonSerializer.Serialize(command, _jsonOptions.JsonSerializerOptions);

            var subscription = CqrsCommandSubscriptionManager.GetSubscriptionsForCommand(commandName).First();
            Type handlerType = subscription.HandlerType;

            //dynamic handler = _provider.GetService(handlerType);
            dynamic handler = subscription.CreateHandler(_provider);

            dynamic typedPayload = null;
            if (subscription.IsDynamic)
            {
                typedPayload = JsonSerializer.Deserialize<dynamic>(payload, _jsonOptions.JsonSerializerOptions);
            }
            else
            {
                typedPayload = JsonSerializer.Deserialize(payload, subscription.CommandType, _jsonOptions.JsonSerializerOptions);
            }

            Result<dynamic> result = await handler.HandleAsync(commandName, typedPayload, cancellationToken);
            return result;
        }

        public async Task<Result<R>> DispatchAsync<R>(ICommand<R> command, CancellationToken cancellationToken = default)
        {
            var subscription = CqrsCommandSubscriptionManager.GetSubscriptionsForCommand(command).First();
            Type handlerType = subscription.HandlerType;//Interface OR Concrete. 
            var commandName = subscription.CommandName;

            //dynamic handler = _provider.GetService(handlerType);
            dynamic handler = subscription.CreateHandler(_provider);

            Result<R> result = await handler.HandleAsync(commandName, (dynamic)command, cancellationToken);

            return result;
        }

        public async Task<Result<dynamic>> DispatchQueryAsync(string queryName, object query, CancellationToken cancellationToken = default)
        {
            var payload = JsonSerializer.Serialize(query, _jsonOptions.JsonSerializerOptions);

            var subscription = CqrsQuerySubscriptionManager.GetSubscriptionsForQuery(queryName).First();
            Type handlerType = subscription.HandlerType;

            //dynamic handler =  _provider.GetService(handlerType);
            dynamic handler = subscription.CreateHandler(_provider);

            dynamic typedPayload = null;
            if (subscription.IsDynamic)
            {
                typedPayload = JsonSerializer.Deserialize<dynamic>(payload, _jsonOptions.JsonSerializerOptions);
            }
            else
            {
                typedPayload = JsonSerializer.Deserialize(payload, subscription.QueryType, _jsonOptions.JsonSerializerOptions);
            }

            Result<dynamic> result = await handler.HandleAsync(queryName, typedPayload, cancellationToken);
            return result;
        }

        public async Task<Result<R>> DispatchAsync<R>(IQuery<R> query, CancellationToken cancellationToken = default)
        {
            var subscription = CqrsQuerySubscriptionManager.GetSubscriptionsForQuery(query).First();
            Type handlerType = subscription.HandlerType;
            var queryName = subscription.QueryName;

            //dynamic handler = _provider.GetService(handlerType);
            dynamic handler = subscription.CreateHandler(_provider);

            Result<R> result = await handler.HandleAsync(queryName, (dynamic)query, cancellationToken);

            return result;
        }
    }
}
