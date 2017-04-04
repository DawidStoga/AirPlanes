using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AirPlane.WebUI.Controllers.RoutingURL.Infrastructure
{
    public class LegacyRoute : RouteBase
    {
        private string[] Urls;
        public LegacyRoute(params string[] targetUrls)
        {
            Urls = targetUrls;
        }
        public override RouteData GetRouteData(HttpContextBase httpContext)
        {
            RouteData result = null;
            string requestedUrl =
                httpContext.Request.AppRelativeCurrentExecutionFilePath;
            if(Urls.Contains(requestedUrl,StringComparer.OrdinalIgnoreCase))
            {
                result = new RouteData(this, new MvcRouteHandler());
                result.Values.Add("controller", "Legacy");
                result.Values.Add("action", "GetLegacyUrl");
                result.Values.Add("legacyUrl", requestedUrl);
            }
            return result;
        }

        public override VirtualPathData GetVirtualPath(RequestContext requestContext, RouteValueDictionary values)
        {
            VirtualPathData result = null;
            if(Urls.Contains((string)values["legacyUrl"],StringComparer.OrdinalIgnoreCase ))
            {
                result = new VirtualPathData(this, new UrlHelper(requestContext).Content((string)values["LegacyUrl"]).Substring(1));

            }
            return result ;
        }
    }
}