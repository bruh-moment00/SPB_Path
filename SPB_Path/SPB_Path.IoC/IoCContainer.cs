using Autofac;
using SPB_Path.Domain.Places.Services;
using SPB_Path.Domain.Places.Services.Interfaces;
using System;

namespace SPB_Path.IoC
{
    public class IoCContainer
    {
        public static void InitContainer(ContainerBuilder container)
        {
            container.RegisterType<PlacesService>().As<IPlacesService>().SingleInstance();
        }
    }
}
