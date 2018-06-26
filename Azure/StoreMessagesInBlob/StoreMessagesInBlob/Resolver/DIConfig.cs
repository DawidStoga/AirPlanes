using Autofac;
using AutofacDIExample.Modules;
using StoreMessagesInBlob.DependencyInjector.Configuration;
using System;

namespace AutofacDIExample.Resolvers
{
    public class DIConfig
    {
        public DIConfig(string functionName)
        {
            IoC.Initialize(builder =>
            {
                builder.RegisterModule(new TestModule());
            }, functionName);
        }
    }
}
