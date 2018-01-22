using Autofac;
using Autofac.Integration.Mvc;
using DependencyInjectionThroughAutofac.Controllers;
using DependencyInjectionThroughAutofac.Models;
using DependencyInjectionThroughAutofac.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;


namespace DependencyInjectionThroughAutofac
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {   
            RegisterDependencies();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            //ControllerBuilder.Current.SetControllerFactory(new CustomControllerFactory());

           
        }

        private void RegisterDependencies()
        {
            //var builder = new ContainerBuilder();
            //builder.RegisterType<AutofacTestController>();
            //builder.RegisterType<EasyService>().As<IDummyService>();

            //var container = builder.Build();
            //container.Resolve<AutofacTestController>();



            var builder = new ContainerBuilder();
          
            // Register dependencies in controllers
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterType<AutofacTestController>().InstancePerRequest();
            builder.RegisterType<EasyService>().As<IDummyService>().SingleInstance();

            // Register dependencies in filter attributes
            builder.RegisterFilterProvider();

            // Register dependencies in custom views
            builder.RegisterSource(new ViewRegistrationSource());

            //// Register our Data dependencies
            //builder.RegisterModule(new DataModule("MVCWithAutofacDB"));

            var container = builder.Build();

            // Set MVC DI resolver to use our Autofac container
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
