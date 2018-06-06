using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoFac.Infrastructure.Implementation
{
    public class Message : IMessage
    {
        public int MessegeType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string ReturnMessage(string input)
        {
            return string.Format("New message on {0} : {1} \n", input, DateTime.Now.ToShortDateString());

        }
    }
}