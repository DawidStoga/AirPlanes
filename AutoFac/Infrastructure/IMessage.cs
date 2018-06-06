using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFac.Infrastructure
{
    interface IMessage
    {
     int MessegeType { get; set; }
     string ReturnMessage(string input);
    }
}
