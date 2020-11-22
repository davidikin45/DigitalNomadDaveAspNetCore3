using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.Extensions.Options;
using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace AspNetCore.Mvc.Extensions.HealthChecks
{
    public class HealthCheckGenericPublisher : IHealthCheckPublisher
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly HealthCheckGenericPublisherOptions _options;
        private readonly JsonOptions _jsonOptions;

        public HealthCheckGenericPublisher(IServiceProvider serviceProvider, IOptions<HealthCheckGenericPublisherOptions> options, IOptions<JsonOptions> jsonOptions)
        {
            _serviceProvider = serviceProvider;
            _options = options.Value;
            _jsonOptions = jsonOptions.Value;
        }

        public Task PublishAsync(HealthReport report, CancellationToken cancellationToken)
        {
            var message = JsonSerializer.Serialize(report, _jsonOptions.JsonSerializerOptions);

            return _options.PublishAsync(_serviceProvider, message);
        }
    }

    public class HealthCheckGenericPublisherOptions
    {
        public Func<IServiceProvider, string, Task> PublishAsync { get; set; } = (_, __) => Task.CompletedTask;
    }
}
