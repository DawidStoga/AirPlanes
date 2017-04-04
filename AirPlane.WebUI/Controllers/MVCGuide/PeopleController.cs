using AirPlane.WebUI.Models.MVCGuide;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AirPlane.WebUI.Controllers.MVCGuide
{
    public class PeopleController : Controller
    {
        private Person[] personData =
        {
        new Person {FirstName = "Adam", LastName = "Freeman", Role =
        Role.Admin},
        new Person {FirstName = "Jacqui", LastName = "Griffyth", Role
        = Role.User},
        new Person {FirstName = "John", LastName = "Smith", Role =
        Role.User},
        new Person {FirstName = "Anne", LastName = "Jones", Role =
        Role.Guest}
        };

        // GET: People
        public ActionResult Index()
        {
            return View();
        }
        /*  AJAX  */
        public PartialViewResult GetPeopleData(string selectedRole = "All")
        {
            IEnumerable<Person> data = personData;
            if (selectedRole != "All")
            {
                Role selected = (Role)Enum.Parse(typeof(Role),
                selectedRole);
                data = personData.Where(p => p.Role == selected);
            }
            return PartialView(data);
        }
        public ActionResult GetPeople()
        {
            return View(personData);
        }
        public ActionResult GetPeopleAjax(string selectedRole = "All")
        {
            return View((object)selectedRole);
        }
        [HttpPost]
        public ActionResult GetPeople(string selectedRole)
        {
            if (selectedRole == null || selectedRole=="All")
            {
                return View(personData);
            }
            else
            {
                Role selected = (Role)Enum.Parse(typeof(Role), selectedRole);
                return View(personData.Where(p => p.Role == selected));

            }
        }



        /*  JSON */

        private IEnumerable<Person> GetDataJson(string selectedRole ="ALL")
        {
            IEnumerable<Person> data = personData;
            if(selectedRole !="ALL")
            {
                Role selected = (Role)Enum.Parse(typeof(Role), selectedRole);
                data = personData.Where(p => p.Role == selected);
            }
            return data;
        }

        public JsonResult GetPeopleDataJson(string selectedRole = "ALL")
        { if (Request.IsAjaxRequest())
            {


                var data = GetDataJson(selectedRole).Select(p =>
                new
                {
                    FirstName = p.FirstName,
                    LastName = p.LastName,
                    Role = Enum.GetName(typeof(Role), p.Role)
                });
                return Json(data, JsonRequestBehavior.AllowGet);
            }
            return null;
            //todo else..
          
        }

        public PartialViewResult GetPeopleDataJ(string selectedRole ="All")
        {
            return PartialView(GetDataJson(selectedRole));
        }
    }
}


