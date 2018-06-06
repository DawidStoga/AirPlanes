using AutoFacDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoFacDemo.Repository
{
    public class Repository
    {
        private Aircraft machine { get; set; }

        public static Aircraft GetAircraft()
        {
            return new Aircraft
            {
                AircraftID = 2,
                Category = "transport",
                Description = "used in Ukraine",
                EngineCnt = 4,
                Name = "Antonov",
                Type = "AN-225",
                ImageURl = "www.none.pl",
                AirLines = new List<Airline>
                {
                    new Airline{Country = "UKR",
                    Logo = new byte[] {0xdd,0x45},
                    Name = "Trans AN",
                    PlaneId = 2
                    }
                }
            };
        }
    }
}