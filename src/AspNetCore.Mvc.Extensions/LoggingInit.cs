using Microsoft.Extensions.Configuration;
using Serilog;
using Serilog.Core;
using Serilog.Events;
using Serilog.Exceptions;
using Serilog.Formatting.Compact;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace AspNetCore.Mvc.Extensions.Logging
{
    public class LoggingInit
    {
        //Serilog
        //Serilog.AspNetCore - UsingSerilog()
        //Serilog.Enrichers.Environment
        //Serilog.Exceptions
        //Serilog.Settings.Configuration
        //Serilog.Sinks.Console
        //Serilog.Sinks.Debug
        //Serilog.Sinks.Elasticsearch
        //Serilog.Sinks.File - By default keeps logs for 31 days
        //Serilog.Sinks.Seq

        //Serilog.Formatting.Compact
        //Cant have formatter and outputTemplate - https://stackoverflow.com/questions/48646420/serilog-jsonformatter-in-an-asp-net-core-2-not-being-applied-from-appsettings-fi
        //"formatter": "Serilog.Formatting.Compact.CompactJsonFormatter, Serilog.Formatting.Compact"
        //"formatter": "Serilog.Formatting.Compact.RenderedCompactJsonFormatter, Serilog.Formatting.Compact"
        //"formatter": "Serilog.Formatting.Elasticsearch.ElasticsearchJsonFormatter, Serilog.Formatting.Elasticsearch"

        //Category and Events are logical grouping
        //Easy to see all log entries of a certain type of event.
        //public static EventId GetMany = new EventId(10001, "GetManyFromProc")

        //Scopes - shared content included in each log entry even if in another assembly.
        //using(_logger.BeginScope("Starting operation for {UserId}", userId))

        //:l removes quoted strings. Log.Information("User is {username}", username); becomes User is Dave rather than User is "Dave".

        //:j instructs Serilog to serialize embedded data as JSON, instead of Serilog’s C#-style pretty printing.
        //Log.Information("User is {@username}", user); The @ operator tells Serilog to serialize the object passed in, rather than convert it using ToString()


        //High Performance Logging
        //https://docs.microsoft.com/en-us/aspnet/core/fundamentals/logging/loggermessage?view=aspnetcore-2.2

        //http://mygeekjourney.com/asp-net-core/integrating-serilog-asp-net-core/
        //https://www.carlrippon.com/asp-net-core-logging-with-serilog-and-sql-server/
        //https://www.humankode.com/asp-net-core/logging-with-elasticsearch-kibana-asp-net-core-and-docker
        //https://nblumhardt.com/2019/10/serilog-in-aspnetcore-3/
        /// <summary>
        /// Trace = 0
        /// Debug = 1
        /// Information = 2 -- LogFactory Default -- Developement Standard
        /// Warning = 3 -- Production Standard
        /// Error = 4 -- Generally Unhandled Exception
        /// Critical = 5 -- Complete Application Fail, DB unavailable
        /// </summary>
        /// 
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void Init(IConfiguration configuration, string elasticUri = null, string seqUri = null)
        {
            //var name = Assembly.GetExecutingAssembly().GetName();
            var name = Assembly.GetCallingAssembly().GetName();
            //var name = AssemblyHelper.GetEntryAssembly().GetName();
            var loggerConfiguration = new LoggerConfiguration()
             .ReadFrom.Configuration(configuration)
             //.MinimumLevel.Information()
             //.MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
             //.MinimumLevel.Override("Microsoft.Hosting.Lifetime", LogEventLevel.Information)
             .Enrich.FromLogContext() //using (LogContext.PushProperty("A", 1))
             .Enrich.WithExceptionDetails() //Include exception.data for saving exception extra data.
             .Enrich.WithMachineName() //Environment.MachineName
             .Enrich.WithProperty("Assembly", $"{name.Name}")
             .Enrich.WithProperty("Version", $"{name.Version}")
             //.WriteTo.Console(outputTemplate: "[{Timestamp:HH:mm:ss.fff}] {Level:u3} - {Message:lj}{NewLine}{Exception}")
             //.WriteTo.Debug(outputTemplate: "[{Timestamp:HH:mm:ss.fff}] {Level:u3} - {Message:lj}{NewLine}{Exception}")
             //.WriteTo.File(@"logs\log.txt", rollingInterval: RollingInterval.Day, outputTemplate: "[{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz}] {Level:u3} - {Message:lj}{NewLine}{Exception}")
             //.WriteTo.File(new CompactJsonFormatter(), @"logs\log.txt", rollingInterval: RollingInterval.Day) // json message template
             //.WriteTo.File(new RenderedCompactJsonFormatter(), @"logs\log.txt", rollingInterval: RollingInterval.Day) // json rendered message
             .AddElasticSearchLogging(elasticUri)
             .AddElasticSearchLogging(configuration)
             .AddSeqLogging(seqUri)
             .AddSeqLogging(configuration);

            //Serilog will use Log.Logger by default when using UseSerilog()
            Log.Logger = loggerConfiguration.CreateLogger();
        }
    }
}
