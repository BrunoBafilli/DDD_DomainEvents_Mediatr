using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Events.EventBus;
using Application.Events.User.Handlers;
using Application.Services.User;
using Domain.Events.Interfaces;
using Domain.Events.UserEvents;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.IOC.ContainerDI
{
    public class DIConfig
    {
        private static ServiceProvider _serviceProvider;

        static DIConfig()
        {
            var services = new ServiceCollection();
            RegisterServices(services);
            _serviceProvider = services.BuildServiceProvider();
        }

        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IEventBus, EventBus>();
            services.AddScoped<IUserService, UserService>();

            // Carregamento do assembly de Aplicação para MediatR
            var myHandlers = AppDomain.CurrentDomain.Load("Application");

            // Adição de MediatR
            services.AddMediatR(myHandlers);
        }

        public static T GetService<T>()
        {
            return _serviceProvider.GetService<T>();
        }
    }
}
