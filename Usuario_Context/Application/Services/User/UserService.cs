using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Events.EventBus;
using Domain.Entities;
using Domain.Events.UserEvents;

namespace Application.Services.User
{
    public class UserService : IUserService
    {
        private readonly IEventBus _eventBus;

        public UserService(IEventBus eventBus)
        {
            _eventBus = eventBus;
        }

        public async Task CreateUser(UserEntity user)
        {
            UserEntity userEntity = new UserEntity(user.Id, user.Name);

            foreach (var userEntityCreatedUserEvent in userEntity.CreatedUserEvents)
            {
                if (userEntityCreatedUserEvent is UserDomainEvent)
                {
                    await _eventBus.Publish(userEntityCreatedUserEvent);
                }
            }
        }
    }
}
