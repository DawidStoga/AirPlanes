using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AirPlane.WebUI.Controllers
{
    public class BasicController : IController
    {
        //Basic/Index
        public void Execute(RequestContext requestContext)
        {
            var controller = (string)requestContext.RouteData.Values["controller"];
            var action = (string)requestContext.RouteData.Values["action"];
            if (action.ToLower() == "planes")
            {
                requestContext.HttpContext.Response.Redirect("~/Aircraft/List");
            }
            else
            {
                requestContext.HttpContext.Response.Write($"{controller} controller     {action} action");
            }
        }
    }
}