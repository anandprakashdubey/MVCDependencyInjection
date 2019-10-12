using Autofac;
using Autofac.Integration.Mvc;
using DI.WEB.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DI.WEB
{
    public class ContainerConfig
    {
        internal static void RegisterConfig() //(System.Web.Http.HttpConfiguration httpConfiguration) //In case of Web API DI
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            //builder.RegisterApiControllers(typeof(MvcApplication).Assembly); //In case of Web API DI
            builder.RegisterType<InMemoryRestuarantData>()
                .As<IRestuarant>()
                .SingleInstance();

            // FOR SQL Server DB Connection - 
            //builder.RegisterType<SQLRestuarantData>()
            //    .As<IRestuarant>()
            //    .InstancePerRequest();
            //builder.RegisterType<MVCApplicationDbContext>().InstancePerRequest();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            //httpConfiguration.DependencyResolver = new AutofacWebAPiDependencyResolver(container) // From AutoFac WebApi (Autofac.WebApi2) package , In case of Web API DI

        }
    }
}