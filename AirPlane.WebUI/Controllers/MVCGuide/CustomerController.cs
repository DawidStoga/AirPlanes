using AirPlane.WebUI.Models.ControllerExtensibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.SessionState;

namespace AirPlane.WebUI.Controllers
{
    [SessionState(SessionStateBehavior.Disabled)] 
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            Session["cust1"] = "Session Open";
            return View("Result", new Result { ActionName = "Index", ControllerName = "Customer" });
        }

        // GET: Customer
        public ActionResult List()
        {
            return View("Result", new Result { ActionName = "List", ControllerName = "Customer" });
        }
    }
}