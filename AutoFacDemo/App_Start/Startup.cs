using System;
using System.Reflection;
using System.Threading.Tasks;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using AutoFacDemo.Infrastructure;
using AutoFacDemo.Mappers;
using AutoMapper;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(AutoFacDemo.App_Start.Startup))]

namespace AutoFacDemo.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly).InstancePerRequest();
            builder.RegisterType<Message>().As<IMessages>();
            builder.RegisterType<Logger>().As<ILogger>();
            builder.RegisterModelBinders(Assembly.GetExecutingAssembly());
            builder.RegisterModelBinderProvider();
            builder.RegisterFilterProvider();
            builder.Register(c => Initiate.Configure()).As<IMapper>().SingleInstance();



            // MVC - Set the dependency resolver to be Autofac.

            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            app.UseAutofacMiddleware(container);
           // app.UseAutofacMvc();


            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
        }
    }
}
