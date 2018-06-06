using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoFacDemo.Models
{
    public class InnerSource
    {
        public int value3 { get; set; }
    }

    public class OuterSource : ParentSource
    {
        public int value1 { get; set; }
        public InnerSource value2 { get; set; }
    }

    public class ParentSource
    {
        public int value4 { get; set; }
    }

}