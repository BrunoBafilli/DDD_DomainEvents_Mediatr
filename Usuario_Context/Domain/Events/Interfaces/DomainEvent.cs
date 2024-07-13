using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Events.Interfaces
{
    public class DomainEvent : IDomainEvent
    {
        public int Id { get; set; }
        public DateTime OcurredOn { get; set; }
    }
}
