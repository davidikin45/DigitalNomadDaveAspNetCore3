
using System;

namespace AspNetCore.Mvc.Extensions.IntegrationEvents
{
    public class IntegrationEvent
    {
        public IntegrationEvent()
        {
            Id = Guid.NewGuid();
            CreationDate = DateTime.UtcNow;
        }

        public Guid Id { get; set; }

        public DateTime CreationDate { get; set; }
    }
}
