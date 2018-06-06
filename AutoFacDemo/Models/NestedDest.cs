using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoFacDemo.Models
{
    public class InnerDest
    {
        public int value3 { get; set; }
    }

    public class OuterDest: ParentDest
    {
        public int value1 { get; set; }
        public InnerDest value2 { get; set; }

        public int Total { get; set; }
    }

    public class ParentDest
    {
        public int value4{ get; set; }
    }
}
