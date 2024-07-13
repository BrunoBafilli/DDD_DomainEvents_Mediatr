using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Events.Interfaces;
using Domain.Events.UserEvents;

namespace Domain.Entities
{
    public class UserEntity
    {
        //Events
        private readonly List<IDomainEvent> _createdUserEvents = new List<IDomainEvent>();

        //Props
        public int Id { get; private set; }
        public string Name { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public IReadOnlyCollection<IDomainEvent> CreatedUserEvents => _createdUserEvents;

        //Ctor
        public UserEntity(int id, string name)
        {
            Id = id;
            Name = name;
            CreatedAt = DateTime.Now;
            CreatedUser();
        }

        public void CreatedUser()
        {
            var userDomainEvent = new UserDomainEvent(Id, CreatedAt);
            RegisterCreatedUserEvent(userDomainEvent);
        }

        private void RegisterCreatedUserEvent(UserDomainEvent userDomainEvent)
        {
            _createdUserEvents.Add(userDomainEvent);
        }
    }
}
