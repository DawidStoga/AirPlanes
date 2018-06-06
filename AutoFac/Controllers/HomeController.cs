using AutoFac.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoFac.Controllers
{
    public class HomeController : Controller
    {
          IMessage message;
          HomeController(IMessage Inputmessage)
        {
            this.message = Inputmessage;

        }
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Message(string message)
        {

            var outMessage  = this.message.ReturnMessage(message);
            return View(outMessage);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}