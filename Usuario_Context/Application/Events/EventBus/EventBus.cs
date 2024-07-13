using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Events.Interfaces;
using Domain.Events.UserEvents;
using MediatR;

namespace Application.Events.EventBus
{
    public class EventBus : IEventBus
    {
        private readonly IMediator _mediator;

        public EventBus(IMediator mediator)
        {
            _mediator = mediator;
        }

        public Task Publish<T>(T @event) where T : IDomainEvent
        {
            return _mediator.Publish(@event);
        }
    }
}
