using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AirPlane.WebUI.Controllers.RoutingURL
{
    public class AdminController : Controller
    {
        // GET: Admin
        public void Index()
        {
            HttpContext.Response.Write("RoutingURL/Home");
        }
    }
}