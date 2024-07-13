using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Events.Interfaces;

namespace Application.Events.EventBus
{
    public interface IEventBus
    {
        Task Publish <T>(T @event) where T : IDomainEvent;
    }
}
