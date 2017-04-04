using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AirPlane.WebUI.Areas.Section1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Section1/Home
        public void Index()
        {
           HttpContext.Response.Write("ControllerHomeFromArea");
        }
    }
}