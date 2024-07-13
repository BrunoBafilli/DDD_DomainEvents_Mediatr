using Application.Services.User;
using Domain.Entities;
using Infrastructure.IOC.ContainerDI;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var userService = DIConfig.GetService<IUserService>();

            userService.CreateUser(new UserEntity(1, "bruno"));
        }
    }
}