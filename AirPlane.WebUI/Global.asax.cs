using AirPlane.Domain.Entities;
using AirPlane.WebUI.Infrastructure;
using AirPlane.WebUI.Infrastructure.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AirPlane.WebUI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            ModelBinders.Binders.Add(typeof(Cart), new CartModelBinder());
            //ControllerBuilder.Current.SetControllerFactory(new CustomControllerFactory());
           var cFct =  ControllerBuilder.Current.GetControllerFactory();
            // ControllerBuilder.Current.DefaultNamespaces.Add("AirPlane.WebUI.Controllers.RoutingURL"); //add priority
            // ControllerBuilder.Current.SetControllerFactory(new DefaultControllerFactory(new CustomControllerActivator()));
            // ControllerBuilder.Current.SetControllerFactory(new BasedOnDefaultControllerFasctory(new CustomControllerActivator()));

           // ViewEngines.Engines.Clear();

           // ViewEngines.Engines.Add(new DebugDataViewEngine());
           // ViewEngines.Engines.Add(new CustomLocationViewEngine());
   
        }
    }
}
