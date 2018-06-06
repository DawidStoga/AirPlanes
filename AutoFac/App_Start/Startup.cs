using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using AutoFac.Infrastructure;
using AutoFac.Infrastructure.Implementation;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(AutoFac.App_Start.Startup))]

namespace AutoFac.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<Message>().As<IMessage>();
            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            app.UseAutofacMiddleware(container);

        }
    }
}
