using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AirPlane.WebUI.Controllers.RoutingURL.Infrastructure
{

    // with static result
    public class RangeExceptionAttribute : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
          if( !filterContext.ExceptionHandled && filterContext.Exception is ArgumentOutOfRangeException )
            {
                filterContext.Result = new RedirectResult("~/Content/RangeErrorPage.html");
                filterContext.HttpContext.Response.Write("ERROR");
                filterContext.ExceptionHandled = true;
            }
        }

    }

    // with viewResult
    public class RangeExceptionViewAttribute : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            if (!filterContext.ExceptionHandled && filterContext.Exception is ArgumentOutOfRangeException)
            {
                var id = (int)(((ArgumentOutOfRangeException)filterContext.Exception).ActualValue);
                filterContext.Result = new ViewResult { ViewName = "RangeError", ViewData = new ViewDataDictionary<int>(id) };
                filterContext.ExceptionHandled = true;
            }
        }

    }
}