using Domain.Events.UserEvents;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Events.User.Handlers
{
    public class SendSmsOnUserCreateHandler : INotificationHandler<UserDomainEvent>
    {
        public Task Handle(UserDomainEvent notification, CancellationToken cancellationToken)
        {
            Console.WriteLine($"SMS: {notification.Id} - {notification.OcurredOn}");

            return Task.CompletedTask;
        }
    }
}
