using Application.Services.User;
using Domain.Entities;
using Infrastructure.IOC.ContainerDI;

var userService = DIConfig.GetService<IUserService>();

await userService.CreateUser(new UserEntity(1, "bruno"));