using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac.Integration.WebApi;
using System.Web.Mvc;
using System.Web.Http;
using KPI.Services;
using KPI.DataAccess;
namespace KPI.Web.Api
{
    public class Bootstrapper
    {
        public static void Run(HttpConfiguration config)
        {
            KPIMapper.CreateObjectServicesMap();
            var builder = new ContainerBuilder();

            // You can register controllers all at once using assembly scanning...
            builder.RegisterApiControllers(typeof(WebApiApplication).Assembly);
            builder.RegisterModule(new DataAccessModule());
            builder.RegisterModule(new ServicesModule());

            // Set the dependency resolver to be Autofac.
            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}