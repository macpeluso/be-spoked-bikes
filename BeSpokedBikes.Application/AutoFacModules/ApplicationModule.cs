using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Autofac;
using BeSpokedBikes.Common;
using BeSpokedBikes.Infrastructure.Behaviors;
using BeSpokedBikes.Application.Queries.Products;
using BeSpokedBikes.Application.Queries.Customers;
using BeSpokedBikes.Application.Queries.SalesPeople;
using BeSpokedBikes.Application.Queries.Sales;

namespace BeSpokedBikes.Application.AutoFacModules
{
    public class ApplicationModule: Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterMediator();
            builder.RegisterType<ProductQueries>().As<IProductQueries>().InstancePerLifetimeScope();
            builder.RegisterType<CustomerQueries>().As<ICustomerQueries>().InstancePerLifetimeScope();
            builder.RegisterType<SalesPeopleQueries>().As<ISalesPeopleQueries>().InstancePerLifetimeScope();
            builder.RegisterType<SalesQueries>().As<ISalesQueries>().InstancePerLifetimeScope();

            builder.RegisterGeneric(typeof(LoggingBehavior<,>)).As(typeof(IPipelineBehavior<,>));
            builder.RegisterGeneric(typeof(ValidatorBehavior<,>)).As(typeof(IPipelineBehavior<,>));
            builder.RegisterGeneric(typeof(TransactionBehaviour<,>)).As(typeof(IPipelineBehavior<,>));
        }

    }
}
