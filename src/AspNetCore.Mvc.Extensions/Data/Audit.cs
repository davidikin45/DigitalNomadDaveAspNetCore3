using AspNetCore.Mvc.Extensions.Domain;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace AspNetCore.Mvc.Extensions.Data
{
    public class Audit
    {
        public int Id { get; set; }
        public string User { get; set; }
        public string TableName { get; set; }
        public DateTime DateTime { get; set; }
        public string KeyValues { get; set; }
        public string OldValues { get; set; }
        public string NewValues { get; set; }
    }

    public class AuditEntry
    {
        public AuditEntry(EntityEntry entry)
        {
            Entry = entry;
        }

        public EntityEntry Entry { get; }
        public string TableName { get; set; }
        public Dictionary<string, object> KeyValues { get; } = new Dictionary<string, object>();
        public Dictionary<string, object> OldValues { get; } = new Dictionary<string, object>();
        public Dictionary<string, object> NewValues { get; } = new Dictionary<string, object>();
        public List<PropertyEntry> TemporaryProperties { get; } = new List<PropertyEntry>();

        public bool HasTemporaryProperties => TemporaryProperties.Any();

        public Audit ToAudit()
        {
            string user = null;
            DateTime dateTime = DateTime.UtcNow;
            if(Entry.Entity is IEntityAuditable entityAuditable)
            {
                user = entityAuditable.UpdatedBy;
                dateTime = entityAuditable.UpdatedOn ?? dateTime;
            }

            var audit = new Audit();
            audit.User = user;
            audit.TableName = TableName;
            audit.DateTime = dateTime;
            audit.KeyValues = JsonSerializer.Serialize(KeyValues, new JsonSerializerOptions()
            {
                WriteIndented = true,
                PropertyNameCaseInsensitive = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                DictionaryKeyPolicy = JsonNamingPolicy.CamelCase
            });
            audit.OldValues = OldValues.Count == 0 ? null : JsonSerializer.Serialize(OldValues, new JsonSerializerOptions()
            {
                WriteIndented = true,
                PropertyNameCaseInsensitive = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                DictionaryKeyPolicy = JsonNamingPolicy.CamelCase
            });
            audit.NewValues = NewValues.Count == 0 ? null : JsonSerializer.Serialize(NewValues, new JsonSerializerOptions()
            {
                WriteIndented = true,
                PropertyNameCaseInsensitive = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                DictionaryKeyPolicy = JsonNamingPolicy.CamelCase
            });
            return audit;
        }
    }
}
