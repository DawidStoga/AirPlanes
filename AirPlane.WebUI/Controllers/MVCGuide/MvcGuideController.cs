using AirPlane.Domain.Abstract;
using AirPlane.WebUI.Models.MVCGuide;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AirPlane.WebUI.Controllers.MVCGuide
{
    public class MvcGuideController : Controller
    {
        Person person = null;
        private IStudentRepository repositoryStudent;
        public MvcGuideController(IStudentRepository ctrolStRepository)
        {
            repositoryStudent = ctrolStRepository;
            person = new Person { BirthDate = new DateTime(1954, 12, 2), FirstName = "Dawid", HomeAddress = new Address {City =  "Wroclaw" , Country= "Polska", Line1 = "ul. Slezna", Line2 = "21", PostalCode = "55-012"  }, IsApproved = false, LastName = "Kowalski", PersonId = 1, Role = Role.Guest };
        }

        public ActionResult EFAction()
        {

            
            return View(repositoryStudent.Students);
        }
        public ActionResult ControllerAction()
        {
            return View();
        }
        public ActionResult ViewAction()
        {
            return View();
        }
        // GET: MvcGuide
        public ActionResult HelperMethod()
        {
            
            return View(person);
        }
    }
}