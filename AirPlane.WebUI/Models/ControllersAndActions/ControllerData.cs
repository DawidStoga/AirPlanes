using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AirPlane.WebUI.Models.ControllersAndActions
{
    public class ControllerData
    {
        internal TempDataDictionary tempdata;

        public string userName { get; set; }
        public string serverName { get; set; }
        public string clientIP { get; set; }
        public DateTime dateStamp { get; set; }
   

    }
}