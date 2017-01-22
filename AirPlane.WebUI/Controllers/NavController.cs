using AirPlane.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AirPlane.WebUI.Controllers
{
    public class NavController : Controller
    {
        private IAirPlaneRepository repository;
        // GET: Nav
        /*public ActionResult Index()
        {
            return View();
        }*/
        public NavController(IAirPlaneRepository ctrolRepository)
        {
            repository = ctrolRepository;
        }
        public PartialViewResult Menu(string category = null)
        {
            ViewBag.SelectedCategory = category;
            IEnumerable<string> categories = repository.AirCrafts
.Select(x => x.Category)
.Distinct()
.OrderBy(x => x);
            return PartialView(categories);
        }
        
    
    }
}