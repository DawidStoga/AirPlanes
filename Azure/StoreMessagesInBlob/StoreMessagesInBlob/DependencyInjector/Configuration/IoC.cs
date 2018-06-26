using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using AzureFunctions.Autofac.Exceptions;

namespace StoreMessagesInBlob.DependencyInjector.Configuration
{
    public static class IoC
    {
        private static Dictionary<string, IContainer> containers = new Dictionary<string, IContainer>();
        public static  void Initialize(Action<ContainerBuilder> cfg, string functionName)
        {
            if (!containers.ContainsKey(functionName))
            {
                ContainerBuilder builder = new ContainerBuilder();
                cfg(builder);
                var container = builder.Build();
                containers.Add(functionName, container);
            }

        }

        public static object Resolve(Type type, string name, string functionName)
        {
            if (containers.ContainsKey(functionName))
            {
                var container = containers[functionName];
                object resolved = null;
                if (string.IsNullOrWhiteSpace(name))
                {
                    resolved = container.Resolve(type);
                }
                else
                {
                    resolved = container.ResolveNamed(name, type);
                }
                return resolved;
            }
            else
            {
                throw new InitializationException("DependencyInjection.Initialize must be called before dependencies can be resolved.");
            }
        }
    }
}
