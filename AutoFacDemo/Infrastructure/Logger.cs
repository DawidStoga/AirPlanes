using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoFacDemo.Infrastructure
{
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            var  t = message.ToLower();
        }
    }
}