using Autofac.Integration.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutoFacDemo.Infrastructure
{

    [ModelBinderType(typeof(Message))]
    public class MessageBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            var result = new Message();

            var session = controllerContext.HttpContext.Request.Params;
            var info = bindingContext.ValueProvider.GetValue("message");
            var date = bindingContext.ValueProvider.GetValue("date");

            if (info == null)
            {
                result.Information = "No information";
            }
            else
            {
                result.Information = info.AttemptedValue;
            }

            var dateTime = new DateTime();

            var retDate = date!=null ? date.AttemptedValue : "";

            return result;
        }
    }
}