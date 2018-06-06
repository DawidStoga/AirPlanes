using AutoFacDemo.Infrastructure;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoFacDemo.Controllers
{
    public class HomeController : Controller
    {

        IMapper mapper;
         public HomeController(IMessages messages, IMapper map)

        {
          this.ServiceClient = messages;
            this.mapper = map;

        }

        public ActionResult ShowMessage(string id)
        {
            return View((object)ServiceClient.getMessage(id));
        }


        private IMessages ServiceClient { get;  set; }

        public ActionResult Index()
        {
            var manager = new Manager.Manager(mapper);
            var machine = manager.GetMachine();
            

            return View();
        }

        [LogActionFilter]
        [HttpPost]
        public ActionResult SaveMessage(Message input)
        {
            return View(input);
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