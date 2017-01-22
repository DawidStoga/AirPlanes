using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AirPlane.WebUI.Models
{
    public class PlanesListViewModel
    {
        public PagingInfo pagingInfo { get; set; }
        public IEnumerable<AirPlane.Domain.Entities.Aircraft> Airplanes { get; set; }
        public string  currentCategory { get; set; }
    }
}