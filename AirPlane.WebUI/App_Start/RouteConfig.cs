using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AirPlane.WebUI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name: "AllCategorty",
                url: "",
                defaults: new { controller = "AirCraft", action = "List", category = (string)null, page = 1 }
                );

            routes.MapRoute(
               name: "Paging",
               url: "P{page}",
               defaults: new { controller = "AirCraft", action = "List", category = (string)null }, 
               constraints: new { page = @"\d+" }
               );

            routes.MapRoute("CategoryOnly",
                "{category}",
                new { controller = "AirCraft", action = "List", page = 1 }
                );

            routes.MapRoute("CateforyAndPage",
            "{category}/P{page}",
            new { controller = "AirCraft", action = "List" },
            new { page = @"\d+" }
            );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}",
                defaults: new { controller = "AirCraft", action = "List", id = UrlParameter.Optional }
            );
        }
    }
}
