﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AirPlane.WebUI.Controllers.RoutingURL
{
    public class LegacyController : Controller
    {
        // GET: Legacy
        public ActionResult GetLegacyURL(string legacyUrl)
        {
            return View((object)legacyUrl);
        }
    }
}