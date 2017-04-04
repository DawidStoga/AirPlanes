using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AirPlane.Domain.Abstract;
using AirPlane.Domain.Entities;
using AirPlane.WebUI.Models;
using System.Web.UI.WebControls;
using System.Web.Routing;
using AirPlane.WebUI.Models.ControllersAndActions;
using AirPlane.WebUI.Infrastructure;
using PagedList;
using System.Threading.Tasks;

namespace AirPlane.WebUI.Controllers
{
    public class AirCraftController : AsyncController   //todo Ascyncontrolelr
    {
        
        public int PageSize = 5;
        private IAirPlaneRepository repository;
        private IStudentRepository repositoryStudent;


        public AirCraftController(IAirPlaneRepository ctrolRepository, IStudentRepository ctrolStRepository)
        {
            repository = ctrolRepository;
            repositoryStudent = ctrolStRepository;
        }

        //protected override void HandleUnknownAction(string actionName)
        //{
        //    base.HandleUnknownAction(actionName);
        //   // HttpContext.Response.Write(actionName + " not found");
        //}
        [Local]
        public ViewResult List(string category, int page = 1)
        {
            var t = this.Request.Url;
            var varAirplanes = repository.AirCrafts.Where(p => category == null || p.Category == category).
               OrderBy(p => p.AircraftID).AsParallel();


            PlanesListViewModel PlaneList = new PlanesListViewModel
            { Airplanes = varAirplanes.ToPagedList(page, 2),


                /*varAirplanes.Skip((page - 1) * PageSize).Take(PageSize),*/
                pagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = varAirplanes.Count()
                },
                currentCategory = category
            };
            return View("List", PlaneList);
        }

     
        // GET: AirCraft
        public ActionResult Index()
        {
         
            var vPhotoFullImage = from x in repository.AirCrafts where x.FullImage != null select x;
            return View(repository.AirCrafts);
        }
        public FileContentResult GetImage(int AircraftID)
        {
            Aircraft prod = repository.AirCrafts
            .FirstOrDefault(p => p.AircraftID == AircraftID);
            if (prod != null && prod.FullImage!=null && prod.FullImage.HighResolutionBits!=null)
            {
                return File(prod.FullImage.HighResolutionBits, "image/jpeg")?? null;
            }
            else {
                return null;
            }
        }
        [Route("ShowMeTest/{id}")]
        public ViewResult Test()
        {
            return View();
        }

        public ActionResult PropertiesList()
        {
            var RequestH = Request.Headers;
            var ContrData = new ControllerData
            {
                userName = User.Identity.Name,
                serverName = Server.MachineName,
                clientIP = Request.UserHostAddress,
                dateStamp = HttpContext.Timestamp,
                tempdata = TempData
            };



        return View(ContrData);
        }

        public void ResponseAct()
        {
            Response.Redirect("/Aircraft/List/2");
        }
        public ActionResult ResponseCustom()
        {
            return new CustomRedirectResult { Url = "/Basic/Index" };
        }

        public RedirectToRouteResult Redirect(int id = 0)
        {
            if (id == 0)
            {
                return RedirectToRoute("AllCategorty");
            }

            else
            { 
                return RedirectToRoute(new { controller = "RouteHome", action = "Index", id = "dawid" });
            }
        }
        public RedirectToRouteResult RedirectToOtherAction()
        {
            return RedirectToAction("ResponseAct");
        }

        public RedirectToRouteResult RedirectToOtherActionAndContr()
        {

            TempData["MessageFromAircraft"] = "RedirectToOtherActionAndContr";
            TempData["Date"] = DateTime.Now;
            return RedirectToAction("ParamIndex", "Custom"); 
        }

    }
}