using AirPlane.WebUI.Models.ControllerExtensibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AirPlane.WebUI.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View("Result",new Result { ActionName = "Index", ControllerName = "Product" });
        }

        // GET: Product
        public ActionResult List()
        {
            return View("Result", new Result { ActionName = "List", ControllerName = "Product" });
        }

        
    }
}