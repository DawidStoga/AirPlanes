using AirPlane.WebUI.Infrastructure.Abstract;
using AirPlane.WebUI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AirPlane.WebUI.Controllers
{
    public class AccountResult: ActionResult
    {
        public override void ExecuteResult(ControllerContext context)
        {
           context.HttpContext.Response.Write("SORRY!");
        }
    }
    public class AccountController : Controller
    {
        IAuthProvider authProvider;



        public AccountController(IAuthProvider provider)
        {
            authProvider = provider;
        }
        // GET: Account

        public ViewResult Login()
        {
            return new ViewResult { ViewName = "Login" };
        }
        [HttpPost]
        public ActionResult Login(LoginViewModel model, string returnUrl)
        {
            if(ModelState.IsValid)
            {
            if( authProvider.Authenticate(model.UserName,model.Password))
                {
                    return Redirect(returnUrl ?? Url.Action("Index", "Admin"));
                }
            else
                {
                    ModelState.AddModelError("", "incorrect username or password");
                    return View();
                }
            }
            else
            {
            return View();
            }
            
        }
        public ActionResult Logins()
        {
            return new AccountResult();
        }
    }
}