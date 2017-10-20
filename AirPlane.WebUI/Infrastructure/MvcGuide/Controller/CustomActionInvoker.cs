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
            if (actionName.StartsWith("Index"))
            {

                if (actionName == "Index-On")
                    controllerContext.HttpContext.Response.Write("This is the output from /Index-On");
                else
                    controllerContext.HttpContext.Response.Write("This is the output from /IndexXXXX");

                return true;
            }
            else
                //  controllerContext.HttpContext.Response.Write("This is the output from other than /IndexXXXX");
                return false;  //todo: Do not invoke resultView
        }
    }

    //System.Web.Mvc
    public class CustomActionInvokerBasedOnDefault : ControllerActionInvoker
    {
        public override bool InvokeAction(ControllerContext controllerContext, string actionName)
        {
            // For Index-On return text - for other return normal result
            if (actionName == "Index-On")
            {
                controllerContext.HttpContext.Response.Write("This is the output from /Index-On");
                return true;
            }
                
            else
                return base.InvokeAction(controllerContext, actionName);
        }
    }
}