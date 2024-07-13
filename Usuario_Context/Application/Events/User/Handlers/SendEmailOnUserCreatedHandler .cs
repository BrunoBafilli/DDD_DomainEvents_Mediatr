using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Events.Interfaces;
using Domain.Events.UserEvents;
using MediatR;

namespace Application.Events.User.Handlers
{
    public class SendEmailOnUserCreatedHandler : INotificationHandler<UserDomainEvent>
    {
        public Task Handle(UserDomainEvent notification, CancellationToken cancellationToken)
        {
            Console.WriteLine($"Email: {notification.Id} - {notification.OcurredOn}");

            return Task.CompletedTask;
        }
    }
}
