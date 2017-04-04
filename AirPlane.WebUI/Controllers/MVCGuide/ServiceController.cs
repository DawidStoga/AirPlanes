using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ServiceModel.Channels;
using System.ServiceModel;


namespace AirPlane.WebUI.Controllers.MVCGuide
{
    public class ServiceController : Controller
    {
        // GET: Service
        public ActionResult Index()
        {
            Binding wsBinding = new WSHttpBinding();
            EndpointAddress endpoint = new EndpointAddress("http://localhost:8005/Service1");


            // return View();
            using (ServiceReference1.Service1Client obj = new ServiceReference1.Service1Client(wsBinding, endpoint))
          //  using (ServiceReference1.Service1Client obj = new ServiceReference1.Service1Client())
            {
                return View("Index", obj.GetData(25));
            }

               
           
        }
        // GET: Service
        public ActionResult GetData()
        {
           
             ServiceReference1.Service1Client obj = new ServiceReference1.Service1Client();
            
            return View((object)obj.GetData(7));
        }
    }
}