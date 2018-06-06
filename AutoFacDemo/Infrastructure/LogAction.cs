using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoFacDemo.Infrastructure
{
    public class LogActionFilter: ActionFilterAttribute
    {
        public ILogger logger { get; set; }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            logger.Log(filterContext.ActionParameters.ToString());
        }
    }
}