using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AirPlane.WebUI.Controllers.RoutingURL
{
    public class RouteHomeController : Controller
    {
        // GET: RouteHome
        public ActionResult Index(string id = "empty")
        {
            ViewBag.Controller = Json(this).Data;
            ViewBag.Action = "Index";
            return View("ActionName", RouteData.Values);
        }
        public ViewResult MyActionMethod()
        {
            var myActionUrl     = Url.Action("Index", new { id = "MyId" });
            string myRouteUrl = Url.RouteUrl(new { controller = "Admin", action = "Index" });
            return View("ActionName", RouteData.Values);
        }

        public RedirectToRouteResult BackToList()
        {
            return RedirectToAction("List", "AirCraft");
        }

        public RedirectToRouteResult BackToListRoute()
        {
            return RedirectToRoute(new { contreollr = "Cart", action = "Checkout" });
        }
    }
}