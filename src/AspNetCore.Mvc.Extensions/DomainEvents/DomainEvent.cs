using AspNetCore.Mvc.Extensions.Validation;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace AspNetCore.Mvc.Extensions.DomainEvents
{
    [NotMapped]
    public class DomainEvent
    {
        public DomainEvent()
        {
            Id = Guid.NewGuid();
            CreationDate = DateTime.UtcNow;
        }

        public Guid Id { get; set; }

        public DateTime CreationDate { get; set; }
    }
}
