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
            this.ActionInvoker = new CustomActionInvoker();
        }
        // GET: Homes
        [ActionName("Index-On")]
    
        public void Index()
        {
            HttpContext.Response.Write("Main Home Controller");
        }
        [NonAction]
        public void About()
        {
            HttpContext.Response.Write("About");
        }

       
    }
}