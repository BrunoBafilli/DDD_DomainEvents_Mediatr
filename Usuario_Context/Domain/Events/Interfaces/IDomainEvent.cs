using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Domain.Events.Interfaces
{
    public interface IDomainEvent : INotification
    {
        public int Id { get; set; }
        public DateTime OcurredOn { get; set; }
    }
}
