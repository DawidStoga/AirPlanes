using AirPlane.WebUI.Controllers.RoutingURL.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace AirPlane.WebUI.Controllers.RoutingURL
{


  
    [Authorize(Users ="admin")]
    public class CustomController : Controller
    {
        private string DataEntity = null;
        public CustomController()
        {
            DataEntity = "Custom Entity";
        }
        // GET: RouteCustom
        public void  ParamIndex (int id=121)
        {
            var infos = TempData["MessageFromAircraft"] + " " + ((DateTime)(TempData["Date"])).ToShortTimeString();
            HttpContext.Response.Write(id);
            HttpContext.Response.Write(DataEntity);
            HttpContext.Response.Write(infos);
        }

        //Custom/Index/
        public ActionResult Index()
        {
           
            ViewBag.Controller = Json(this).Data;
            ViewBag.Action = "Index";
            return View("ActionName", RouteData.Values);

        }
       

        public ActionResult CustomVariable()
        {
            ViewBag.Controller = Json(this).Data;
            ViewBag.Action = "CustomVariable";
           
            
            return View("ActionName", RouteData.Values);
        }

        public ActionResult ShowImage()
        {
            ViewBag.CustomVariable = RouteData.Values["id"];
            return View();
        }

        public HttpStatusCodeResult StatusCode404()
        {
            return new HttpStatusCodeResult(HttpStatusCode.NotFound, "Thkis address was not found");
        }
        public HttpStatusCodeResult StatusCodeNotFound()
        {
            return HttpNotFound("This address was not found");
        }
        
        public ActionResult /*HttpStatusCodeResult*/ StatusCode401()
        {
            return new HttpUnauthorizedResult("You have no permission");
        }

        public void WithoutFilter()
        {
            if (Request.IsAuthenticated)
            { HttpContext.Response.Write("WithoutFilter Authenticated"); }
            else
            {
                HttpContext.Response.Write("WithoutFilter Not Authenticated");
            }
        }
     
        [OutputCache(Duration =60)]
        public void WithGeneralFilter()
        {
            if (Request.IsAuthenticated)
            { HttpContext.Response.Write("WithoutFilter Authenticated"); }
            else
            {
                HttpContext.Response.Write("WithoutFilter Not Authenticated");
            }
        }
        [CustomAuthAttributes(false)]
        public string CustomFilter()
        {
            return "this Action uses customFiler";
        }
        [CustomAuthAttributes(true)]
        public string CustomFilterLocal()
        {
            return "this Action uses customFilerLocal";
        }
        [RangeException]
        public string RangeTest(int id)
        {
           if( id <100 )
            {
                return String.Format("Value of id : {0}", id);
            }
           else
            {
                throw new ArgumentOutOfRangeException("ïd", id, "Error");
            }
        }

        [RangeExceptionView]
        public string RangeTestView(int id = 0)
        {
            if (id < 100)
            {
                return String.Format("Value of id : {0}", id);
            }
            else
            {
                throw new ArgumentOutOfRangeException("ïd", id, "Error");
            }
        }
    }
}