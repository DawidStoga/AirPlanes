using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AirPlane.WebUI.Infrastructure
{
    public class CustomActionInvoker : IActionInvoker
    {
        public bool InvokeAction(ControllerContext controllerContext, string actionName)
        {
            if (actionName == "Index-On")
            {
                controllerContext.HttpContext.Response.Write("This is the output from Index");
                return true;
            }
            else
                return false;
        }
    }
}