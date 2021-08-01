using Autofac;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using AutoMapper.Internal;
namespace BeSpokedBikes.Common
{
    public static class ContainerBuilderExtensions
    {
        public static void RegisterMediator(this ContainerBuilder builder)
        {
            Assembly assembly = Assembly.GetCallingAssembly();

            builder.RegisterAssemblyTypes(assembly).Where(t => t.ImplementsGenericInterface(typeof(IRequestHandler<,>))).AsClosedTypesOf(typeof(IRequestHandler<,>));

            // Register the DomainEventHandler classes (they implement INotificationHandler<>) in assembly holding the Domain Events
            builder.RegisterAssemblyTypes(assembly).Where(t => t.ImplementsGenericInterface(typeof(INotificationHandler<>))).AsClosedTypesOf(typeof(INotificationHandler<>));

            // Register the Command's Validators (Validators based on FluentValidation library)
            builder.RegisterAssemblyTypes(assembly).Where(t => t.IsClosedTypeOf(typeof(IValidator<>))).AsImplementedInterfaces();

            builder.RegisterAssemblyTypes(typeof(IMediator).GetTypeInfo().Assembly).AsImplementedInterfaces();

            builder.Register<ServiceFactory>(context =>
            {
                var componentContext = context.Resolve<IComponentContext>();
                return t => { object o; return componentContext.TryResolve(t, out o) ? o : null; };
            });



        }
    }
}
