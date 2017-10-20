using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AirPlane.WebUI.Infrastructure
{
    public class BasedOnDefaultControllerFactory:DefaultControllerFactory
    {
        public BasedOnDefaultControllerFactory(IControllerActivator controllerActivator):base(controllerActivator)
        {

        }

        protected override Type GetControllerType(RequestContext requestContext, string controllerName)
        {
            return base.GetControllerType(requestContext, controllerName);
        }
        public BasedOnDefaultControllerFactory()
        {
           
        }
    }
}