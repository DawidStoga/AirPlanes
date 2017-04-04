using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AirPlane.WebUI.Controllers.RoutingURL.Infrastructure
{
    public class CustomAuthAttributes : AuthorizeAttribute
    {
        private bool localAllowed;
        public CustomAuthAttributes(bool allowParam)
        {
            localAllowed = allowParam;
        }
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {

            //return base.AuthorizeCore(httpContext);
            if (httpContext.Request.IsLocal)
            { return localAllowed; }
            else
                return true;
    
        }
    }
}