using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace AspNetCore.Mvc.Extensions.HealthChecks
{
    public static class HealthCheckJsonResponseWriter
    {
        public static Task WriteResponse(HttpContext c, HealthReport r)
        {
            c.Response.ContentType = "application/json";
            var result = new List<ServiceStatus>();
            result.Add(new ServiceStatus { Service = "OverAll", Status = (int)r.Status, StatusDescription = r.Status.ToString(), Duration = r.TotalDuration.TotalSeconds.ToString("0:0.00") });
            result.AddRange(
                r.Entries.Select(
                    e => new ServiceStatus
                    {
                        Service = e.Key,
                        Status = (int)e.Value.Status,
                        StatusDescription = e.Value.Status.ToString(),
                        Data = e.Value.Data.Select(k => k).ToList(),
                        Duration = e.Value.Duration.TotalSeconds.ToString("0:0.00"),
                        Exception = e.Value.Exception?.Message
                    }
                )
            );

            var jsonOptions = c.RequestServices.GetRequiredService<IOptions<JsonOptions>>().Value;

            var json = JsonSerializer.Serialize(result, jsonOptions.JsonSerializerOptions);

            return c.Response.WriteAsync(json);
        }

        public static Task WriteJsonResponse(HttpContext context, HealthReport report)
        {
            context.Response.ContentType = "application/json; charset=utf-8";

            var options = new JsonWriterOptions { Indented = true };

            using var writer = new Utf8JsonWriter(context.Response.BodyWriter, options);

            writer.WriteStartObject();
            writer.WriteString("status", report.Status.ToString());

            if (report.Entries.Count > 0)
            {
                writer.WriteStartArray("results");

                foreach (var (key, value) in report.Entries)
                {
                    writer.WriteStartObject();
                    writer.WriteString("key", key);
                    writer.WriteString("status", value.Status.ToString());
                    writer.WriteString("description", value.Description);
                    writer.WriteStartArray("data");
                    foreach (var (dataKey, dataValue) in value.Data.Where(d => d.Value is object))
                    {
                        writer.WriteStartObject();
                        writer.WritePropertyName(dataKey);
                        JsonSerializer.Serialize(writer, dataValue, dataValue.GetType());
                        writer.WriteEndObject();
                    }
                    writer.WriteEndArray();
                    writer.WriteEndObject();
                }

                writer.WriteEndArray();
            }

            writer.WriteEndObject();

            return Task.CompletedTask;
        }
    }
}
