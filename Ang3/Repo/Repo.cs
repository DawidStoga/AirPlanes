using Ang3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ang3.Repo
{
    public static class Repository
    {

        public static List<Plane> GetAllPlanes()
        {
            return new List<Plane>
            {
  new Plane { id = 11,  name = "A320", Smodel = "AirBus", Stype ="Passenger" },
  new Plane { id = 12, name = "A380",Smodel = "AirBus",Stype ="Passenger" },
  new Plane { id = 13, name = "A318",Smodel = "AirBus",Stype ="Passenger" },
  new Plane { id = 14, name = "A330",Smodel = "AirBus",Stype ="Passenger" },

  new Plane { id = 15, name = "707",Smodel = "Boeing",Stype ="Passenger" },
  new Plane { id = 16, name = "737", Smodel = "Boeing",Stype ="Passenger" },
  new Plane { id = 17, name = "747" ,Smodel = "Boeing",Stype ="Passenger" },
  new Plane { id = 18, name = "CRJ" ,Smodel = "Boeing",Stype ="Passenger" },
  new Plane { id = 19, name = "Challenger" ,Smodel = "Bombardier",Stype ="Passenger" },
  new Plane { id = 20, name = "Learjet",Smodel = "Bombardier",Stype ="Passenger" }
            };
        }
    }
}