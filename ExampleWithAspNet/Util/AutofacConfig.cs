using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using ExampleWithAspNet.Infrastructure;
using ExampleWithAspNet.Models;
using ExampleWithAspNet.Services;

namespace ExampleWithAspNet.Util
{
    public class AutofacConfig
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            //builder.RegisterGeneric(typeof(EFRepository<>)).As(typeof(IRepository<>))
            //    .WithParameter("dbContext", new WebObjContext());

            builder.RegisterType<WebObjContext>().As<DbContext>().InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(EFRepository<>)).As(typeof(IRepository<>)).InstancePerLifetimeScope();


            builder.RegisterType<SchoolService>().As<ISchoolService>().InstancePerLifetimeScope();
            builder.RegisterType<PersonService>().As<IPersonService>().InstancePerLifetimeScope();
            builder.RegisterType<LocationService>().As<ILocationServise>().InstancePerLifetimeScope();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

        }
    }
}