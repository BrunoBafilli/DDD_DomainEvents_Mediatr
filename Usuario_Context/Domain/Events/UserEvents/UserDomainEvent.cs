using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Events.Interfaces;

namespace Domain.Events.UserEvents
{
    public class UserDomainEvent : IDomainEvent
    {
        public int Id { get; set; }
        public DateTime OcurredOn { get; set; }

        public UserDomainEvent(int id, DateTime ocurredOn)
        {
            Id = id;
            OcurredOn = ocurredOn;
        }
    }
}
