using System;
using System.Threading.Tasks;
using Autofac;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(AirPlane.WebUI.Startup))]

namespace AirPlane.WebUI
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var builder = new ContainerBuilder();

            var container = builder.Build();
            app.UseAutofacMiddleware(container);

        }
    }
}
