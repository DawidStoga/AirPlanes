using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoFacDemo.Infrastructure
{
    public class Message : IMessages
    {
        public string getMessage(string input = "No message")
        {
            return input;
        }

        public string Information { get; set; }
        public DateTime Time { get; set; }
    }
}