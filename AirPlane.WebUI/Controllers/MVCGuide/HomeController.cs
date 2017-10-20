using AirPlane.Domain.Abstract;
using AirPlane.WebUI.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AirPlane.WebUI.Controllers
{
    public class HomeController : Controller
    {


        public HomeController()
        {
            //total cusrtomActionInvoker
            // this.ActionInvoker = new CustomActionInvoker();
            //Modified Web.MVc ActionInvoker
            this.ActionInvoker = new CustomActionInvokerBasedOnDefault();

        }
        // GET: Homes
        [ActionName("Index-Off")]
    
        public void Index()
        {
            HttpContext.Response.Write("Main Home Controller /index");
        }

        public void Help()
        {
            HttpContext.Response.Write("Main Home Controller/Help");
        }

        [NonAction]
        public void About()
        {
            HttpContext.Response.Write("About");
        }

        public void Result()
        {
            HttpContext.Response.Write("Result");
        }


    }
}