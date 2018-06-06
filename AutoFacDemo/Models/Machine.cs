using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoFacDemo.Models
{
    public class Machine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }

        public int EngineCnt { get; set; }

        public string ImageURl { get; set; }
        public byte[] ThumbnailBits { get; set; }

        public List<Airline> AirLines { get; set; }
    }
}