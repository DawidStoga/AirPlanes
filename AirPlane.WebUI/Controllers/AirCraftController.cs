using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AirPlane.Domain.Abstract;
using AirPlane.Domain.Entities;
using AirPlane.WebUI.Models;
using System.Web.UI.WebControls;

namespace AirPlane.WebUI.Controllers
{
    public class AirCraftController : Controller
    {
      
        public int PageSize = 5;
        private IAirPlaneRepository repository;
        private IStudentRepository repositoryStudent;
        public AirCraftController(IAirPlaneRepository ctrolRepository, IStudentRepository ctrolStRepository)
        {
            repository = ctrolRepository;
            repositoryStudent = ctrolStRepository;
        }


        public ViewResult List(string category,int page = 1)
        { 
            var varAirplanes = repository.AirCrafts.Where(p => category == null || p.Category == category ).
               OrderBy(p => p.AircraftID);
              

            PlanesListViewModel PlaneList = new PlanesListViewModel
            {  Airplanes=  varAirplanes.Skip((page - 1) * PageSize).Take(PageSize),
            pagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = varAirplanes.Count()
                },
                currentCategory = category
            };
        
            return View(PlaneList);
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
        [Route("Pokaz /{id}")]
        public ViewResult pokaz()
        {
            return View();
        }
       
    }
}