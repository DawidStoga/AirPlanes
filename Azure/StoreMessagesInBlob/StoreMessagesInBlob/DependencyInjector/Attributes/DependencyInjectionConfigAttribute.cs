using System;
using System.Collections.Generic;
using System.Text;

namespace StoreMessagesInBlob.DependencyInjector.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    class DependencyInjectionConfigAttribute :Attribute
    {

        public Type Config { get; }

        public DependencyInjectionConfigAttribute(Type config)
        {
            Config = config;
        }
    }
}
